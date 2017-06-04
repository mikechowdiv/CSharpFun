namespace _15_9_RestaurantBillCalculator
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbDrinks = new System.Windows.Forms.ComboBox();
            this.cmbMeals = new System.Windows.Forms.ComboBox();
            this.cmbDesserts = new System.Windows.Forms.ComboBox();
            this.cmbAppetizers = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbDrinks
            // 
            this.cmbDrinks.FormattingEnabled = true;
            this.cmbDrinks.Items.AddRange(new object[] {
            "Soda $1.95 ",
            "Tea $1.50 ",
            "Coffee $1.25 ",
            "Mineral Water $2.95",
            "Juice $2.50 ",
            "Milk $1.50"});
            this.cmbDrinks.Location = new System.Drawing.Point(8, 12);
            this.cmbDrinks.Name = "cmbDrinks";
            this.cmbDrinks.Size = new System.Drawing.Size(121, 21);
            this.cmbDrinks.TabIndex = 0;
            this.cmbDrinks.Text = "Beverages";
            this.cmbDrinks.SelectedIndexChanged += new System.EventHandler(this.changingDropdown);
            // 
            // cmbMeals
            // 
            this.cmbMeals.FormattingEnabled = true;
            this.cmbMeals.Items.AddRange(new object[] {
            "Chicken Alfredo $13.95",
            "Chicken Picatta $13.95",
            "Turkey Club $11.95",
            "Lobster Pie $2.95",
            "Prime Rib $20.95",
            "Shrimp Scampi $18.95",
            "Turkey Dinner $13.95",
            "Stuffed Chicken $14.95",
            "Seafood Alfredo $15.95"});
            this.cmbMeals.Location = new System.Drawing.Point(161, 12);
            this.cmbMeals.Name = "cmbMeals";
            this.cmbMeals.Size = new System.Drawing.Size(121, 21);
            this.cmbMeals.TabIndex = 1;
            this.cmbMeals.Text = "Main Courses";
            this.cmbMeals.SelectedIndexChanged += new System.EventHandler(this.changingDropdown);
            // 
            // cmbDesserts
            // 
            this.cmbDesserts.FormattingEnabled = true;
            this.cmbDesserts.Items.AddRange(new object[] {
            "Apple Pie $5.95",
            "Sundae $3.95",
            "Carrot Cake $5.95",
            "Mud Pie $4.95",
            "Apple Crisp $5.95 "});
            this.cmbDesserts.Location = new System.Drawing.Point(161, 48);
            this.cmbDesserts.Name = "cmbDesserts";
            this.cmbDesserts.Size = new System.Drawing.Size(121, 21);
            this.cmbDesserts.TabIndex = 2;
            this.cmbDesserts.Text = "Desserts";
            this.cmbDesserts.SelectedIndexChanged += new System.EventHandler(this.changingDropdown);
            // 
            // cmbAppetizers
            // 
            this.cmbAppetizers.FormattingEnabled = true;
            this.cmbAppetizers.Items.AddRange(new object[] {
            "Buffalo Wings $5.95",
            "Buffalo Fingers $6.95",
            "Potato Skins $8.95 ",
            "Nachos $8.95",
            "Mushroom Caps $10.95",
            "Shrimp Cocktail $12.95",
            "Chips and Salsa $6.95"});
            this.cmbAppetizers.Location = new System.Drawing.Point(8, 48);
            this.cmbAppetizers.Name = "cmbAppetizers";
            this.cmbAppetizers.Size = new System.Drawing.Size(121, 21);
            this.cmbAppetizers.TabIndex = 3;
            this.cmbAppetizers.Text = "Appetizers";
            this.cmbAppetizers.SelectedIndexChanged += new System.EventHandler(this.changingDropdown);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(54, 269);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(193, 35);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(8, 92);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(274, 160);
            this.lstOutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 316);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbAppetizers);
            this.Controls.Add(this.cmbDesserts);
            this.Controls.Add(this.cmbMeals);
            this.Controls.Add(this.cmbDrinks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDrinks;
        private System.Windows.Forms.ComboBox cmbMeals;
        private System.Windows.Forms.ComboBox cmbDesserts;
        private System.Windows.Forms.ComboBox cmbAppetizers;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstOutput;
    }
}

