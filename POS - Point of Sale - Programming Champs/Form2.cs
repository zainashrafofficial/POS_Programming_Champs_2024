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

namespace POS___Point_of_Sale___Programming_Champs
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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

        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        OleDbDataReader reader;
        DataTable dataTable;


        void Show_Stock()
        {
            //conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"E:\\!Google Drive Data 2259\\!Today\\POS - Point of Sale - Programming Champs\\POS - Point of Sale - Programming Champs\\Assets\\POS_DB.accdb\"");

            //conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"E:\\!Google Drive Data 2259\\!Today\\POS - Point of Sale - Programming Champs\\Assets\\POS_DB.accdb\"");
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Program Files\\Default Company Name\\Programming_Champs_POS\\POS_DB.accdb\"");

            dataTable = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM Stock", conn);
            conn.Open();
            adapter.Fill(dataTable);
            Stock_Grid_View.DataSource = dataTable;
            conn.Close();
        }





        private void Dashboard_Panel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }




        private void Products_Panel_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
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




        private void Form2_Load(object sender, EventArgs e)
        {
            Show_Stock();
        }




        private void Save_Button_Click(object sender, EventArgs e)
        {
            // Validation //

            // Name TextBox Validation
            if (string.IsNullOrWhiteSpace(Name_Textbox.Text))
            {
                MessageBox.Show("Please Enter NAME of Product to Proceed Next.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // City TextBox Validation
            if (string.IsNullOrWhiteSpace(Category_Combobox.Text))
            {
                MessageBox.Show("Please Select Category to Proceed Next.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Title TextBox Validation
            if (string.IsNullOrWhiteSpace(Price_Textbox.Text))
            {
                MessageBox.Show("Please Enter PRICE to Proceed Next.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Country TextBox Validation
            if (string.IsNullOrWhiteSpace(Quantity_Textbox.Text))
            {
                MessageBox.Show("Please Enter QUANTITY to Proceed Next.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO Stock (Name, Category, Price, Quantity)" +
                "VALUES (@name, @category, @price, @quantity)";

            cmd = new OleDbCommand(query, conn);

            cmd.Parameters.AddWithValue("@name", Name_Textbox.Text);
            cmd.Parameters.AddWithValue("@category", Category_Combobox.Text);
            cmd.Parameters.AddWithValue("@price", Price_Textbox.Text);
            cmd.Parameters.AddWithValue("@quantity", Quantity_Textbox.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Congratulations! Product is Added Successfully.", "Product Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Show_Stock();
        }



        private void Grid_Cell_Focus(object sender, DataGridViewCellEventArgs e)
        {
            ID_TextBox.Text = Stock_Grid_View.CurrentRow.Cells[0].Value.ToString();
            Name_Textbox.Text = Stock_Grid_View.CurrentRow.Cells[1].Value.ToString();
            Category_Combobox.Text = Stock_Grid_View.CurrentRow.Cells[2].Value.ToString();
            Price_Textbox.Text = Stock_Grid_View.CurrentRow.Cells[3].Value.ToString();
            Quantity_Textbox.Text = Stock_Grid_View.CurrentRow.Cells[4].Value.ToString();
        }




        private void Delete_Button_Click(object sender, EventArgs e)
        {
            // Display a Confirmation Dialog
            DialogResult result = MessageBox.Show("Are you sure you want to Delete the Selected Product?", "Confirm Deletion!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If Yes
            if (result == DialogResult.Yes)
            {
                // Deletion Code
                string query = "DELETE FROM Stock WHERE Id = @id";
                cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(ID_TextBox.Text));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("The Selected Record is Deleted Successfully!", "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Show_Stock();
            }

            // If No
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Deletion Canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void Update_Button_Click(object sender, EventArgs e)
        {
            string query = " UPDATE Stock " +
                 "SET Name=@name,Category=@category,Price=@price,Quantity=@quantity " +
                 "WHERE Id=@id";


            cmd = new OleDbCommand(query, conn);

            cmd.Parameters.AddWithValue("@name", Name_Textbox.Text);
            cmd.Parameters.AddWithValue("@category", Category_Combobox.Text);
            cmd.Parameters.AddWithValue("@price", Price_Textbox.Text);
            cmd.Parameters.AddWithValue("@quantity", Quantity_Textbox.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(ID_TextBox.Text));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Selected Record Data is Updated Successfully", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Show_Stock();
        }


        private DataTable originalDataSource;

        private void Search_Button_Click(object sender, EventArgs e)
        {
            string searchText = Search_TextBox.Text.ToLower();

            // Filter the data source based on the search criteria
            DataTable filteredData = dataTable.Clone();

            foreach (DataRow row in dataTable.Rows)
            {
                bool rowVisible = false;

                foreach (var item in row.ItemArray)
                {
                    if (item.ToString().ToLower().Contains(searchText))
                    {
                        rowVisible = true;
                        break;
                    }
                }

                if (rowVisible)
                {
                    filteredData.ImportRow(row); // Add matching rows to the filtered data table
                }
            }

            // Bind the filtered data to the DataGridView
            Stock_Grid_View.DataSource = filteredData;

            Search_TextBox.Text = "";
        }


        private void Reset_Button_Click(object sender, EventArgs e)
        {
            // Restore the original data source to the DataGridView
            //Stock_Grid_View.DataSource = originalDataSource;
            Show_Stock();
        }



    }
}
