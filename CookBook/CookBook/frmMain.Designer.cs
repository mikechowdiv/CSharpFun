namespace CookBook
{
    partial class frmMain
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
            this.cookbookDataSet = new CookBook.CookbookDataSet();
            this.lblRecipes = new System.Windows.Forms.Label();
            this.listRecipes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.cookbookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cookbookDataSet
            // 
            this.cookbookDataSet.DataSetName = "CookbookDataSet";
            this.cookbookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblRecipes
            // 
            this.lblRecipes.AutoSize = true;
            this.lblRecipes.Location = new System.Drawing.Point(22, 18);
            this.lblRecipes.Name = "lblRecipes";
            this.lblRecipes.Size = new System.Drawing.Size(46, 13);
            this.lblRecipes.TabIndex = 0;
            this.lblRecipes.Text = "Recipes";
            // 
            // listRecipes
            // 
            this.listRecipes.FormattingEnabled = true;
            this.listRecipes.Location = new System.Drawing.Point(25, 50);
            this.listRecipes.Name = "listRecipes";
            this.listRecipes.Size = new System.Drawing.Size(120, 303);
            this.listRecipes.TabIndex = 1;
            this.listRecipes.SelectedIndexChanged += new System.EventHandler(this.listRecipes_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 572);
            this.Controls.Add(this.listRecipes);
            this.Controls.Add(this.lblRecipes);
            this.Name = "frmMain";
            this.Text = "CookBook";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cookbookDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CookbookDataSet cookbookDataSet;
        private System.Windows.Forms.Label lblRecipes;
        private System.Windows.Forms.ListBox listRecipes;
    }
}

