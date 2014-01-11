namespace CookForMeApp
{
    partial class FrmCalorieCalculator
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
            this.labelEnergyValueNumber = new System.Windows.Forms.Label();
            this.labelDefaultEnergyValue = new System.Windows.Forms.Label();
            this.textBoxAmountNumber = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelIngredientName = new System.Windows.Forms.Label();
            this.labelIngredient = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEnergyValueNumber
            // 
            this.labelEnergyValueNumber.AutoSize = true;
            this.labelEnergyValueNumber.Location = new System.Drawing.Point(224, 114);
            this.labelEnergyValueNumber.Name = "labelEnergyValueNumber";
            this.labelEnergyValueNumber.Size = new System.Drawing.Size(46, 17);
            this.labelEnergyValueNumber.TabIndex = 13;
            this.labelEnergyValueNumber.Text = "label1";
            // 
            // labelDefaultEnergyValue
            // 
            this.labelDefaultEnergyValue.AutoSize = true;
            this.labelDefaultEnergyValue.Location = new System.Drawing.Point(65, 114);
            this.labelDefaultEnergyValue.Name = "labelDefaultEnergyValue";
            this.labelDefaultEnergyValue.Size = new System.Drawing.Size(97, 17);
            this.labelDefaultEnergyValue.TabIndex = 12;
            this.labelDefaultEnergyValue.Text = "Energy Value:";
            // 
            // textBoxAmountNumber
            // 
            this.textBoxAmountNumber.Location = new System.Drawing.Point(227, 155);
            this.textBoxAmountNumber.Name = "textBoxAmountNumber";
            this.textBoxAmountNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxAmountNumber.TabIndex = 11;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(65, 160);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(82, 17);
            this.labelAmount.TabIndex = 10;
            this.labelAmount.Text = "Amount (g):";
            // 
            // labelIngredientName
            // 
            this.labelIngredientName.AutoSize = true;
            this.labelIngredientName.Location = new System.Drawing.Point(224, 76);
            this.labelIngredientName.Name = "labelIngredientName";
            this.labelIngredientName.Size = new System.Drawing.Size(46, 17);
            this.labelIngredientName.TabIndex = 9;
            this.labelIngredientName.Text = "label2";
            // 
            // labelIngredient
            // 
            this.labelIngredient.AutoSize = true;
            this.labelIngredient.Location = new System.Drawing.Point(65, 76);
            this.labelIngredient.Name = "labelIngredient";
            this.labelIngredient.Size = new System.Drawing.Size(75, 17);
            this.labelIngredient.TabIndex = 8;
            this.labelIngredient.Text = "Ingredient:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(143, 251);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 7;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // FrmCalorieCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 349);
            this.Controls.Add(this.labelEnergyValueNumber);
            this.Controls.Add(this.labelDefaultEnergyValue);
            this.Controls.Add(this.textBoxAmountNumber);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelIngredientName);
            this.Controls.Add(this.labelIngredient);
            this.Controls.Add(this.buttonCalculate);
            this.Name = "FrmCalorieCalculator";
            this.Text = "CalorieCalculator";
            this.Load += new System.EventHandler(this.FrmCalorieCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnergyValueNumber;
        private System.Windows.Forms.Label labelDefaultEnergyValue;
        private System.Windows.Forms.TextBox textBoxAmountNumber;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelIngredientName;
        private System.Windows.Forms.Label labelIngredient;
        private System.Windows.Forms.Button buttonCalculate;
    }
}