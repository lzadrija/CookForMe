namespace CookForMeApp
{
    partial class FrmShowDailyMenus
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelMenusTable = new System.Windows.Forms.Label();
            this.buttonEditMenu = new System.Windows.Forms.Button();
            this.listBoxDailyMenus = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(280, 593);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(115, 37);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete menu";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelMenusTable
            // 
            this.labelMenusTable.AutoSize = true;
            this.labelMenusTable.Location = new System.Drawing.Point(87, 72);
            this.labelMenusTable.Name = "labelMenusTable";
            this.labelMenusTable.Size = new System.Drawing.Size(89, 17);
            this.labelMenusTable.TabIndex = 6;
            this.labelMenusTable.Text = "Daily menus:";
            // 
            // buttonEditMenu
            // 
            this.buttonEditMenu.Location = new System.Drawing.Point(132, 593);
            this.buttonEditMenu.Name = "buttonEditMenu";
            this.buttonEditMenu.Size = new System.Drawing.Size(115, 37);
            this.buttonEditMenu.TabIndex = 5;
            this.buttonEditMenu.Text = "Edit menu";
            this.buttonEditMenu.UseVisualStyleBackColor = true;
            this.buttonEditMenu.Click += new System.EventHandler(this.buttonEditMenu_Click);
            // 
            // listBoxDailyMenus
            // 
            this.listBoxDailyMenus.FormattingEnabled = true;
            this.listBoxDailyMenus.ItemHeight = 16;
            this.listBoxDailyMenus.Location = new System.Drawing.Point(87, 97);
            this.listBoxDailyMenus.Name = "listBoxDailyMenus";
            this.listBoxDailyMenus.Size = new System.Drawing.Size(361, 468);
            this.listBoxDailyMenus.TabIndex = 4;
            // 
            // FrmShowDailyMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 703);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelMenusTable);
            this.Controls.Add(this.buttonEditMenu);
            this.Controls.Add(this.listBoxDailyMenus);
            this.Name = "FrmShowDailyMenus";
            this.Text = "Daily Menus";
            this.Load += new System.EventHandler(this.FrmShowDailyMenus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelMenusTable;
        private System.Windows.Forms.Button buttonEditMenu;
        private System.Windows.Forms.ListBox listBoxDailyMenus;
    }
}