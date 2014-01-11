namespace CookForMeApp
{
    partial class FrmShowRecipeDetails
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
            this.labelPhotoCaption = new System.Windows.Forms.Label();
            this.labelPhotosList = new System.Windows.Forms.Label();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.listBoxIngredients = new System.Windows.Forms.ListBox();
            this.listBoxFilenamesList = new System.Windows.Forms.ListBox();
            this.labelPhotos = new System.Windows.Forms.Label();
            this.richTextBoxPreparation = new System.Windows.Forms.RichTextBox();
            this.labelPreparation = new System.Windows.Forms.Label();
            this.buttonShowIngredientDetails = new System.Windows.Forms.Button();
            this.labelIngredients = new System.Windows.Forms.Label();
            this.labelRecipeName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPhotoCaption
            // 
            this.labelPhotoCaption.AutoSize = true;
            this.labelPhotoCaption.Location = new System.Drawing.Point(664, 696);
            this.labelPhotoCaption.Name = "labelPhotoCaption";
            this.labelPhotoCaption.Size = new System.Drawing.Size(95, 17);
            this.labelPhotoCaption.TabIndex = 27;
            this.labelPhotoCaption.Text = "Photo caption";
            // 
            // labelPhotosList
            // 
            this.labelPhotosList.AutoSize = true;
            this.labelPhotosList.Location = new System.Drawing.Point(661, 113);
            this.labelPhotosList.Name = "labelPhotosList";
            this.labelPhotosList.Size = new System.Drawing.Size(144, 17);
            this.labelPhotosList.TabIndex = 26;
            this.labelPhotosList.Text = "Select photo from list:";
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Location = new System.Drawing.Point(661, 386);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(49, 17);
            this.labelPhoto.TabIndex = 25;
            this.labelPhoto.Text = "Photo:";
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(664, 416);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(432, 277);
            this.pictureBoxPhoto.TabIndex = 24;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // listBoxIngredients
            // 
            this.listBoxIngredients.FormattingEnabled = true;
            this.listBoxIngredients.ItemHeight = 16;
            this.listBoxIngredients.Location = new System.Drawing.Point(165, 135);
            this.listBoxIngredients.Name = "listBoxIngredients";
            this.listBoxIngredients.Size = new System.Drawing.Size(358, 308);
            this.listBoxIngredients.TabIndex = 23;
            // 
            // listBoxFilenamesList
            // 
            this.listBoxFilenamesList.FormattingEnabled = true;
            this.listBoxFilenamesList.ItemHeight = 16;
            this.listBoxFilenamesList.Location = new System.Drawing.Point(664, 150);
            this.listBoxFilenamesList.Name = "listBoxFilenamesList";
            this.listBoxFilenamesList.Size = new System.Drawing.Size(290, 148);
            this.listBoxFilenamesList.TabIndex = 22;
            this.listBoxFilenamesList.SelectedIndexChanged += new System.EventHandler(this.listBoxFilenamesList_SelectedIndexChanged);
            // 
            // labelPhotos
            // 
            this.labelPhotos.AutoSize = true;
            this.labelPhotos.Location = new System.Drawing.Point(603, 66);
            this.labelPhotos.Name = "labelPhotos";
            this.labelPhotos.Size = new System.Drawing.Size(56, 17);
            this.labelPhotos.TabIndex = 21;
            this.labelPhotos.Text = "Photos:";
            // 
            // richTextBoxPreparation
            // 
            this.richTextBoxPreparation.Location = new System.Drawing.Point(56, 568);
            this.richTextBoxPreparation.Name = "richTextBoxPreparation";
            this.richTextBoxPreparation.Size = new System.Drawing.Size(467, 210);
            this.richTextBoxPreparation.TabIndex = 20;
            this.richTextBoxPreparation.Text = "";
            // 
            // labelPreparation
            // 
            this.labelPreparation.AutoSize = true;
            this.labelPreparation.Location = new System.Drawing.Point(57, 528);
            this.labelPreparation.Name = "labelPreparation";
            this.labelPreparation.Size = new System.Drawing.Size(86, 17);
            this.labelPreparation.TabIndex = 19;
            this.labelPreparation.Text = "Preparation:";
            // 
            // buttonShowIngredientDetails
            // 
            this.buttonShowIngredientDetails.Location = new System.Drawing.Point(264, 465);
            this.buttonShowIngredientDetails.Name = "buttonShowIngredientDetails";
            this.buttonShowIngredientDetails.Size = new System.Drawing.Size(164, 50);
            this.buttonShowIngredientDetails.TabIndex = 18;
            this.buttonShowIngredientDetails.Text = "Show ingredient details";
            this.buttonShowIngredientDetails.UseVisualStyleBackColor = true;
            this.buttonShowIngredientDetails.Click += new System.EventHandler(this.buttonShowIngredientDetails_Click);
            // 
            // labelIngredients
            // 
            this.labelIngredients.AutoSize = true;
            this.labelIngredients.Location = new System.Drawing.Point(57, 135);
            this.labelIngredients.Name = "labelIngredients";
            this.labelIngredients.Size = new System.Drawing.Size(82, 17);
            this.labelIngredients.TabIndex = 17;
            this.labelIngredients.Text = "Ingredients:";
            // 
            // labelRecipeName
            // 
            this.labelRecipeName.AutoSize = true;
            this.labelRecipeName.Location = new System.Drawing.Point(162, 66);
            this.labelRecipeName.Name = "labelRecipeName";
            this.labelRecipeName.Size = new System.Drawing.Size(89, 17);
            this.labelRecipeName.TabIndex = 16;
            this.labelRecipeName.Text = "RecipeName";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(57, 66);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 17);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Name:";
            // 
            // FrmShowRecipeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 844);
            this.Controls.Add(this.labelPhotoCaption);
            this.Controls.Add(this.labelPhotosList);
            this.Controls.Add(this.labelPhoto);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.listBoxIngredients);
            this.Controls.Add(this.listBoxFilenamesList);
            this.Controls.Add(this.labelPhotos);
            this.Controls.Add(this.richTextBoxPreparation);
            this.Controls.Add(this.labelPreparation);
            this.Controls.Add(this.buttonShowIngredientDetails);
            this.Controls.Add(this.labelIngredients);
            this.Controls.Add(this.labelRecipeName);
            this.Controls.Add(this.labelName);
            this.Name = "FrmShowRecipeDetails";
            this.Text = "View Recipe Details";
            this.Load += new System.EventHandler(this.FrmShowRecipeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPhotoCaption;
        private System.Windows.Forms.Label labelPhotosList;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.ListBox listBoxIngredients;
        private System.Windows.Forms.ListBox listBoxFilenamesList;
        private System.Windows.Forms.Label labelPhotos;
        private System.Windows.Forms.RichTextBox richTextBoxPreparation;
        private System.Windows.Forms.Label labelPreparation;
        private System.Windows.Forms.Button buttonShowIngredientDetails;
        private System.Windows.Forms.Label labelIngredients;
        private System.Windows.Forms.Label labelRecipeName;
        private System.Windows.Forms.Label labelName;
    }
}