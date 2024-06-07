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
    public partial class CategoryCard : UserControl
    {


        public CategoryCard()
        {
            InitializeComponent();
        }

        public string ProductCategory
        {
            get { return Product_Category.Text; }
            set { Product_Category.Text = value; }
        }

        public string ProductQuantity
        {
            get { return Product_Quantity.Text; }
            set { Product_Quantity.Text = value; }
        }


    }
}
