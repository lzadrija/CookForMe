namespace CookForMeApp
{
    partial class FrmEditDailyMenu
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
            this.buttonShowRecipe = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.treeViewSelectedRecipes = new System.Windows.Forms.TreeView();
            this.labelRecipes = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelMenuName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonShowRecipe
            // 
            this.buttonShowRecipe.Location = new System.Drawing.Point(55, 709);
            this.buttonShowRecipe.Name = "buttonShowRecipe";
            this.buttonShowRecipe.Size = new System.Drawing.Size(108, 31);
            this.buttonShowRecipe.TabIndex = 17;
            this.buttonShowRecipe.Text = "Show recipe";
            this.buttonShowRecipe.UseVisualStyleBackColor = true;
            this.buttonShowRecipe.Click += new System.EventHandler(this.buttonShowRecipe_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(247, 774);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 39);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(152, 774);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(89, 39);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // treeViewSelectedRecipes
            // 
            this.treeViewSelectedRecipes.Location = new System.Drawing.Point(55, 355);
            this.treeViewSelectedRecipes.Name = "treeViewSelectedRecipes";
            this.treeViewSelectedRecipes.Size = new System.Drawing.Size(402, 331);
            this.treeViewSelectedRecipes.TabIndex = 14;
            // 
            // labelRecipes
            // 
            this.labelRecipes.AutoSize = true;
            this.labelRecipes.Location = new System.Drawing.Point(52, 319);
            this.labelRecipes.Name = "labelRecipes";
            this.labelRecipes.Size = new System.Drawing.Size(240, 17);
            this.labelRecipes.TabIndex = 13;
            this.labelRecipes.Text = "Select or remove recipes from menu:";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(55, 145);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(402, 132);
            this.richTextBoxDescription.TabIndex = 12;
            this.richTextBoxDescription.Text = "";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(52, 107);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(83, 17);
            this.labelDescription.TabIndex = 11;
            this.labelDescription.Text = "Description:";
            // 
            // labelMenuName
            // 
            this.labelMenuName.AutoSize = true;
            this.labelMenuName.Location = new System.Drawing.Point(149, 59);
            this.labelMenuName.Name = "labelMenuName";
            this.labelMenuName.Size = new System.Drawing.Size(80, 17);
            this.labelMenuName.TabIndex = 10;
            this.labelMenuName.Text = "MenuName";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(52, 59);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 17);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Name:";
            // 
            // FrmEditDailyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 872);
            this.Controls.Add(this.buttonShowRecipe);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.treeViewSelectedRecipes);
            this.Controls.Add(this.labelRecipes);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelMenuName);
            this.Controls.Add(this.labelName);
            this.Name = "FrmEditDailyMenu";
            this.Text = "Edit Daily Menu";
            this.Load += new System.EventHandler(this.FrmEditDailyMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowRecipe;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TreeView treeViewSelectedRecipes;
        private System.Windows.Forms.Label labelRecipes;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelMenuName;
        private System.Windows.Forms.Label labelName;
    }
}