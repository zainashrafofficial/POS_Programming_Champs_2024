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
    public partial class Form6 : Form
    {
        public Form6()
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

        private void label6_Click_1(object sender, EventArgs e)
        {
            label7.Visible = true;
            panel3.Visible = true;
            label8.Visible = false;
            label12.Visible = false;
            label10.Visible = false;
            panel4.Visible = false;
            label9.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            label9.Visible = false;
            label11.Visible = false;
            label13.Visible = false;

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            panel3.Visible = false;
            label8.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            panel4.Visible = false;
            label10.Visible = true;
            label12.Visible = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label11.Visible = true;
            label12.Visible = false;
            panel5.Visible = true;
            label13.Visible = false;
            panel6.Visible = false;

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            label11.Visible = false;
            label12.Visible = true;
            panel5.Visible = false;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            label12.Visible = true;
            panel6.Visible = false;
            label13.Visible = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            label13.Visible = true;
            panel6.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
            label10.Visible = false;
            label12.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            label11.Visible = false;
            panel6.Visible = false;
            label13.Visible = false;
        }
    }
}
