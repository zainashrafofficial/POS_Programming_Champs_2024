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

namespace POS___Point_of_Sale___Programming_Champs
{
    public partial class Form1 : Form
    {

        //string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"E:\\!Google Drive Data 2259\\!Today\\POS - Point of Sale - Programming Champs\\Assets\\POS_DB.accdb\"";

        string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = \"C:\\Program Files\\Default Company Name\\Programming_Champs_POS\\POS_DB.accdb\"";

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            LoadChartData();
            Show_Sales();
        }

        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        OleDbDataReader reader;
        DataTable dataTable;

        void Show_Sales()
        {
           

           // conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"E:\\!Google Drive Data 2259\\!Today\\POS - Point of Sale - Programming Champs\\Assets\\POS_DB.accdb\"");

            conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = \"C:\\Program Files\\Default Company Name\\Programming_Champs_POS\\POS_DB.accdb\"");

            dataTable = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM Sales", conn);
            conn.Open();
            adapter.Fill(dataTable);
            Sales_Grid_View.DataSource = dataTable;
            conn.Close();
        }


        private void LoadChartData()
        {
            try
            {
                // Connect to the database
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    // SQL query to select Price and Quantity columns from the Stock table
                    string query = "SELECT Price, Quantity FROM Stock";

                    // Create a data adapter
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        // Create a DataTable to hold the data
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with data from the database
                        adapter.Fill(dataTable);

                        // Set the data source for the chart
                        chart1.DataSource = dataTable;

                        // Specify the X and Y values for the chart series
                        chart1.Series["Series1"].XValueMember = "Price";
                        chart1.Series["Series1"].YValueMembers = "Quantity";

                        // Bind the data to the chart
                        chart1.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

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

    }
}
