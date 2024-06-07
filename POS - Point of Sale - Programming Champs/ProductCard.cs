using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POS___Point_of_Sale___Programming_Champs.Form3;

namespace POS___Point_of_Sale___Programming_Champs
{
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }

        private FlowLayoutPanel flowLayoutPanel2;
        private Form3 form3Instance; // Add a field to store the reference to Form3

        public ProductCard(FlowLayoutPanel flowLayoutPanel)
        {
            InitializeComponent();
            this.flowLayoutPanel2 = flowLayoutPanel;
            //this.form3Instance = form3; // Store the reference to Form3
        }


        private void ProductCard_Load(object sender, EventArgs e)
        {

        }
        // Properties with public getter
        public string ProductID { get { return ID_Label.Text; } set { ID_Label.Text = value; } }
        public string ProductName { get { return Product_Name.Text; } set { Product_Name.Text = value; } }
        public string ProductPrice { get { return Product_Price.Text; } set { Product_Price.Text = $"${value}"; } }
        public string ProductQuantity { get { return Product_Quantity.Text; } set { Product_Quantity.Text = value; } }
        public string ProductCategory { get { return Product_Category.Text; } set { Product_Category.Text = value; } }

        private void Add_To_Cart_Button_Click(object sender, EventArgs e)
        {
            string productName = ProductName;

            if (flowLayoutPanel2 == null)
            {
                MessageBox.Show("flowLayoutPanel2 is not initialized!");
                return;
            }

            // Check if the product is already in the billing section
            Billing_Item existingItem = null;
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                if (control is Billing_Item billItem && billItem.ProductName == productName)
                {
                    existingItem = billItem;
                    break;
                }
            }

            if (existingItem != null)
            {
                // Update the quantity of the existing item
                MessageBox.Show("Item is Already in CART Section. You can Increase Quantity in the CART Section if Needed.", "Item Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Create a new bill item control
                Billing_Item billItem = new Billing_Item();
                billItem.ProductName = productName;
                billItem.Price = ProductPrice; // Set the price here if needed
                billItem.Quantity = 1;
                billItem.MaxQuantity = int.Parse(ProductQuantity);

                // Add the new bill item control to the billing section

                flowLayoutPanel2.Controls.Add(billItem);

              

            }
        }
    }
}
