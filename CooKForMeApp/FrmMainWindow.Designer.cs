namespace CookForMeApp
{
    partial class FrmMainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingredientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewIngredientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewIngredientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewRecepieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecepiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyMenusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDailyMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDailyMenusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateDailyMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingredientsToolStripMenuItem,
            this.recepiesToolStripMenuItem,
            this.dailyMenusToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingredientsToolStripMenuItem
            // 
            this.ingredientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewIngredientToolStripMenuItem,
            this.viewIngredientsToolStripMenuItem});
            this.ingredientsToolStripMenuItem.Name = "ingredientsToolStripMenuItem";
            this.ingredientsToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.ingredientsToolStripMenuItem.Text = "Ingredients";
            // 
            // addNewIngredientToolStripMenuItem
            // 
            this.addNewIngredientToolStripMenuItem.Name = "addNewIngredientToolStripMenuItem";
            this.addNewIngredientToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.addNewIngredientToolStripMenuItem.Text = "Add new ingredient";
            this.addNewIngredientToolStripMenuItem.Click += new System.EventHandler(this.addNewIngredientToolStripMenuItem_Click);
            // 
            // viewIngredientsToolStripMenuItem
            // 
            this.viewIngredientsToolStripMenuItem.Name = "viewIngredientsToolStripMenuItem";
            this.viewIngredientsToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.viewIngredientsToolStripMenuItem.Text = "View ingredients";
            this.viewIngredientsToolStripMenuItem.Click += new System.EventHandler(this.viewIngredientsToolStripMenuItem_Click);
            // 
            // recepiesToolStripMenuItem
            // 
            this.recepiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewRecepieToolStripMenuItem,
            this.viewRecepiesToolStripMenuItem});
            this.recepiesToolStripMenuItem.Name = "recepiesToolStripMenuItem";
            this.recepiesToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.recepiesToolStripMenuItem.Text = "Recipes";
            // 
            // addNewRecepieToolStripMenuItem
            // 
            this.addNewRecepieToolStripMenuItem.Name = "addNewRecepieToolStripMenuItem";
            this.addNewRecepieToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.addNewRecepieToolStripMenuItem.Text = "Add new recipe";
            this.addNewRecepieToolStripMenuItem.Click += new System.EventHandler(this.addNewRecepieToolStripMenuItem_Click);
            // 
            // viewRecepiesToolStripMenuItem
            // 
            this.viewRecepiesToolStripMenuItem.Name = "viewRecepiesToolStripMenuItem";
            this.viewRecepiesToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.viewRecepiesToolStripMenuItem.Text = "View recipes";
            this.viewRecepiesToolStripMenuItem.Click += new System.EventHandler(this.viewRecepiesToolStripMenuItem_Click);
            // 
            // dailyMenusToolStripMenuItem
            // 
            this.dailyMenusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDailyMenuToolStripMenuItem,
            this.viewDailyMenusToolStripMenuItem,
            this.generateDailyMenuToolStripMenuItem});
            this.dailyMenusToolStripMenuItem.Name = "dailyMenusToolStripMenuItem";
            this.dailyMenusToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.dailyMenusToolStripMenuItem.Text = "Daily menus";
            // 
            // addNewDailyMenuToolStripMenuItem
            // 
            this.addNewDailyMenuToolStripMenuItem.Name = "addNewDailyMenuToolStripMenuItem";
            this.addNewDailyMenuToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.addNewDailyMenuToolStripMenuItem.Text = "Add new daily menu";
            this.addNewDailyMenuToolStripMenuItem.Click += new System.EventHandler(this.addNewDailyMenuToolStripMenuItem_Click);
            // 
            // viewDailyMenusToolStripMenuItem
            // 
            this.viewDailyMenusToolStripMenuItem.Name = "viewDailyMenusToolStripMenuItem";
            this.viewDailyMenusToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.viewDailyMenusToolStripMenuItem.Text = "View daily menus";
            this.viewDailyMenusToolStripMenuItem.Click += new System.EventHandler(this.viewDailyMenusToolStripMenuItem_Click);
            // 
            // generateDailyMenuToolStripMenuItem
            // 
            this.generateDailyMenuToolStripMenuItem.Name = "generateDailyMenuToolStripMenuItem";
            this.generateDailyMenuToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.generateDailyMenuToolStripMenuItem.Text = "Generate daily menu";
            this.generateDailyMenuToolStripMenuItem.Click += new System.EventHandler(this.generateDailyMenuToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(323, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 324);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 514);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMainWindow";
            this.Text = "CookForMe - Food maker assistant";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingredientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewIngredientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewIngredientsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recepiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewRecepieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRecepiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyMenusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDailyMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDailyMenusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateDailyMenuToolStripMenuItem;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

