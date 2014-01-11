namespace CookForMeApp
{
    partial class FrmAddIngredient
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
            this.labelPictureFileName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAddNewICategory = new System.Windows.Forms.Label();
            this.textBoxAddNewICategory = new System.Windows.Forms.TextBox();
            this.buttonPhoto = new System.Windows.Forms.Button();
            this.richTextBoxCaption = new System.Windows.Forms.RichTextBox();
            this.listBoxIngredientCategory = new System.Windows.Forms.ListBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxNVEnergy = new System.Windows.Forms.TextBox();
            this.textBoxNVfat = new System.Windows.Forms.TextBox();
            this.textBoxNVprotein = new System.Windows.Forms.TextBox();
            this.textBoxNVamount = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelCaption = new System.Windows.Forms.Label();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelEnergy = new System.Windows.Forms.Label();
            this.labelFat = new System.Windows.Forms.Label();
            this.labelProteins = new System.Windows.Forms.Label();
            this.labelStdAmount = new System.Windows.Forms.Label();
            this.labelNutritionalValues = new System.Windows.Forms.Label();
            this.labelIngredientCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddIngredient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPictureFileName
            // 
            this.labelPictureFileName.AutoSize = true;
            this.labelPictureFileName.Location = new System.Drawing.Point(324, 590);
            this.labelPictureFileName.Name = "labelPictureFileName";
            this.labelPictureFileName.Size = new System.Drawing.Size(111, 17);
            this.labelPictureFileName.TabIndex = 55;
            this.labelPictureFileName.Text = "PictureFileName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 819);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "*Mandatory fields";
            // 
            // labelAddNewICategory
            // 
            this.labelAddNewICategory.AutoSize = true;
            this.labelAddNewICategory.Location = new System.Drawing.Point(350, 105);
            this.labelAddNewICategory.Name = "labelAddNewICategory";
            this.labelAddNewICategory.Size = new System.Drawing.Size(118, 17);
            this.labelAddNewICategory.TabIndex = 53;
            this.labelAddNewICategory.Text = "Custom category:";
            // 
            // textBoxAddNewICategory
            // 
            this.textBoxAddNewICategory.Location = new System.Drawing.Point(353, 132);
            this.textBoxAddNewICategory.Name = "textBoxAddNewICategory";
            this.textBoxAddNewICategory.Size = new System.Drawing.Size(185, 22);
            this.textBoxAddNewICategory.TabIndex = 52;
            this.textBoxAddNewICategory.TextChanged += new System.EventHandler(this.textBoxAddNewICategory_TextChanged);
            // 
            // buttonPhoto
            // 
            this.buttonPhoto.Location = new System.Drawing.Point(196, 584);
            this.buttonPhoto.Name = "buttonPhoto";
            this.buttonPhoto.Size = new System.Drawing.Size(102, 23);
            this.buttonPhoto.TabIndex = 51;
            this.buttonPhoto.Text = "Upload photo";
            this.buttonPhoto.UseVisualStyleBackColor = true;
            this.buttonPhoto.Click += new System.EventHandler(this.buttonPhoto_Click);
            // 
            // richTextBoxCaption
            // 
            this.richTextBoxCaption.Location = new System.Drawing.Point(198, 664);
            this.richTextBoxCaption.Name = "richTextBoxCaption";
            this.richTextBoxCaption.Size = new System.Drawing.Size(251, 63);
            this.richTextBoxCaption.TabIndex = 50;
            this.richTextBoxCaption.Text = "";
            // 
            // listBoxIngredientCategory
            // 
            this.listBoxIngredientCategory.FormattingEnabled = true;
            this.listBoxIngredientCategory.ItemHeight = 16;
            this.listBoxIngredientCategory.Location = new System.Drawing.Point(198, 102);
            this.listBoxIngredientCategory.Name = "listBoxIngredientCategory";
            this.listBoxIngredientCategory.Size = new System.Drawing.Size(120, 84);
            this.listBoxIngredientCategory.TabIndex = 49;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(198, 459);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(283, 96);
            this.richTextBoxDescription.TabIndex = 48;
            this.richTextBoxDescription.Text = "";
            // 
            // textBoxNVEnergy
            // 
            this.textBoxNVEnergy.Location = new System.Drawing.Point(338, 373);
            this.textBoxNVEnergy.Name = "textBoxNVEnergy";
            this.textBoxNVEnergy.Size = new System.Drawing.Size(100, 22);
            this.textBoxNVEnergy.TabIndex = 47;
            // 
            // textBoxNVfat
            // 
            this.textBoxNVfat.Location = new System.Drawing.Point(338, 331);
            this.textBoxNVfat.Name = "textBoxNVfat";
            this.textBoxNVfat.Size = new System.Drawing.Size(100, 22);
            this.textBoxNVfat.TabIndex = 46;
            // 
            // textBoxNVprotein
            // 
            this.textBoxNVprotein.Location = new System.Drawing.Point(338, 292);
            this.textBoxNVprotein.Name = "textBoxNVprotein";
            this.textBoxNVprotein.Size = new System.Drawing.Size(100, 22);
            this.textBoxNVprotein.TabIndex = 45;
            // 
            // textBoxNVamount
            // 
            this.textBoxNVamount.Location = new System.Drawing.Point(338, 248);
            this.textBoxNVamount.Name = "textBoxNVamount";
            this.textBoxNVamount.Size = new System.Drawing.Size(100, 22);
            this.textBoxNVamount.TabIndex = 44;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(198, 23);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(120, 22);
            this.textBoxName.TabIndex = 43;
            // 
            // labelCaption
            // 
            this.labelCaption.AutoSize = true;
            this.labelCaption.Location = new System.Drawing.Point(197, 644);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(56, 17);
            this.labelCaption.TabIndex = 42;
            this.labelCaption.Text = "Caption";
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Location = new System.Drawing.Point(63, 562);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(45, 17);
            this.labelPhoto.TabIndex = 41;
            this.labelPhoto.Text = "Photo";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(62, 430);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(84, 17);
            this.labelDescription.TabIndex = 40;
            this.labelDescription.Text = "Description*";
            // 
            // labelEnergy
            // 
            this.labelEnergy.AutoSize = true;
            this.labelEnergy.Location = new System.Drawing.Point(197, 373);
            this.labelEnergy.Name = "labelEnergy";
            this.labelEnergy.Size = new System.Drawing.Size(92, 17);
            this.labelEnergy.TabIndex = 39;
            this.labelEnergy.Text = "Energy (kcal)";
            // 
            // labelFat
            // 
            this.labelFat.AutoSize = true;
            this.labelFat.Location = new System.Drawing.Point(197, 334);
            this.labelFat.Name = "labelFat";
            this.labelFat.Size = new System.Drawing.Size(79, 17);
            this.labelFat.TabIndex = 38;
            this.labelFat.Text = "Fat amount";
            // 
            // labelProteins
            // 
            this.labelProteins.AutoSize = true;
            this.labelProteins.Location = new System.Drawing.Point(197, 292);
            this.labelProteins.Name = "labelProteins";
            this.labelProteins.Size = new System.Drawing.Size(111, 17);
            this.labelProteins.TabIndex = 37;
            this.labelProteins.Text = "Proteins amount";
            // 
            // labelStdAmount
            // 
            this.labelStdAmount.AutoSize = true;
            this.labelStdAmount.Location = new System.Drawing.Point(197, 253);
            this.labelStdAmount.Name = "labelStdAmount";
            this.labelStdAmount.Size = new System.Drawing.Size(78, 17);
            this.labelStdAmount.TabIndex = 36;
            this.labelStdAmount.Text = "Amount (g)";
            // 
            // labelNutritionalValues
            // 
            this.labelNutritionalValues.AutoSize = true;
            this.labelNutritionalValues.Location = new System.Drawing.Point(62, 204);
            this.labelNutritionalValues.Name = "labelNutritionalValues";
            this.labelNutritionalValues.Size = new System.Drawing.Size(122, 17);
            this.labelNutritionalValues.TabIndex = 35;
            this.labelNutritionalValues.Text = "Nutritional values*";
            // 
            // labelIngredientCategory
            // 
            this.labelIngredientCategory.AutoSize = true;
            this.labelIngredientCategory.Location = new System.Drawing.Point(63, 82);
            this.labelIngredientCategory.Name = "labelIngredientCategory";
            this.labelIngredientCategory.Size = new System.Drawing.Size(135, 17);
            this.labelIngredientCategory.TabIndex = 34;
            this.labelIngredientCategory.Text = "Ingredient category*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Name*";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(289, 748);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 42);
            this.buttonCancel.TabIndex = 32;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddIngredient
            // 
            this.buttonAddIngredient.Location = new System.Drawing.Point(158, 748);
            this.buttonAddIngredient.Name = "buttonAddIngredient";
            this.buttonAddIngredient.Size = new System.Drawing.Size(95, 42);
            this.buttonAddIngredient.TabIndex = 31;
            this.buttonAddIngredient.Text = "Add ingredient";
            this.buttonAddIngredient.UseVisualStyleBackColor = true;
            this.buttonAddIngredient.Click += new System.EventHandler(this.buttonAddIngredient_Click);
            // 
            // FrmAddIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 859);
            this.Controls.Add(this.labelPictureFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAddNewICategory);
            this.Controls.Add(this.textBoxAddNewICategory);
            this.Controls.Add(this.buttonPhoto);
            this.Controls.Add(this.richTextBoxCaption);
            this.Controls.Add(this.listBoxIngredientCategory);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.textBoxNVEnergy);
            this.Controls.Add(this.textBoxNVfat);
            this.Controls.Add(this.textBoxNVprotein);
            this.Controls.Add(this.textBoxNVamount);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelCaption);
            this.Controls.Add(this.labelPhoto);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelEnergy);
            this.Controls.Add(this.labelFat);
            this.Controls.Add(this.labelProteins);
            this.Controls.Add(this.labelStdAmount);
            this.Controls.Add(this.labelNutritionalValues);
            this.Controls.Add(this.labelIngredientCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddIngredient);
            this.Name = "FrmAddIngredient";
            this.Text = "FrmAddIngredient";
            this.Load += new System.EventHandler(this.FrmAddIngredient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPictureFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAddNewICategory;
        private System.Windows.Forms.TextBox textBoxAddNewICategory;
        private System.Windows.Forms.Button buttonPhoto;
        private System.Windows.Forms.RichTextBox richTextBoxCaption;
        private System.Windows.Forms.ListBox listBoxIngredientCategory;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.TextBox textBoxNVEnergy;
        private System.Windows.Forms.TextBox textBoxNVfat;
        private System.Windows.Forms.TextBox textBoxNVprotein;
        private System.Windows.Forms.TextBox textBoxNVamount;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelEnergy;
        private System.Windows.Forms.Label labelFat;
        private System.Windows.Forms.Label labelProteins;
        private System.Windows.Forms.Label labelStdAmount;
        private System.Windows.Forms.Label labelNutritionalValues;
        private System.Windows.Forms.Label labelIngredientCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddIngredient;
    }
}