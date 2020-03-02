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
    public partial class ModifyPart : Form
    {
        public ModifyPart(Inhouse inhouse)
        {
            InitializeComponent();

            partIDText.Text = Convert.ToString(inhouse.PartID);
            nameText.Text = inhouse.Name;
            priceText.Text = Convert.ToString(inhouse.Price);
            inventoryText.Text = Convert.ToString(inhouse.InStock);
            minText.Text = Convert.ToString(inhouse.Min);
            maxText.Text = Convert.ToString(inhouse.Max);
            companyMachineText.Text = Convert.ToString(inhouse.MachineID);
            inhouseButton.Checked = true;
        }
        public ModifyPart(Outsourced outsourced)
        {
            InitializeComponent();

            partIDText.Text = Convert.ToString(outsourced.PartID);
            nameText.Text = outsourced.Name;
            priceText.Text = Convert.ToString(outsourced.Price);
            inventoryText.Text = Convert.ToString(outsourced.InStock);
            minText.Text = Convert.ToString(outsourced.Min);
            maxText.Text = Convert.ToString(outsourced.Max);
            companyMachineText.Text = outsourced.CompanyName;
            outsourcedButton.Checked = true;
        }

        private void savePart_Click(object sender, EventArgs e)
        {
            if (inhouseButton.Checked)
            {
                inhouseButton.Checked = true;

                if (int.Parse(inventoryText.Text) < int.Parse(minText.Text) || int.Parse(inventoryText.Text) > int.Parse(maxText.Text))
                {
                    MessageBox.Show("Inventory can't be less than the minimum or greater than the maximum");
                }

                else if (int.Parse(minText.Text) > int.Parse(maxText.Text))
                {
                    MessageBox.Show("The minimum inventory can't be greater than the maximum");
                }

                else
                {
                    Inhouse inhouse = new Inhouse(int.Parse(partIDText.Text), nameText.Text, decimal.Parse(priceText.Text), int.Parse(inventoryText.Text),
                    int.Parse(minText.Text), int.Parse(maxText.Text), int.Parse(companyMachineText.Text));
                    Inventory.UpdatePart(int.Parse(partIDText.Text), inhouse);
                }
                Close();
            }
            else
            {
                outsourcedButton.Checked = true;

                if (int.Parse(inventoryText.Text) < int.Parse(minText.Text) || int.Parse(inventoryText.Text) > int.Parse(maxText.Text))
                {
                    MessageBox.Show("Inventory can't be less than the minimum or greater than the maximum");
                }

                else if (int.Parse(minText.Text) > int.Parse(maxText.Text))
                {
                    MessageBox.Show("The minimum inventory can't be greater than the maximum");
                }
                else
                {
                    Outsourced outsourced = new Outsourced(int.Parse(partIDText.Text), nameText.Text, decimal.Parse(priceText.Text), int.Parse(inventoryText.Text),
                    int.Parse(minText.Text), int.Parse(maxText.Text), companyMachineText.Text);
                    Inventory.UpdatePart(int.Parse(partIDText.Text), outsourced);
                }
                Close();
            }

        }

        private void Inhouse_CheckedChanged(object sender, EventArgs e)
        {
            companyMachine.Text = "Machine ID";
        }

        private void Outsourced_CheckedChanged(object sender, EventArgs e)
        {
            companyMachine.Text = "Company Name";
        }

        private void cancelPart_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
