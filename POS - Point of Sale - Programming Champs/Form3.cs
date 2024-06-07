using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POS___Point_of_Sale___Programming_Champs.Form3;

namespace POS___Point_of_Sale___Programming_Champs
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            DisplayProducts();
            flowLayoutPanel2 = new FlowLayoutPanel();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "" +
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        public FlowLayoutPanel BillingFlowLayoutPanel => flowLayoutPanel2;
        private Form3 form3Instance;

        private void Dashboard_Panel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void stock_panel_click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Categories_Panel_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void About_Panel_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void Help_Panel_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }


        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }



        //


        public class Product
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
        }


        private List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            //string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"E:\\!Google Drive Data 2259\\!Today\\POS - Point of Sale - Programming Champs\\Assets\\POS_DB.accdb\"";
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Program Files\\Default Company Name\\Programming_Champs_POS\\POS_DB.accdb\"";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID, Name, Price, Quantity, Category FROM Stock";
                OleDbCommand command = new OleDbCommand(query, connection);

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            ID = reader["ID"].ToString(),
                            Name = reader["Name"].ToString(),
                            Price = reader["Price"].ToString(),
                            Quantity = reader["Quantity"].ToString(),
                            Category = reader["Category"].ToString()
                        });
                    }
                }
            }
            return products;
        }


        private void DisplayProducts()
        {
            var products = GetProducts(); // Assume GetProducts() retrieves product data from the database

            foreach (var product in products)
            {
                ProductCard card = new ProductCard((flowLayoutPanel2))
                {
                    ProductID = product.ID,
                    ProductName = product.Name,
                    ProductPrice = product.Price,
                    ProductQuantity = product.Quantity,
                    ProductCategory = product.Category
                };

                flowLayoutPanel1.Controls.Add(card); // Assuming you have a FlowLayoutPanel named flowLayoutPanel1 on Form3
            }
        }

        private void Pay_Now_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You For Shopping!. You can give us feedback also.", "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);


            foreach (UserControl usercontrol in flowLayoutPanel2.Controls)
            {
               
                    flowLayoutPanel2.Controls.Remove(usercontrol);
                
            }

           
        }



    }
}
