using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Web.UI.WebControls;
using static POS___Point_of_Sale___Programming_Champs.Form3;

namespace POS___Point_of_Sale___Programming_Champs
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            DisplayCategories();
            Search_TextBox.TextChanged += Search_TextBox_TextChanged;
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


        private void Form2_Load(object sender, EventArgs e)
        {

        }

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

        private void Products_Panel_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
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


        //


        public class Category
        {
            public string Name { get; set; }
            public int TotalQuantity { get; set; }
        }



        private List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            // string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=POS_DB.accdb";

            string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = \"C:\\Program Files\\Default Company Name\\Programming_Champs_POS\\POS_DB.accdb\"";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Category, SUM(Quantity) AS TotalQuantity FROM Stock GROUP BY Category";
                OleDbCommand command = new OleDbCommand(query, connection);

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(new Category
                        {
                            Name = reader["Category"].ToString(),
                            TotalQuantity = Convert.ToInt32(reader["TotalQuantity"])
                        });
                    }
                }
            }
            return categories;
        }



        private void DisplayCategories()
        {
            var categories = GetCategories();

            foreach (var category in categories)
            {
                CategoryCard card = new CategoryCard
                {
                    ProductCategory = category.Name,
                    ProductQuantity = category.TotalQuantity.ToString()
                };

                flowLayoutPanel1.Controls.Add(card);
            }
        }



        private void Search_TextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = Search_TextBox.Text.ToLower(); // Convert search text to lowercase for case-insensitive comparison

            // Iterate through each category card in the flowLayoutPanel
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is CategoryCard categoryCard)
                {
                    // Check if the category name contains the search text
                    bool containsText = categoryCard.ProductCategory.ToLower().Contains(searchText);

                    // Set visibility based on whether the category name contains the search text
                    categoryCard.Visible = containsText;
                }
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            // Get the category name from the TextBox
            string categoryName = guna2TextBox1.Text;

            InsertRecordToDatabase(categoryName);
        }

        private void InsertRecordToDatabase(string categoryName)
        {
            // Validate if both image path and category name are provided
            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please Provide Category Name to Store.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // Update the connection string with your database path
            string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = \"C:\\Program Files\\Default Company Name\\Programming_Champs_POS\\POS_DB.accdb\"";

            string query = "INSERT INTO Categories (Categories) VALUES (@name)";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", categoryName);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Record of Category Inserted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            guna2TextBox1.Text = "";

        }


    }
}
