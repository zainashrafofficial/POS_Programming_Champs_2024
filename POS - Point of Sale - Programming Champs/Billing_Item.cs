using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS___Point_of_Sale___Programming_Champs
{
    public partial class Billing_Item : UserControl
    {
       
        public Billing_Item()
        {
            InitializeComponent();
            RemoveButton.Click += RemoveButton_Click;
            
        }

        private int _maxQuantity;

        public string ProductName
        {
            get { return Bill_Product_Name.Text; }
            set { Bill_Product_Name.Text = value; }
        }

        public string Price
        {
            get { return Bill_Product_Price.Text; }
            set { Bill_Product_Price.Text = value; } 
            // Automatically update total price when the price is set.
        }

        public int Quantity
        {
            get { return int.Parse(Bill_Product_Quantity.Text); }
            set { Bill_Product_Quantity.Text = value.ToString(); } // Ensure total price updates when quantity changes.
        }

        // New property to hold max quantity
        public int MaxQuantity
        {
            get { return _maxQuantity; }
            set { _maxQuantity = value; }
        }


        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (this.Parent is FlowLayoutPanel flowLayoutPanel)
            {
                // Remove the current control from the FlowLayoutPanel
                flowLayoutPanel.Controls.Remove(this);

            }
        }

        int additionquantity;

        string UnitPrice = null;
        private void Add_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Bill_Product_Quantity.Text, out int currentQuantity))
            {
                if (currentQuantity < MaxQuantity)
                {
                    // Increment the quantity if it is less than MaxQuantity
                    currentQuantity++;
                    Bill_Product_Quantity.Text = currentQuantity.ToString();

                    
                    if (UnitPrice == null)
                    {
                        UnitPrice = Bill_Product_Price.Text;
                        UnitPrice = new string(UnitPrice.Where(char.IsDigit).ToArray());
                    }
                  

                    string priceText = Bill_Product_Price.Text;

                
                    
                    priceText = new string(priceText.Where(char.IsDigit).ToArray());
                    int price = Convert.ToInt32(priceText);

                   
                    price = currentQuantity * Convert.ToInt32(UnitPrice);

                    Bill_Product_Price.Text = "$" + price.ToString();


                }
                else
                {
                    // Show message box when the maximum quantity is reached
                    MessageBox.Show("We do not have more products than this limit of quantity.", "Stock Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
             
            }
            else
            {
                // Handle parsing error, if any
                MessageBox.Show("Error reading quantity. Please check the input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Subtract_Quantity_Click(object sender, EventArgs e)
        {
            // Parse the current quantity
            if (int.TryParse(Bill_Product_Quantity.Text, out int currentQuantity))
            {
                // Check if the quantity is greater than 1 before decrementing
                if (currentQuantity > 1)
                {
                    // Decrement the quantity
                    currentQuantity--;

                    // Update the quantity text box
                    Bill_Product_Quantity.Text = currentQuantity.ToString();


                    string priceText = Bill_Product_Price.Text;



                    priceText = new string(priceText.Where(char.IsDigit).ToArray());
                    int price = Convert.ToInt32(priceText);


                    price = currentQuantity * Convert.ToInt32(UnitPrice);

                    Bill_Product_Price.Text = "$" + price.ToString();

                }
            }
        }





    }
}
