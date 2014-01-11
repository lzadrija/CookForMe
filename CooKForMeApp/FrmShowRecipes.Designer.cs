namespace CookForMeApp
{
    partial class FrmShowRecipes
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
            this.buttonRecipesDetails = new System.Windows.Forms.Button();
            this.labelRecipesTable = new System.Windows.Forms.Label();
            this.treeViewRecipes = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // buttonRecipesDetails
            // 
            this.buttonRecipesDetails.Location = new System.Drawing.Point(245, 712);
            this.buttonRecipesDetails.Name = "buttonRecipesDetails";
            this.buttonRecipesDetails.Size = new System.Drawing.Size(114, 34);
            this.buttonRecipesDetails.TabIndex = 5;
            this.buttonRecipesDetails.Text = "Recipes details";
            this.buttonRecipesDetails.UseVisualStyleBackColor = true;
            this.buttonRecipesDetails.Click += new System.EventHandler(this.buttonRecipesDetails_Click);
            // 
            // labelRecipesTable
            // 
            this.labelRecipesTable.AutoSize = true;
            this.labelRecipesTable.Location = new System.Drawing.Point(89, 50);
            this.labelRecipesTable.Name = "labelRecipesTable";
            this.labelRecipesTable.Size = new System.Drawing.Size(98, 17);
            this.labelRecipesTable.TabIndex = 4;
            this.labelRecipesTable.Text = "Recipes table:";
            // 
            // treeViewRecipes
            // 
            this.treeViewRecipes.Location = new System.Drawing.Point(92, 88);
            this.treeViewRecipes.Name = "treeViewRecipes";
            this.treeViewRecipes.Size = new System.Drawing.Size(419, 607);
            this.treeViewRecipes.TabIndex = 3;
            // 
            // FrmShowRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 796);
            this.Controls.Add(this.buttonRecipesDetails);
            this.Controls.Add(this.labelRecipesTable);
            this.Controls.Add(this.treeViewRecipes);
            this.Name = "FrmShowRecipes";
            this.Text = "View Recipes";
            this.Load += new System.EventHandler(this.FrmShowRecipes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRecipesDetails;
        private System.Windows.Forms.Label labelRecipesTable;
        private System.Windows.Forms.TreeView treeViewRecipes;
    }
}