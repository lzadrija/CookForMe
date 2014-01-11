namespace CookForMeApp
{
    partial class FrmShowIngredientDetails
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
            this.tableNV = new System.Windows.Forms.TableLayoutPanel();
            this.labelFatValue = new System.Windows.Forms.Label();
            this.labelProteinValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEnergy = new System.Windows.Forms.Label();
            this.labelEnergyValue = new System.Windows.Forms.Label();
            this.labelCategoryText = new System.Windows.Forms.Label();
            this.labelNameText = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelNV = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelPhotoCaption = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tableNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableNV
            // 
            this.tableNV.ColumnCount = 3;
            this.tableNV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.28261F));
            this.tableNV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.71739F));
            this.tableNV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableNV.Controls.Add(this.labelFatValue, 2, 1);
            this.tableNV.Controls.Add(this.labelProteinValue, 1, 1);
            this.tableNV.Controls.Add(this.label3, 2, 0);
            this.tableNV.Controls.Add(this.label2, 1, 0);
            this.tableNV.Controls.Add(this.labelEnergy, 0, 0);
            this.tableNV.Controls.Add(this.labelEnergyValue, 0, 1);
            this.tableNV.Location = new System.Drawing.Point(239, 267);
            this.tableNV.Name = "tableNV";
            this.tableNV.RowCount = 2;
            this.tableNV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.75F));
            this.tableNV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.25F));
            this.tableNV.Size = new System.Drawing.Size(296, 64);
            this.tableNV.TabIndex = 21;
            // 
            // labelFatValue
            // 
            this.labelFatValue.AutoSize = true;
            this.labelFatValue.Location = new System.Drawing.Point(210, 28);
            this.labelFatValue.Name = "labelFatValue";
            this.labelFatValue.Size = new System.Drawing.Size(64, 17);
            this.labelFatValue.TabIndex = 5;
            this.labelFatValue.Text = "FatValue";
            // 
            // labelProteinValue
            // 
            this.labelProteinValue.AutoSize = true;
            this.labelProteinValue.Location = new System.Drawing.Point(101, 28);
            this.labelProteinValue.Name = "labelProteinValue";
            this.labelProteinValue.Size = new System.Drawing.Size(89, 17);
            this.labelProteinValue.TabIndex = 4;
            this.labelProteinValue.Text = "ProteinValue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Protein";
            // 
            // labelEnergy
            // 
            this.labelEnergy.AutoSize = true;
            this.labelEnergy.Location = new System.Drawing.Point(3, 0);
            this.labelEnergy.Name = "labelEnergy";
            this.labelEnergy.Size = new System.Drawing.Size(92, 17);
            this.labelEnergy.TabIndex = 0;
            this.labelEnergy.Text = "Energy (kcal)";
            // 
            // labelEnergyValue
            // 
            this.labelEnergyValue.AutoSize = true;
            this.labelEnergyValue.Location = new System.Drawing.Point(3, 28);
            this.labelEnergyValue.Name = "labelEnergyValue";
            this.labelEnergyValue.Size = new System.Drawing.Size(89, 17);
            this.labelEnergyValue.TabIndex = 3;
            this.labelEnergyValue.Text = "EnergyValue";
            // 
            // labelCategoryText
            // 
            this.labelCategoryText.AutoSize = true;
            this.labelCategoryText.Location = new System.Drawing.Point(236, 182);
            this.labelCategoryText.Name = "labelCategoryText";
            this.labelCategoryText.Size = new System.Drawing.Size(130, 17);
            this.labelCategoryText.TabIndex = 20;
            this.labelCategoryText.Text = "Ingredient category";
            // 
            // labelNameText
            // 
            this.labelNameText.AutoSize = true;
            this.labelNameText.Location = new System.Drawing.Point(236, 119);
            this.labelNameText.Name = "labelNameText";
            this.labelNameText.Size = new System.Drawing.Size(110, 17);
            this.labelNameText.TabIndex = 19;
            this.labelNameText.Text = "Ingredient name";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(120, 368);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(83, 17);
            this.labelDescription.TabIndex = 18;
            this.labelDescription.Text = "Description:";
            // 
            // labelNV
            // 
            this.labelNV.AutoSize = true;
            this.labelNV.Location = new System.Drawing.Point(120, 235);
            this.labelNV.Name = "labelNV";
            this.labelNV.Size = new System.Drawing.Size(110, 17);
            this.labelNV.TabIndex = 17;
            this.labelNV.Text = "Nutrition values:";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(120, 182);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(69, 17);
            this.labelCategory.TabIndex = 16;
            this.labelCategory.Text = "Category:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(120, 119);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 17);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Name:";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(239, 368);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(296, 137);
            this.richTextBoxDescription.TabIndex = 24;
            this.richTextBoxDescription.Text = "";
            // 
            // labelPhotoCaption
            // 
            this.labelPhotoCaption.AutoSize = true;
            this.labelPhotoCaption.Location = new System.Drawing.Point(120, 708);
            this.labelPhotoCaption.Name = "labelPhotoCaption";
            this.labelPhotoCaption.Size = new System.Drawing.Size(95, 17);
            this.labelPhotoCaption.TabIndex = 23;
            this.labelPhotoCaption.Text = "Photo caption";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(123, 531);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(296, 174);
            this.pictureBox.TabIndex = 22;
            this.pictureBox.TabStop = false;
            // 
            // FrmShowIngredientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 844);
            this.Controls.Add(this.tableNV);
            this.Controls.Add(this.labelCategoryText);
            this.Controls.Add(this.labelNameText);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelNV);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelPhotoCaption);
            this.Controls.Add(this.pictureBox);
            this.Name = "FrmShowIngredientDetails";
            this.Text = "Ingredient details";
            this.Load += new System.EventHandler(this.FrmShowIngredientDetails_Load);
            this.tableNV.ResumeLayout(false);
            this.tableNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableNV;
        private System.Windows.Forms.Label labelFatValue;
        private System.Windows.Forms.Label labelProteinValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEnergy;
        private System.Windows.Forms.Label labelEnergyValue;
        private System.Windows.Forms.Label labelCategoryText;
        private System.Windows.Forms.Label labelNameText;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelNV;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelPhotoCaption;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}