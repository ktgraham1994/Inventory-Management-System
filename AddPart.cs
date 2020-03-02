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
    public partial class AddPart : Form
    {
        public MainScreen connect;
        public AddPart()
        {
            InitializeComponent();
        }
        private void savePart_Click(object sender, EventArgs e)
        {
            if (inHouseButton.Checked)
            {
                Inhouse inhouse = new Inhouse(int.Parse(partIDText.Text), nameText.Text, decimal.Parse(priceText.Text), int.Parse(inventoryText.Text),
                    int.Parse(minText.Text), int.Parse(maxText.Text), int.Parse(companyMachineText.Text));

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
                    Inventory.AddPart(inhouse);
                }
                Close();
            }

            else if (outsourcedButton.Checked)
            {
                Outsourced outsourced = new Outsourced(int.Parse(partIDText.Text), nameText.Text, decimal.Parse(priceText.Text), int.Parse(inventoryText.Text),
                    int.Parse(minText.Text), int.Parse(maxText.Text), companyMachineText.Text);

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
                    Inventory.AddPart(outsourced);
                }
                Close();
            }
        }

        private void inHouseButton_CheckedChanged(object sender, EventArgs e)
        {
            companyMachine.Text = "Machine ID";
        }

        private void outsourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            companyMachine.Text = "Company Name";
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
