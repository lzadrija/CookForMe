namespace CookForMeApp
{
    partial class FrmShowIngredients
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
            this.buttonIngredientDetails = new System.Windows.Forms.Button();
            this.buttonCalorieCalculator = new System.Windows.Forms.Button();
            this.labelTableOfFoods = new System.Windows.Forms.Label();
            this.treeViewIngredients = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // buttonIngredientDetails
            // 
            this.buttonIngredientDetails.Location = new System.Drawing.Point(275, 732);
            this.buttonIngredientDetails.Name = "buttonIngredientDetails";
            this.buttonIngredientDetails.Size = new System.Drawing.Size(130, 33);
            this.buttonIngredientDetails.TabIndex = 9;
            this.buttonIngredientDetails.Text = "Ingredient details";
            this.buttonIngredientDetails.UseVisualStyleBackColor = true;
            this.buttonIngredientDetails.Click += new System.EventHandler(this.buttonIngredientDetails_Click);
            // 
            // buttonCalorieCalculator
            // 
            this.buttonCalorieCalculator.Location = new System.Drawing.Point(116, 732);
            this.buttonCalorieCalculator.Name = "buttonCalorieCalculator";
            this.buttonCalorieCalculator.Size = new System.Drawing.Size(128, 33);
            this.buttonCalorieCalculator.TabIndex = 8;
            this.buttonCalorieCalculator.Text = "Calorie calculator";
            this.buttonCalorieCalculator.UseVisualStyleBackColor = true;
            this.buttonCalorieCalculator.Click += new System.EventHandler(this.buttonCalorieCalculator_Click);
            // 
            // labelTableOfFoods
            // 
            this.labelTableOfFoods.AutoSize = true;
            this.labelTableOfFoods.Location = new System.Drawing.Point(53, 33);
            this.labelTableOfFoods.Name = "labelTableOfFoods";
            this.labelTableOfFoods.Size = new System.Drawing.Size(117, 17);
            this.labelTableOfFoods.TabIndex = 7;
            this.labelTableOfFoods.Text = "Ingredients table:";
            // 
            // treeViewIngredients
            // 
            this.treeViewIngredients.Location = new System.Drawing.Point(53, 75);
            this.treeViewIngredients.Name = "treeViewIngredients";
            this.treeViewIngredients.Size = new System.Drawing.Size(421, 634);
            this.treeViewIngredients.TabIndex = 6;
            // 
            // FrmShowIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 811);
            this.Controls.Add(this.buttonIngredientDetails);
            this.Controls.Add(this.buttonCalorieCalculator);
            this.Controls.Add(this.labelTableOfFoods);
            this.Controls.Add(this.treeViewIngredients);
            this.Name = "FrmShowIngredients";
            this.Text = "View Ingredients";
            this.Load += new System.EventHandler(this.FrmShowIngredients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIngredientDetails;
        private System.Windows.Forms.Button buttonCalorieCalculator;
        private System.Windows.Forms.Label labelTableOfFoods;
        private System.Windows.Forms.TreeView treeViewIngredients;

    }
}