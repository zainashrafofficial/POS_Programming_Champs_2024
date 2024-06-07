namespace POS___Point_of_Sale___Programming_Champs
{
    partial class CategoryCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.Product_Category = new System.Windows.Forms.Label();
            this.Product_Quantity = new System.Windows.Forms.Label();
            this.See_More_Button = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(66, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Qty.";
            // 
            // Product_Category
            // 
            this.Product_Category.AutoSize = true;
            this.Product_Category.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Category.ForeColor = System.Drawing.Color.Black;
            this.Product_Category.Location = new System.Drawing.Point(67, 59);
            this.Product_Category.Name = "Product_Category";
            this.Product_Category.Size = new System.Drawing.Size(78, 23);
            this.Product_Category.TabIndex = 29;
            this.Product_Category.Text = "Laptops";
            // 
            // Product_Quantity
            // 
            this.Product_Quantity.AutoSize = true;
            this.Product_Quantity.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Quantity.ForeColor = System.Drawing.Color.Blue;
            this.Product_Quantity.Location = new System.Drawing.Point(101, 99);
            this.Product_Quantity.Name = "Product_Quantity";
            this.Product_Quantity.Size = new System.Drawing.Size(44, 23);
            this.Product_Quantity.TabIndex = 30;
            this.Product_Quantity.Text = "(20)";
            // 
            // See_More_Button
            // 
            this.See_More_Button.BorderRadius = 8;
            this.See_More_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.See_More_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.See_More_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.See_More_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.See_More_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.See_More_Button.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.See_More_Button.ForeColor = System.Drawing.Color.White;
            this.See_More_Button.Location = new System.Drawing.Point(59, 148);
            this.See_More_Button.Name = "See_More_Button";
            this.See_More_Button.Size = new System.Drawing.Size(93, 32);
            this.See_More_Button.TabIndex = 32;
            this.See_More_Button.Text = "See More";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 8;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(224, 10);
            this.guna2Panel1.TabIndex = 33;
            // 
            // CategoryCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.See_More_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Product_Category);
            this.Controls.Add(this.Product_Quantity);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 40, 35);
            this.Name = "CategoryCard";
            this.Size = new System.Drawing.Size(215, 203);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Product_Category;
        private System.Windows.Forms.Label Product_Quantity;
        private Guna.UI2.WinForms.Guna2Button See_More_Button;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
