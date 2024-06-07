namespace POS___Point_of_Sale___Programming_Champs
{
    partial class Billing_Item
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
            this.Subtract_Quantity = new System.Windows.Forms.Label();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.RemoveButton = new System.Windows.Forms.Label();
            this.Bill_Product_Quantity = new System.Windows.Forms.Label();
            this.Bill_Product_Name = new System.Windows.Forms.Label();
            this.Bill_Product_Price = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Subtract_Quantity
            // 
            this.Subtract_Quantity.AutoSize = true;
            this.Subtract_Quantity.BackColor = System.Drawing.Color.Transparent;
            this.Subtract_Quantity.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract_Quantity.ForeColor = System.Drawing.Color.Black;
            this.Subtract_Quantity.Location = new System.Drawing.Point(183, -3);
            this.Subtract_Quantity.Margin = new System.Windows.Forms.Padding(0);
            this.Subtract_Quantity.Name = "Subtract_Quantity";
            this.Subtract_Quantity.Size = new System.Drawing.Size(23, 33);
            this.Subtract_Quantity.TabIndex = 41;
            this.Subtract_Quantity.Text = "-";
            this.Subtract_Quantity.Click += new System.EventHandler(this.Subtract_Quantity_Click);
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.FillColor = System.Drawing.Color.Black;
            this.guna2Shapes1.LineThickness = 1;
            this.guna2Shapes1.Location = new System.Drawing.Point(-52, 25);
            this.guna2Shapes1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes1.Size = new System.Drawing.Size(443, 8);
            this.guna2Shapes1.TabIndex = 39;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // RemoveButton
            // 
            this.RemoveButton.AutoSize = true;
            this.RemoveButton.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.ForeColor = System.Drawing.Color.Red;
            this.RemoveButton.Location = new System.Drawing.Point(263, 6);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(20, 19);
            this.RemoveButton.TabIndex = 38;
            this.RemoveButton.Text = "X";
            // 
            // Bill_Product_Quantity
            // 
            this.Bill_Product_Quantity.AutoSize = true;
            this.Bill_Product_Quantity.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_Product_Quantity.ForeColor = System.Drawing.Color.Blue;
            this.Bill_Product_Quantity.Location = new System.Drawing.Point(207, 7);
            this.Bill_Product_Quantity.Name = "Bill_Product_Quantity";
            this.Bill_Product_Quantity.Size = new System.Drawing.Size(15, 16);
            this.Bill_Product_Quantity.TabIndex = 37;
            this.Bill_Product_Quantity.Text = "1";
            // 
            // Bill_Product_Name
            // 
            this.Bill_Product_Name.AutoSize = true;
            this.Bill_Product_Name.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_Product_Name.ForeColor = System.Drawing.Color.Black;
            this.Bill_Product_Name.Location = new System.Drawing.Point(5, 8);
            this.Bill_Product_Name.Name = "Bill_Product_Name";
            this.Bill_Product_Name.Size = new System.Drawing.Size(84, 16);
            this.Bill_Product_Name.TabIndex = 35;
            this.Bill_Product_Name.Text = "HP EliteBook";
            // 
            // Bill_Product_Price
            // 
            this.Bill_Product_Price.AutoSize = true;
            this.Bill_Product_Price.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_Product_Price.ForeColor = System.Drawing.Color.Blue;
            this.Bill_Product_Price.Location = new System.Drawing.Point(118, 7);
            this.Bill_Product_Price.Name = "Bill_Product_Price";
            this.Bill_Product_Price.Size = new System.Drawing.Size(15, 16);
            this.Bill_Product_Price.TabIndex = 36;
            this.Bill_Product_Price.Text = "1";
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.BackColor = System.Drawing.Color.Transparent;
            this.Add.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.Black;
            this.Add.Location = new System.Drawing.Point(228, 1);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(27, 30);
            this.Add.TabIndex = 40;
            this.Add.Text = "+";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Billing_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Bill_Product_Quantity);
            this.Controls.Add(this.guna2Shapes1);
            this.Controls.Add(this.Subtract_Quantity);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.Bill_Product_Name);
            this.Controls.Add(this.Bill_Product_Price);
            this.Name = "Billing_Item";
            this.Size = new System.Drawing.Size(291, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Subtract_Quantity;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private System.Windows.Forms.Label RemoveButton;
        private System.Windows.Forms.Label Bill_Product_Quantity;
        private System.Windows.Forms.Label Bill_Product_Name;
        private System.Windows.Forms.Label Bill_Product_Price;
        private System.Windows.Forms.Label Add;
    }
}
