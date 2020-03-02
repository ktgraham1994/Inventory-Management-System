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

    public partial class ModifyProduct : Form
    {
        public ModifyProduct(Product product)
        {
            InitializeComponent();

            candidateTable.DataSource = Inventory.AllParts;
            associatedTable.DataSource = product.AssociatedParts;
            idText.Text = Convert.ToString(product.ProductID);
            nameText.Text = product.Name;
            priceText.Text = Convert.ToString(product.Price);
            inventoryText.Text = Convert.ToString(product.InStock);
            minText.Text = Convert.ToString(product.Min);
            maxText.Text = Convert.ToString(product.Max);
        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            Part part = Inventory.LookupPart(Convert.ToInt32(searchText.Text));

            if (searchText.TextLength < 1)
            {
                return;
            }
            else
            {
                foreach (DataGridViewRow data in candidateTable.Rows)
                {
                    Part part1 = (Part)data.DataBoundItem;

                    if (part1.PartID == part.PartID)
                    {
                        data.Selected = true;
                    }
                    else
                    {
                        data.Selected = false;
                    }
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Part part = (Part)candidateTable.CurrentRow.DataBoundItem;
            Product product = Inventory.LookupProduct(int.Parse(idText.Text));
            product.AddAssociatedPart(part);
            Inventory.UpdateProduct(int.Parse(idText.Text), product);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Part part = (Part)associatedTable.CurrentRow.DataBoundItem;

            DialogResult delete = MessageBox.Show("Are you sure you want to delete? Can't be altered afterward.", "Confirm", MessageBoxButtons.YesNo);

            if (delete == DialogResult.Yes)
            {
                foreach (DataGridViewRow data in associatedTable.SelectedRows)
                {
                    associatedTable.Rows.RemoveAt(data.Index);
                }
            }
            else if (delete == DialogResult.No)
            {
                return;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            Product product = new Product(int.Parse(idText.Text), nameText.Text, decimal.Parse(priceText.Text), int.Parse(inventoryText.Text),
                int.Parse(minText.Text), int.Parse(maxText.Text));

            if (int.Parse(inventoryText.Text) < int.Parse(minText.Text) || int.Parse(inventoryText.Text) > int.Parse(maxText.Text))
            {
                MessageBox.Show("Inventory can't be less than the minimum or greater than the maximum");
            }

            else if (int.Parse(minText.Text) > int.Parse(maxText.Text))
            {
                MessageBox.Show("The minimum inventory can't be greater than the maximum");
            }


            foreach (DataGridViewRow data in associatedTable.Rows)
            {
                Part part = (Part)data.DataBoundItem;
                product.AssociatedParts.Add(part);
            }

            Inventory.UpdateProduct(int.Parse(idText.Text), product);
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
