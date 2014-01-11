namespace CookForMeApp
{
    partial class FrmAddRecipe
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
            this.buttonSaveCaption = new System.Windows.Forms.Button();
            this.labelUploadedPhotos = new System.Windows.Forms.Label();
            this.listBoxFileNames = new System.Windows.Forms.ListBox();
            this.listBoxSelectedIngredients = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSaveDosage = new System.Windows.Forms.Button();
            this.buttonRemoveSelectedIngredient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxDosage = new System.Windows.Forms.RichTextBox();
            this.buttonAddNewIngredient = new System.Windows.Forms.Button();
            this.listBoxIngredientsList = new System.Windows.Forms.ListBox();
            this.checkedListBoxMeals = new System.Windows.Forms.CheckedListBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.richTextBoxCaption = new System.Windows.Forms.RichTextBox();
            this.labelCaption = new System.Windows.Forms.Label();
            this.Ingredients = new System.Windows.Forms.Label();
            this.buttonAddRecepie = new System.Windows.Forms.Button();
            this.buttonPhotoUpload = new System.Windows.Forms.Button();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.richTextBoxPreparation = new System.Windows.Forms.RichTextBox();
            this.labelPreparation = new System.Windows.Forms.Label();
            this.buttonAddNewMeal = new System.Windows.Forms.Button();
            this.labelMeals = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSaveCaption
            // 
            this.buttonSaveCaption.Location = new System.Drawing.Point(901, 649);
            this.buttonSaveCaption.Name = "buttonSaveCaption";
            this.buttonSaveCaption.Size = new System.Drawing.Size(108, 36);
            this.buttonSaveCaption.TabIndex = 59;
            this.buttonSaveCaption.Text = "Save caption";
            this.buttonSaveCaption.UseVisualStyleBackColor = true;
            this.buttonSaveCaption.Click += new System.EventHandler(this.buttonSaveCaption_Click);
            // 
            // labelUploadedPhotos
            // 
            this.labelUploadedPhotos.AutoSize = true;
            this.labelUploadedPhotos.Location = new System.Drawing.Point(767, 441);
            this.labelUploadedPhotos.Name = "labelUploadedPhotos";
            this.labelUploadedPhotos.Size = new System.Drawing.Size(120, 17);
            this.labelUploadedPhotos.TabIndex = 58;
            this.labelUploadedPhotos.Text = "Uploaded photos:";
            // 
            // listBoxFileNames
            // 
            this.listBoxFileNames.FormattingEnabled = true;
            this.listBoxFileNames.ItemHeight = 16;
            this.listBoxFileNames.Location = new System.Drawing.Point(767, 478);
            this.listBoxFileNames.Name = "listBoxFileNames";
            this.listBoxFileNames.Size = new System.Drawing.Size(242, 132);
            this.listBoxFileNames.TabIndex = 57;
            this.listBoxFileNames.SelectedIndexChanged += new System.EventHandler(this.listBoxFileNames_SelectedIndexChanged);
            // 
            // listBoxSelectedIngredients
            // 
            this.listBoxSelectedIngredients.FormattingEnabled = true;
            this.listBoxSelectedIngredients.ItemHeight = 16;
            this.listBoxSelectedIngredients.Location = new System.Drawing.Point(221, 577);
            this.listBoxSelectedIngredients.Name = "listBoxSelectedIngredients";
            this.listBoxSelectedIngredients.Size = new System.Drawing.Size(294, 84);
            this.listBoxSelectedIngredients.TabIndex = 56;
            this.listBoxSelectedIngredients.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectedIngredients_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 815);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "*Mandatory items";
            // 
            // buttonSaveDosage
            // 
            this.buttonSaveDosage.Location = new System.Drawing.Point(304, 478);
            this.buttonSaveDosage.Name = "buttonSaveDosage";
            this.buttonSaveDosage.Size = new System.Drawing.Size(136, 38);
            this.buttonSaveDosage.TabIndex = 54;
            this.buttonSaveDosage.Text = "Save dosage";
            this.buttonSaveDosage.UseVisualStyleBackColor = true;
            this.buttonSaveDosage.Click += new System.EventHandler(this.buttonSaveDosage_Click);
            // 
            // buttonRemoveSelectedIngredient
            // 
            this.buttonRemoveSelectedIngredient.Location = new System.Drawing.Point(304, 681);
            this.buttonRemoveSelectedIngredient.Name = "buttonRemoveSelectedIngredient";
            this.buttonRemoveSelectedIngredient.Size = new System.Drawing.Size(136, 45);
            this.buttonRemoveSelectedIngredient.TabIndex = 53;
            this.buttonRemoveSelectedIngredient.Text = "Remove selected ingredient";
            this.buttonRemoveSelectedIngredient.UseVisualStyleBackColor = true;
            this.buttonRemoveSelectedIngredient.Click += new System.EventHandler(this.buttonRemoveSelectedIngredient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 545);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Selected ingredients:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(218, 356);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(154, 17);
            this.labelDescription.TabIndex = 51;
            this.labelDescription.Text = "Dosage for ingredient*:";
            // 
            // richTextBoxDosage
            // 
            this.richTextBoxDosage.Location = new System.Drawing.Point(218, 386);
            this.richTextBoxDosage.Name = "richTextBoxDosage";
            this.richTextBoxDosage.Size = new System.Drawing.Size(297, 77);
            this.richTextBoxDosage.TabIndex = 50;
            this.richTextBoxDosage.Text = "";
            // 
            // buttonAddNewIngredient
            // 
            this.buttonAddNewIngredient.Location = new System.Drawing.Point(68, 681);
            this.buttonAddNewIngredient.Name = "buttonAddNewIngredient";
            this.buttonAddNewIngredient.Size = new System.Drawing.Size(144, 45);
            this.buttonAddNewIngredient.TabIndex = 49;
            this.buttonAddNewIngredient.Text = "Add new ingredient";
            this.buttonAddNewIngredient.UseVisualStyleBackColor = true;
            this.buttonAddNewIngredient.Click += new System.EventHandler(this.buttonAddNewIngredient_Click);
            // 
            // listBoxIngredientsList
            // 
            this.listBoxIngredientsList.FormattingEnabled = true;
            this.listBoxIngredientsList.ItemHeight = 16;
            this.listBoxIngredientsList.Location = new System.Drawing.Point(68, 356);
            this.listBoxIngredientsList.Name = "listBoxIngredientsList";
            this.listBoxIngredientsList.Size = new System.Drawing.Size(144, 308);
            this.listBoxIngredientsList.TabIndex = 48;
            this.listBoxIngredientsList.SelectedIndexChanged += new System.EventHandler(this.listBoxIngredientsList_SelectedIndexChanged);
            // 
            // checkedListBoxMeals
            // 
            this.checkedListBoxMeals.FormattingEnabled = true;
            this.checkedListBoxMeals.Location = new System.Drawing.Point(71, 120);
            this.checkedListBoxMeals.Name = "checkedListBoxMeals";
            this.checkedListBoxMeals.Size = new System.Drawing.Size(369, 140);
            this.checkedListBoxMeals.TabIndex = 47;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(564, 765);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 48);
            this.buttonCancel.TabIndex = 46;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // richTextBoxCaption
            // 
            this.richTextBoxCaption.Location = new System.Drawing.Point(624, 624);
            this.richTextBoxCaption.Name = "richTextBoxCaption";
            this.richTextBoxCaption.Size = new System.Drawing.Size(263, 102);
            this.richTextBoxCaption.TabIndex = 45;
            this.richTextBoxCaption.Text = "";
            this.richTextBoxCaption.TextChanged += new System.EventHandler(this.richTextBoxCaption_TextChanged);
            // 
            // labelCaption
            // 
            this.labelCaption.AutoSize = true;
            this.labelCaption.Location = new System.Drawing.Point(621, 593);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(121, 17);
            this.labelCaption.TabIndex = 44;
            this.labelCaption.Text = "Caption for photo:";
            // 
            // Ingredients
            // 
            this.Ingredients.AutoSize = true;
            this.Ingredients.Location = new System.Drawing.Point(68, 325);
            this.Ingredients.Name = "Ingredients";
            this.Ingredients.Size = new System.Drawing.Size(87, 17);
            this.Ingredients.TabIndex = 43;
            this.Ingredients.Text = "Ingredients*:";
            // 
            // buttonAddRecepie
            // 
            this.buttonAddRecepie.Location = new System.Drawing.Point(411, 765);
            this.buttonAddRecepie.Name = "buttonAddRecepie";
            this.buttonAddRecepie.Size = new System.Drawing.Size(93, 48);
            this.buttonAddRecepie.TabIndex = 42;
            this.buttonAddRecepie.Text = "Add recipe";
            this.buttonAddRecepie.UseVisualStyleBackColor = true;
            this.buttonAddRecepie.Click += new System.EventHandler(this.buttonAddRecepie_Click);
            // 
            // buttonPhotoUpload
            // 
            this.buttonPhotoUpload.Location = new System.Drawing.Point(624, 441);
            this.buttonPhotoUpload.Name = "buttonPhotoUpload";
            this.buttonPhotoUpload.Size = new System.Drawing.Size(108, 36);
            this.buttonPhotoUpload.TabIndex = 41;
            this.buttonPhotoUpload.Text = "Upload photo";
            this.buttonPhotoUpload.UseVisualStyleBackColor = true;
            this.buttonPhotoUpload.Click += new System.EventHandler(this.buttonPhotoUpload_Click);
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Location = new System.Drawing.Point(566, 416);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(49, 17);
            this.labelPhoto.TabIndex = 40;
            this.labelPhoto.Text = "Photo:";
            // 
            // richTextBoxPreparation
            // 
            this.richTextBoxPreparation.Location = new System.Drawing.Point(569, 46);
            this.richTextBoxPreparation.Name = "richTextBoxPreparation";
            this.richTextBoxPreparation.Size = new System.Drawing.Size(440, 333);
            this.richTextBoxPreparation.TabIndex = 39;
            this.richTextBoxPreparation.Text = "";
            // 
            // labelPreparation
            // 
            this.labelPreparation.AutoSize = true;
            this.labelPreparation.Location = new System.Drawing.Point(566, 16);
            this.labelPreparation.Name = "labelPreparation";
            this.labelPreparation.Size = new System.Drawing.Size(91, 17);
            this.labelPreparation.TabIndex = 38;
            this.labelPreparation.Text = "Preparation*:";
            // 
            // buttonAddNewMeal
            // 
            this.buttonAddNewMeal.Location = new System.Drawing.Point(193, 278);
            this.buttonAddNewMeal.Name = "buttonAddNewMeal";
            this.buttonAddNewMeal.Size = new System.Drawing.Size(115, 35);
            this.buttonAddNewMeal.TabIndex = 37;
            this.buttonAddNewMeal.Text = "Add new meal";
            this.buttonAddNewMeal.UseVisualStyleBackColor = true;
            this.buttonAddNewMeal.Click += new System.EventHandler(this.buttonAddNewMeal_Click);
            // 
            // labelMeals
            // 
            this.labelMeals.AutoSize = true;
            this.labelMeals.Location = new System.Drawing.Point(68, 80);
            this.labelMeals.Name = "labelMeals";
            this.labelMeals.Size = new System.Drawing.Size(318, 17);
            this.labelMeals.TabIndex = 36;
            this.labelMeals.Text = "Choose meals for which recipe can be prepared*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 35;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(165, 16);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(275, 22);
            this.textBoxName.TabIndex = 34;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(65, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 17);
            this.labelName.TabIndex = 33;
            this.labelName.Text = "Name*:";
            // 
            // FrmAddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 849);
            this.Controls.Add(this.buttonSaveCaption);
            this.Controls.Add(this.labelUploadedPhotos);
            this.Controls.Add(this.listBoxFileNames);
            this.Controls.Add(this.listBoxSelectedIngredients);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSaveDosage);
            this.Controls.Add(this.buttonRemoveSelectedIngredient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxDosage);
            this.Controls.Add(this.buttonAddNewIngredient);
            this.Controls.Add(this.listBoxIngredientsList);
            this.Controls.Add(this.checkedListBoxMeals);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.richTextBoxCaption);
            this.Controls.Add(this.labelCaption);
            this.Controls.Add(this.Ingredients);
            this.Controls.Add(this.buttonAddRecepie);
            this.Controls.Add(this.buttonPhotoUpload);
            this.Controls.Add(this.labelPhoto);
            this.Controls.Add(this.richTextBoxPreparation);
            this.Controls.Add(this.labelPreparation);
            this.Controls.Add(this.buttonAddNewMeal);
            this.Controls.Add(this.labelMeals);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "FrmAddRecipe";
            this.Text = "Add Recipe";
            this.Load += new System.EventHandler(this.FrmAddRecipe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveCaption;
        private System.Windows.Forms.Label labelUploadedPhotos;
        private System.Windows.Forms.ListBox listBoxFileNames;
        private System.Windows.Forms.ListBox listBoxSelectedIngredients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveDosage;
        private System.Windows.Forms.Button buttonRemoveSelectedIngredient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxDosage;
        private System.Windows.Forms.Button buttonAddNewIngredient;
        private System.Windows.Forms.ListBox listBoxIngredientsList;
        private System.Windows.Forms.CheckedListBox checkedListBoxMeals;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RichTextBox richTextBoxCaption;
        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.Label Ingredients;
        private System.Windows.Forms.Button buttonAddRecepie;
        private System.Windows.Forms.Button buttonPhotoUpload;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.RichTextBox richTextBoxPreparation;
        private System.Windows.Forms.Label labelPreparation;
        private System.Windows.Forms.Button buttonAddNewMeal;
        private System.Windows.Forms.Label labelMeals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
    }
}