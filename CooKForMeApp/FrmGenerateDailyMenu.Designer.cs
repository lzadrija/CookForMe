namespace CookForMeApp
{
    partial class FrmGenerateDailyMenu
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
            this.buttonSaveIngredientsForMeal = new System.Windows.Forms.Button();
            this.buttonNumOfRecipes = new System.Windows.Forms.Button();
            this.buttonRemoveSelectedMeal = new System.Windows.Forms.Button();
            this.listBoxMeals = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxSelectedMeals = new System.Windows.Forms.ListBox();
            this.buttonAddIngredient = new System.Windows.Forms.Button();
            this.textBoxNumOfRecipesPerMeal = new System.Windows.Forms.TextBox();
            this.labelNRecipesPerMeal = new System.Windows.Forms.Label();
            this.checkedListBoxIngredients = new System.Windows.Forms.CheckedListBox();
            this.richTextBoxMenuName = new System.Windows.Forms.RichTextBox();
            this.labelMandatory = new System.Windows.Forms.Label();
            this.buttonDiscard = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonShowRecipe = new System.Windows.Forms.Button();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelSelect = new System.Windows.Forms.Label();
            this.buttonSaveMenu = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDailyMenu = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.treeViewDailyMenuRecipes = new System.Windows.Forms.TreeView();
            this.labelIngredients = new System.Windows.Forms.Label();
            this.labelSelectMeals = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSaveIngredientsForMeal
            // 
            this.buttonSaveIngredientsForMeal.Location = new System.Drawing.Point(964, 368);
            this.buttonSaveIngredientsForMeal.Name = "buttonSaveIngredientsForMeal";
            this.buttonSaveIngredientsForMeal.Size = new System.Drawing.Size(137, 48);
            this.buttonSaveIngredientsForMeal.TabIndex = 59;
            this.buttonSaveIngredientsForMeal.Text = "Save ingredients for meal";
            this.buttonSaveIngredientsForMeal.UseVisualStyleBackColor = true;
            this.buttonSaveIngredientsForMeal.Click += new System.EventHandler(this.buttonSaveIngredientsForMeal_Click);
            // 
            // buttonNumOfRecipes
            // 
            this.buttonNumOfRecipes.Location = new System.Drawing.Point(680, 325);
            this.buttonNumOfRecipes.Name = "buttonNumOfRecipes";
            this.buttonNumOfRecipes.Size = new System.Drawing.Size(89, 24);
            this.buttonNumOfRecipes.TabIndex = 58;
            this.buttonNumOfRecipes.Text = "Save";
            this.buttonNumOfRecipes.UseVisualStyleBackColor = true;
            this.buttonNumOfRecipes.Click += new System.EventHandler(this.buttonNumOfRecipes_Click);
            // 
            // buttonRemoveSelectedMeal
            // 
            this.buttonRemoveSelectedMeal.Location = new System.Drawing.Point(404, 368);
            this.buttonRemoveSelectedMeal.Name = "buttonRemoveSelectedMeal";
            this.buttonRemoveSelectedMeal.Size = new System.Drawing.Size(164, 34);
            this.buttonRemoveSelectedMeal.TabIndex = 57;
            this.buttonRemoveSelectedMeal.Text = "Remove selected meal";
            this.buttonRemoveSelectedMeal.UseVisualStyleBackColor = true;
            this.buttonRemoveSelectedMeal.Click += new System.EventHandler(this.buttonRemoveSelectedMeal_Click);
            // 
            // listBoxMeals
            // 
            this.listBoxMeals.FormattingEnabled = true;
            this.listBoxMeals.ItemHeight = 16;
            this.listBoxMeals.Location = new System.Drawing.Point(46, 82);
            this.listBoxMeals.Name = "listBoxMeals";
            this.listBoxMeals.Size = new System.Drawing.Size(305, 324);
            this.listBoxMeals.TabIndex = 56;
            this.listBoxMeals.SelectedIndexChanged += new System.EventHandler(this.listBoxMeals_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Selected meals for daily menu:";
            // 
            // listBoxSelectedMeals
            // 
            this.listBoxSelectedMeals.FormattingEnabled = true;
            this.listBoxSelectedMeals.ItemHeight = 16;
            this.listBoxSelectedMeals.Location = new System.Drawing.Point(404, 82);
            this.listBoxSelectedMeals.Name = "listBoxSelectedMeals";
            this.listBoxSelectedMeals.Size = new System.Drawing.Size(365, 228);
            this.listBoxSelectedMeals.TabIndex = 54;
            this.listBoxSelectedMeals.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectedMeals_SelectedIndexChanged);
            // 
            // buttonAddIngredient
            // 
            this.buttonAddIngredient.Location = new System.Drawing.Point(814, 368);
            this.buttonAddIngredient.Name = "buttonAddIngredient";
            this.buttonAddIngredient.Size = new System.Drawing.Size(137, 48);
            this.buttonAddIngredient.TabIndex = 53;
            this.buttonAddIngredient.Text = "Add new ingredient";
            this.buttonAddIngredient.UseVisualStyleBackColor = true;
            this.buttonAddIngredient.Click += new System.EventHandler(this.buttonAddIngredient_Click);
            // 
            // textBoxNumOfRecipesPerMeal
            // 
            this.textBoxNumOfRecipesPerMeal.Location = new System.Drawing.Point(566, 327);
            this.textBoxNumOfRecipesPerMeal.Name = "textBoxNumOfRecipesPerMeal";
            this.textBoxNumOfRecipesPerMeal.Size = new System.Drawing.Size(88, 22);
            this.textBoxNumOfRecipesPerMeal.TabIndex = 52;
            // 
            // labelNRecipesPerMeal
            // 
            this.labelNRecipesPerMeal.AutoSize = true;
            this.labelNRecipesPerMeal.Location = new System.Drawing.Point(401, 327);
            this.labelNRecipesPerMeal.Name = "labelNRecipesPerMeal";
            this.labelNRecipesPerMeal.Size = new System.Drawing.Size(132, 17);
            this.labelNRecipesPerMeal.TabIndex = 51;
            this.labelNRecipesPerMeal.Text = "Number of recipes :";
            // 
            // checkedListBoxIngredients
            // 
            this.checkedListBoxIngredients.FormattingEnabled = true;
            this.checkedListBoxIngredients.Location = new System.Drawing.Point(814, 82);
            this.checkedListBoxIngredients.Name = "checkedListBoxIngredients";
            this.checkedListBoxIngredients.Size = new System.Drawing.Size(287, 276);
            this.checkedListBoxIngredients.TabIndex = 50;
            // 
            // richTextBoxMenuName
            // 
            this.richTextBoxMenuName.Location = new System.Drawing.Point(394, 539);
            this.richTextBoxMenuName.Name = "richTextBoxMenuName";
            this.richTextBoxMenuName.Size = new System.Drawing.Size(357, 27);
            this.richTextBoxMenuName.TabIndex = 49;
            this.richTextBoxMenuName.Text = "";
            // 
            // labelMandatory
            // 
            this.labelMandatory.AutoSize = true;
            this.labelMandatory.Location = new System.Drawing.Point(63, 831);
            this.labelMandatory.Name = "labelMandatory";
            this.labelMandatory.Size = new System.Drawing.Size(121, 17);
            this.labelMandatory.TabIndex = 48;
            this.labelMandatory.Text = "* Mandatory items";
            // 
            // buttonDiscard
            // 
            this.buttonDiscard.Location = new System.Drawing.Point(566, 792);
            this.buttonDiscard.Name = "buttonDiscard";
            this.buttonDiscard.Size = new System.Drawing.Size(96, 38);
            this.buttonDiscard.TabIndex = 47;
            this.buttonDiscard.Text = "Discard";
            this.buttonDiscard.UseVisualStyleBackColor = true;
            this.buttonDiscard.Click += new System.EventHandler(this.buttonDiscard_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(440, 792);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(96, 38);
            this.buttonSave.TabIndex = 46;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonShowRecipe
            // 
            this.buttonShowRecipe.Location = new System.Drawing.Point(46, 747);
            this.buttonShowRecipe.Name = "buttonShowRecipe";
            this.buttonShowRecipe.Size = new System.Drawing.Size(96, 38);
            this.buttonShowRecipe.TabIndex = 45;
            this.buttonShowRecipe.Text = "Show recipe";
            this.buttonShowRecipe.UseVisualStyleBackColor = true;
            this.buttonShowRecipe.Click += new System.EventHandler(this.buttonShowRecipe_Click);
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(394, 614);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(357, 127);
            this.richTextBoxDescription.TabIndex = 44;
            this.richTextBoxDescription.Text = "";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(391, 594);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(83, 17);
            this.labelDescription.TabIndex = 43;
            this.labelDescription.Text = "Description:";
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Location = new System.Drawing.Point(22, -3);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(272, 17);
            this.labelSelect.TabIndex = 42;
            this.labelSelect.Text = "Select ingredients for each selected meal:";
            // 
            // buttonSaveMenu
            // 
            this.buttonSaveMenu.Location = new System.Drawing.Point(169, 747);
            this.buttonSaveMenu.Name = "buttonSaveMenu";
            this.buttonSaveMenu.Size = new System.Drawing.Size(96, 38);
            this.buttonSaveMenu.TabIndex = 41;
            this.buttonSaveMenu.Text = "Save menu";
            this.buttonSaveMenu.UseVisualStyleBackColor = true;
            this.buttonSaveMenu.Click += new System.EventHandler(this.buttonSaveMenu_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(391, 510);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 17);
            this.labelName.TabIndex = 40;
            this.labelName.Text = "Name*:";
            // 
            // labelDailyMenu
            // 
            this.labelDailyMenu.AutoSize = true;
            this.labelDailyMenu.Location = new System.Drawing.Point(43, 478);
            this.labelDailyMenu.Name = "labelDailyMenu";
            this.labelDailyMenu.Size = new System.Drawing.Size(184, 17);
            this.labelDailyMenu.TabIndex = 39;
            this.labelDailyMenu.Text = "Daily menu (meal, recipes): ";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(512, 423);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(150, 59);
            this.buttonGenerate.TabIndex = 38;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // treeViewDailyMenuRecipes
            // 
            this.treeViewDailyMenuRecipes.Location = new System.Drawing.Point(46, 510);
            this.treeViewDailyMenuRecipes.Name = "treeViewDailyMenuRecipes";
            this.treeViewDailyMenuRecipes.Size = new System.Drawing.Size(305, 231);
            this.treeViewDailyMenuRecipes.TabIndex = 37;
            // 
            // labelIngredients
            // 
            this.labelIngredients.AutoSize = true;
            this.labelIngredients.Location = new System.Drawing.Point(811, 41);
            this.labelIngredients.Name = "labelIngredients";
            this.labelIngredients.Size = new System.Drawing.Size(121, 17);
            this.labelIngredients.TabIndex = 36;
            this.labelIngredients.Text = "Select ingredients";
            // 
            // labelSelectMeals
            // 
            this.labelSelectMeals.AutoSize = true;
            this.labelSelectMeals.Location = new System.Drawing.Point(45, 41);
            this.labelSelectMeals.Name = "labelSelectMeals";
            this.labelSelectMeals.Size = new System.Drawing.Size(97, 17);
            this.labelSelectMeals.TabIndex = 35;
            this.labelSelectMeals.Text = "Select meals*:";
            // 
            // FrmGenerateDailyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 880);
            this.Controls.Add(this.buttonSaveIngredientsForMeal);
            this.Controls.Add(this.buttonNumOfRecipes);
            this.Controls.Add(this.buttonRemoveSelectedMeal);
            this.Controls.Add(this.listBoxMeals);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSelectedMeals);
            this.Controls.Add(this.buttonAddIngredient);
            this.Controls.Add(this.textBoxNumOfRecipesPerMeal);
            this.Controls.Add(this.labelNRecipesPerMeal);
            this.Controls.Add(this.checkedListBoxIngredients);
            this.Controls.Add(this.richTextBoxMenuName);
            this.Controls.Add(this.labelMandatory);
            this.Controls.Add(this.buttonDiscard);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonShowRecipe);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.buttonSaveMenu);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelDailyMenu);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.treeViewDailyMenuRecipes);
            this.Controls.Add(this.labelIngredients);
            this.Controls.Add(this.labelSelectMeals);
            this.Name = "FrmGenerateDailyMenu";
            this.Text = "Generate Daily Menu";
            this.Load += new System.EventHandler(this.FrmGenerateDailyMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveIngredientsForMeal;
        private System.Windows.Forms.Button buttonNumOfRecipes;
        private System.Windows.Forms.Button buttonRemoveSelectedMeal;
        private System.Windows.Forms.ListBox listBoxMeals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxSelectedMeals;
        private System.Windows.Forms.Button buttonAddIngredient;
        private System.Windows.Forms.TextBox textBoxNumOfRecipesPerMeal;
        private System.Windows.Forms.Label labelNRecipesPerMeal;
        private System.Windows.Forms.CheckedListBox checkedListBoxIngredients;
        private System.Windows.Forms.RichTextBox richTextBoxMenuName;
        private System.Windows.Forms.Label labelMandatory;
        private System.Windows.Forms.Button buttonDiscard;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonShowRecipe;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.Button buttonSaveMenu;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDailyMenu;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TreeView treeViewDailyMenuRecipes;
        private System.Windows.Forms.Label labelIngredients;
        private System.Windows.Forms.Label labelSelectMeals;
    }
}