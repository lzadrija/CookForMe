namespace CookForMeApp
{
    partial class FrmSearch
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
            this.buttonShowDailyMenu = new System.Windows.Forms.Button();
            this.buttonShowRecipe = new System.Windows.Forms.Button();
            this.buttonShowIngredient = new System.Windows.Forms.Button();
            this.labelSearchCategories = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelDailyMenus = new System.Windows.Forms.Label();
            this.labelRecipes = new System.Windows.Forms.Label();
            this.labelIngredients = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxDailyMenus = new System.Windows.Forms.ListBox();
            this.listBoxRecipes = new System.Windows.Forms.ListBox();
            this.listBoxIngredients = new System.Windows.Forms.ListBox();
            this.textBoxSearchParameters = new System.Windows.Forms.TextBox();
            this.checkedListBoxSearchCategories = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // buttonShowDailyMenu
            // 
            this.buttonShowDailyMenu.Location = new System.Drawing.Point(556, 617);
            this.buttonShowDailyMenu.Name = "buttonShowDailyMenu";
            this.buttonShowDailyMenu.Size = new System.Drawing.Size(95, 45);
            this.buttonShowDailyMenu.TabIndex = 27;
            this.buttonShowDailyMenu.Text = "Edit daily menu";
            this.buttonShowDailyMenu.UseVisualStyleBackColor = true;
            this.buttonShowDailyMenu.Click += new System.EventHandler(this.buttonShowDailyMenu_Click);
            // 
            // buttonShowRecipe
            // 
            this.buttonShowRecipe.Location = new System.Drawing.Point(329, 617);
            this.buttonShowRecipe.Name = "buttonShowRecipe";
            this.buttonShowRecipe.Size = new System.Drawing.Size(95, 45);
            this.buttonShowRecipe.TabIndex = 26;
            this.buttonShowRecipe.Text = "Show recipe";
            this.buttonShowRecipe.UseVisualStyleBackColor = true;
            this.buttonShowRecipe.Click += new System.EventHandler(this.buttonShowRecipe_Click);
            // 
            // buttonShowIngredient
            // 
            this.buttonShowIngredient.Location = new System.Drawing.Point(99, 617);
            this.buttonShowIngredient.Name = "buttonShowIngredient";
            this.buttonShowIngredient.Size = new System.Drawing.Size(95, 45);
            this.buttonShowIngredient.TabIndex = 25;
            this.buttonShowIngredient.Text = "Show ingredient";
            this.buttonShowIngredient.UseVisualStyleBackColor = true;
            this.buttonShowIngredient.Click += new System.EventHandler(this.buttonShowIngredient_Click);
            // 
            // labelSearchCategories
            // 
            this.labelSearchCategories.AutoSize = true;
            this.labelSearchCategories.Location = new System.Drawing.Point(96, 37);
            this.labelSearchCategories.Name = "labelSearchCategories";
            this.labelSearchCategories.Size = new System.Drawing.Size(127, 17);
            this.labelSearchCategories.TabIndex = 24;
            this.labelSearchCategories.Text = "Search categories:";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(307, 37);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(133, 17);
            this.labelSearch.TabIndex = 23;
            this.labelSearch.Text = "Search parameters:";
            // 
            // labelDailyMenus
            // 
            this.labelDailyMenus.AutoSize = true;
            this.labelDailyMenus.Location = new System.Drawing.Point(553, 237);
            this.labelDailyMenus.Name = "labelDailyMenus";
            this.labelDailyMenus.Size = new System.Drawing.Size(89, 17);
            this.labelDailyMenus.TabIndex = 22;
            this.labelDailyMenus.Text = "Daily menus:";
            // 
            // labelRecipes
            // 
            this.labelRecipes.AutoSize = true;
            this.labelRecipes.Location = new System.Drawing.Point(326, 237);
            this.labelRecipes.Name = "labelRecipes";
            this.labelRecipes.Size = new System.Drawing.Size(63, 17);
            this.labelRecipes.TabIndex = 21;
            this.labelRecipes.Text = "Recipes:";
            // 
            // labelIngredients
            // 
            this.labelIngredients.AutoSize = true;
            this.labelIngredients.Location = new System.Drawing.Point(99, 237);
            this.labelIngredients.Name = "labelIngredients";
            this.labelIngredients.Size = new System.Drawing.Size(82, 17);
            this.labelIngredients.TabIndex = 20;
            this.labelIngredients.Text = "Ingredients:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(310, 154);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(115, 36);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listBoxDailyMenus
            // 
            this.listBoxDailyMenus.FormattingEnabled = true;
            this.listBoxDailyMenus.ItemHeight = 16;
            this.listBoxDailyMenus.Location = new System.Drawing.Point(556, 270);
            this.listBoxDailyMenus.Name = "listBoxDailyMenus";
            this.listBoxDailyMenus.Size = new System.Drawing.Size(185, 324);
            this.listBoxDailyMenus.TabIndex = 18;
            // 
            // listBoxRecipes
            // 
            this.listBoxRecipes.FormattingEnabled = true;
            this.listBoxRecipes.ItemHeight = 16;
            this.listBoxRecipes.Location = new System.Drawing.Point(329, 270);
            this.listBoxRecipes.Name = "listBoxRecipes";
            this.listBoxRecipes.Size = new System.Drawing.Size(185, 324);
            this.listBoxRecipes.TabIndex = 17;
            // 
            // listBoxIngredients
            // 
            this.listBoxIngredients.FormattingEnabled = true;
            this.listBoxIngredients.ItemHeight = 16;
            this.listBoxIngredients.Location = new System.Drawing.Point(99, 270);
            this.listBoxIngredients.Name = "listBoxIngredients";
            this.listBoxIngredients.Size = new System.Drawing.Size(185, 324);
            this.listBoxIngredients.TabIndex = 16;
            // 
            // textBoxSearchParameters
            // 
            this.textBoxSearchParameters.Location = new System.Drawing.Point(310, 72);
            this.textBoxSearchParameters.Name = "textBoxSearchParameters";
            this.textBoxSearchParameters.Size = new System.Drawing.Size(288, 22);
            this.textBoxSearchParameters.TabIndex = 15;
            // 
            // checkedListBoxSearchCategories
            // 
            this.checkedListBoxSearchCategories.FormattingEnabled = true;
            this.checkedListBoxSearchCategories.Location = new System.Drawing.Point(99, 72);
            this.checkedListBoxSearchCategories.Name = "checkedListBoxSearchCategories";
            this.checkedListBoxSearchCategories.Size = new System.Drawing.Size(152, 89);
            this.checkedListBoxSearchCategories.TabIndex = 14;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 699);
            this.Controls.Add(this.buttonShowDailyMenu);
            this.Controls.Add(this.buttonShowRecipe);
            this.Controls.Add(this.buttonShowIngredient);
            this.Controls.Add(this.labelSearchCategories);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelDailyMenus);
            this.Controls.Add(this.labelRecipes);
            this.Controls.Add(this.labelIngredients);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.listBoxDailyMenus);
            this.Controls.Add(this.listBoxRecipes);
            this.Controls.Add(this.listBoxIngredients);
            this.Controls.Add(this.textBoxSearchParameters);
            this.Controls.Add(this.checkedListBoxSearchCategories);
            this.Name = "FrmSearch";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowDailyMenu;
        private System.Windows.Forms.Button buttonShowRecipe;
        private System.Windows.Forms.Button buttonShowIngredient;
        private System.Windows.Forms.Label labelSearchCategories;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelDailyMenus;
        private System.Windows.Forms.Label labelRecipes;
        private System.Windows.Forms.Label labelIngredients;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxDailyMenus;
        private System.Windows.Forms.ListBox listBoxRecipes;
        private System.Windows.Forms.ListBox listBoxIngredients;
        private System.Windows.Forms.TextBox textBoxSearchParameters;
        private System.Windows.Forms.CheckedListBox checkedListBoxSearchCategories;
    }
}