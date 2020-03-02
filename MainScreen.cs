using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_PA
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            PartTable.DataSource = Inventory.AllParts;
            PartTable.ClearSelection();

            ProductTable.DataSource = Inventory.Products;
            ProductTable.ClearSelection();
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void addPart_Click(object sender, EventArgs e)
        {
            AddPart add = new AddPart();
            add.Show();
        }
        private void modPart_Click(object sender, EventArgs e)
        {
            if(PartTable.CurrentRow.DataBoundItem.GetType() == typeof(Inhouse))
            {
                Inhouse inhouse = (Inhouse)PartTable.CurrentRow.DataBoundItem;
                new ModifyPart(inhouse).ShowDialog();
            }
            else
            {
                Outsourced outsourced = (Outsourced)PartTable.CurrentRow.DataBoundItem;
                new ModifyPart(outsourced).ShowDialog();
            }
        }
        private void addProduct_Click(object sender, EventArgs e)
        {
            AddProduct add = new AddProduct();
            add.Show();
        }
        private void modProduct_Click(object sender, EventArgs e)
        {
            Product product = (Product)ProductTable.CurrentRow.DataBoundItem;
            new ModifyProduct(product).ShowDialog();
        }

        private void deletePart_Click(object sender, EventArgs e)
        {
            Part part = (Part)PartTable.CurrentRow.DataBoundItem;

            DialogResult delete = MessageBox.Show("Are you sure you want to delete? Can't be altered afterward.", "Confirm", MessageBoxButtons.YesNo);

            if (delete == DialogResult.Yes)
            {
                foreach (DataGridViewRow data in PartTable.SelectedRows)
                {
                    PartTable.Rows.RemoveAt(data.Index);
                }
            }
            else if (delete == DialogResult.No)
            {
                return;
            }
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            Product product = (Product)ProductTable.CurrentRow.DataBoundItem;

            DialogResult delete = MessageBox.Show("Are you sure you want to delete? Can't be altered afterward.", "Confirm", MessageBoxButtons.YesNo);

            if (delete == DialogResult.Yes)
            {
                if (product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("You can't delete a product that is assigned a part.");
                    return;
                }
                foreach(DataGridViewRow data in ProductTable.SelectedRows)
                {
                    ProductTable.Rows.RemoveAt(data.Index);
                }
            }
            else if(delete == DialogResult.No)
            {
                return;
            }
        }

        private void searchPart_Click(object sender, EventArgs e)
        {
            Part part = Inventory.LookupPart(Convert.ToInt32(PartSearch.Text));
            if(PartSearch is null)
            {
                return;
            }

            foreach(DataGridViewRow data in PartTable.Rows)
            {
                Part part1 = (Part)data.DataBoundItem;

                if(part1.PartID == part.PartID)
                {
                    data.Selected = true;
                }
                else
                {
                    data.Selected = false;
                }
            }
        }

        private void searchProduct_Click(object sender, EventArgs e)
        {
            Product product = Inventory.LookupProduct(Convert.ToInt32(ProductSearch.Text));

            if(ProductSearch is null)
            {
                return;
            }

            foreach(DataGridViewRow data in ProductTable.Rows)
            {
                Product product1 = (Product)data.DataBoundItem;

                if(product1.ProductID == product.ProductID)
                {
                    data.Selected = true;
                }
                else
                {
                    data.Selected = false;
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}