namespace FajlMentesFeladat
{
    partial class FrmMain
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemFajl = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFeladatok = new System.Windows.Forms.ToolStripMenuItem();
            this.FeladatokMenuItemElozo = new System.Windows.Forms.ToolStripMenuItem();
            this.FeladatokElozoMenuItemSzines = new System.Windows.Forms.ToolStripMenuItem();
            this.FeladatokElozoSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.FeladatokElozoMenuItemBetutipus = new System.Windows.Forms.ToolStripMenuItem();
            this.FeladatokSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.FeladatokMenuItemMai = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFajl,
            this.MenuItemFeladatok});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MenuItemFajl
            // 
            this.MenuItemFajl.Name = "MenuItemFajl";
            this.MenuItemFajl.Size = new System.Drawing.Size(37, 20);
            this.MenuItemFajl.Text = "Fajl";
            // 
            // MenuItemFeladatok
            // 
            this.MenuItemFeladatok.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FeladatokMenuItemElozo,
            this.FeladatokSeparator,
            this.FeladatokMenuItemMai});
            this.MenuItemFeladatok.Name = "MenuItemFeladatok";
            this.MenuItemFeladatok.Size = new System.Drawing.Size(70, 20);
            this.MenuItemFeladatok.Text = "Feladatok";
            // 
            // FeladatokMenuItemElozo
            // 
            this.FeladatokMenuItemElozo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FeladatokElozoMenuItemSzines,
            this.FeladatokElozoSeparator,
            this.FeladatokElozoMenuItemBetutipus});
            this.FeladatokMenuItemElozo.Name = "FeladatokMenuItemElozo";
            this.FeladatokMenuItemElozo.Size = new System.Drawing.Size(180, 22);
            this.FeladatokMenuItemElozo.Text = "Előző óra";
            // 
            // FeladatokElozoMenuItemSzines
            // 
            this.FeladatokElozoMenuItemSzines.Name = "FeladatokElozoMenuItemSzines";
            this.FeladatokElozoMenuItemSzines.Size = new System.Drawing.Size(180, 22);
            this.FeladatokElozoMenuItemSzines.Text = "Színes téglalap";
            // 
            // FeladatokElozoSeparator
            // 
            this.FeladatokElozoSeparator.Name = "FeladatokElozoSeparator";
            this.FeladatokElozoSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // FeladatokElozoMenuItemBetutipus
            // 
            this.FeladatokElozoMenuItemBetutipus.Name = "FeladatokElozoMenuItemBetutipus";
            this.FeladatokElozoMenuItemBetutipus.Size = new System.Drawing.Size(180, 22);
            this.FeladatokElozoMenuItemBetutipus.Text = "Betűtípus";
            // 
            // FeladatokSeparator
            // 
            this.FeladatokSeparator.Name = "FeladatokSeparator";
            this.FeladatokSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // FeladatokMenuItemMai
            // 
            this.FeladatokMenuItemMai.Name = "FeladatokMenuItemMai";
            this.FeladatokMenuItemMai.Size = new System.Drawing.Size(180, 22);
            this.FeladatokMenuItemMai.Text = "Mai óra";
            this.FeladatokMenuItemMai.Click += new System.EventHandler(this.FeladatokMenuItemMai_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "FrmMain";
            this.Text = "Main Form";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFajl;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFeladatok;
        private System.Windows.Forms.ToolStripMenuItem FeladatokMenuItemElozo;
        private System.Windows.Forms.ToolStripMenuItem FeladatokElozoMenuItemSzines;
        private System.Windows.Forms.ToolStripMenuItem FeladatokElozoMenuItemBetutipus;
        private System.Windows.Forms.ToolStripSeparator FeladatokElozoSeparator;
        private System.Windows.Forms.ToolStripSeparator FeladatokSeparator;
        private System.Windows.Forms.ToolStripMenuItem FeladatokMenuItemMai;
    }
}