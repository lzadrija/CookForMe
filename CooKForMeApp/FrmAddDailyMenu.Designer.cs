namespace CookForMeApp
{
    partial class FrmAddDailyMenu
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
            this.labelMandatoryFields = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonAddNewRecipe = new System.Windows.Forms.Button();
            this.treeViewRecipes = new System.Windows.Forms.TreeView();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSaveDailyMenu = new System.Windows.Forms.Button();
            this.labelSelectRecipes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonShowRecipe
            // 
            this.buttonShowRecipe.Location = new System.Drawing.Point(202, 507);
            this.buttonShowRecipe.Name = "buttonShowRecipe";
            this.buttonShowRecipe.Size = new System.Drawing.Size(123, 31);
            this.buttonShowRecipe.TabIndex = 22;
            this.buttonShowRecipe.Text = "Show recipe";
            this.buttonShowRecipe.UseVisualStyleBackColor = true;
            this.buttonShowRecipe.Click += new System.EventHandler(this.buttonShowRecipe_Click);
            // 
            // labelMandatoryFields
            // 
            this.labelMandatoryFields.AutoSize = true;
            this.labelMandatoryFields.Location = new System.Drawing.Point(59, 629);
            this.labelMandatoryFields.Name = "labelMandatoryFields";
            this.labelMandatoryFields.Size = new System.Drawing.Size(121, 17);
            this.labelMandatoryFields.TabIndex = 21;
            this.labelMandatoryFields.Text = "* Mandatory items";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(168, 13);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(320, 22);
            this.textBoxName.TabIndex = 20;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(56, 75);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(83, 17);
            this.labelDescription.TabIndex = 19;
            this.labelDescription.Text = "Description:";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(56, 106);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(432, 96);
            this.richTextBoxDescription.TabIndex = 18;
            this.richTextBoxDescription.Text = "";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(56, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 17);
            this.labelName.TabIndex = 17;
            this.labelName.Text = "Name*:";
            // 
            // buttonAddNewRecipe
            // 
            this.buttonAddNewRecipe.Location = new System.Drawing.Point(56, 507);
            this.buttonAddNewRecipe.Name = "buttonAddNewRecipe";
            this.buttonAddNewRecipe.Size = new System.Drawing.Size(123, 31);
            this.buttonAddNewRecipe.TabIndex = 16;
            this.buttonAddNewRecipe.Text = "Add new recipe";
            this.buttonAddNewRecipe.UseVisualStyleBackColor = true;
            this.buttonAddNewRecipe.Click += new System.EventHandler(this.buttonAddNewRecipe_Click);
            // 
            // treeViewRecipes
            // 
            this.treeViewRecipes.Location = new System.Drawing.Point(56, 253);
            this.treeViewRecipes.Name = "treeViewRecipes";
            this.treeViewRecipes.Size = new System.Drawing.Size(435, 236);
            this.treeViewRecipes.TabIndex = 15;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(284, 572);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(85, 45);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSaveDailyMenu
            // 
            this.buttonSaveDailyMenu.Location = new System.Drawing.Point(168, 572);
            this.buttonSaveDailyMenu.Name = "buttonSaveDailyMenu";
            this.buttonSaveDailyMenu.Size = new System.Drawing.Size(85, 45);
            this.buttonSaveDailyMenu.TabIndex = 13;
            this.buttonSaveDailyMenu.Text = "Save";
            this.buttonSaveDailyMenu.UseVisualStyleBackColor = true;
            this.buttonSaveDailyMenu.Click += new System.EventHandler(this.buttonSaveDailyMenu_Click);
            // 
            // labelSelectRecipes
            // 
            this.labelSelectRecipes.AutoSize = true;
            this.labelSelectRecipes.Location = new System.Drawing.Point(53, 223);
            this.labelSelectRecipes.Name = "labelSelectRecipes";
            this.labelSelectRecipes.Size = new System.Drawing.Size(166, 17);
            this.labelSelectRecipes.TabIndex = 12;
            this.labelSelectRecipes.Text = "Select recipes for menu*:";
            // 
            // FrmAddDailyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 659);
            this.Controls.Add(this.buttonShowRecipe);
            this.Controls.Add(this.labelMandatoryFields);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonAddNewRecipe);
            this.Controls.Add(this.treeViewRecipes);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveDailyMenu);
            this.Controls.Add(this.labelSelectRecipes);
            this.Name = "FrmAddDailyMenu";
            this.Text = "Add Daily Menu";
            this.Load += new System.EventHandler(this.FrmAddDailyMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowRecipe;
        private System.Windows.Forms.Label labelMandatoryFields;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonAddNewRecipe;
        private System.Windows.Forms.TreeView treeViewRecipes;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSaveDailyMenu;
        private System.Windows.Forms.Label labelSelectRecipes;
    }
}