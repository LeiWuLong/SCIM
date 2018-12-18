namespace SCIM
{
    partial class SCIM_Dashboard
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserMnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addProdMnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.definePOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browsePOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defineSOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseSOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUser,
            this.productsMenu,
            this.viewMenu,
            this.salesOrderToolStripMenuItem,
            this.locationsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // menuUser
            // 
            this.menuUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserMnuItm,
            this.exitToolStripMenuItem});
            this.menuUser.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(42, 20);
            this.menuUser.Text = "User";
            // 
            // addUserMnuItm
            // 
            this.addUserMnuItm.ImageTransparentColor = System.Drawing.Color.Black;
            this.addUserMnuItm.Name = "addUserMnuItm";
            this.addUserMnuItm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addUserMnuItm.Size = new System.Drawing.Size(164, 22);
            this.addUserMnuItm.Text = "&Add User";
            this.addUserMnuItm.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // productsMenu
            // 
            this.productsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProdMnuItm});
            this.productsMenu.Name = "productsMenu";
            this.productsMenu.Size = new System.Drawing.Size(66, 20);
            this.productsMenu.Text = "Products";
            this.productsMenu.Click += new System.EventHandler(this.editMenu_Click);
            // 
            // addProdMnuItm
            // 
            this.addProdMnuItm.ImageTransparentColor = System.Drawing.Color.Black;
            this.addProdMnuItm.Name = "addProdMnuItm";
            this.addProdMnuItm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.addProdMnuItm.Size = new System.Drawing.Size(194, 22);
            this.addProdMnuItm.Text = "&Define Product";
            this.addProdMnuItm.Click += new System.EventHandler(this.addProdMnuItm_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.definePOToolStripMenuItem,
            this.browsePOToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.viewMenu.Size = new System.Drawing.Size(100, 20);
            this.viewMenu.Text = "Purchase Order";
            // 
            // definePOToolStripMenuItem
            // 
            this.definePOToolStripMenuItem.CheckOnClick = true;
            this.definePOToolStripMenuItem.Name = "definePOToolStripMenuItem";
            this.definePOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.definePOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.definePOToolStripMenuItem.Text = "&Define PO";
            this.definePOToolStripMenuItem.Click += new System.EventHandler(this.definePOToolStripMenuItem_Click);
            // 
            // browsePOToolStripMenuItem
            // 
            this.browsePOToolStripMenuItem.Name = "browsePOToolStripMenuItem";
            this.browsePOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.browsePOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.browsePOToolStripMenuItem.Text = "&Browse PO";
            // 
            // salesOrderToolStripMenuItem
            // 
            this.salesOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defineSOToolStripMenuItem,
            this.browseSOToolStripMenuItem});
            this.salesOrderToolStripMenuItem.Name = "salesOrderToolStripMenuItem";
            this.salesOrderToolStripMenuItem.ShortcutKeyDisplayString = "E";
            this.salesOrderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.salesOrderToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.salesOrderToolStripMenuItem.Text = "Sales Order";
            // 
            // defineSOToolStripMenuItem
            // 
            this.defineSOToolStripMenuItem.Name = "defineSOToolStripMenuItem";
            this.defineSOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.defineSOToolStripMenuItem.Text = "Define SO";
            // 
            // browseSOToolStripMenuItem
            // 
            this.browseSOToolStripMenuItem.Name = "browseSOToolStripMenuItem";
            this.browseSOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.browseSOToolStripMenuItem.Text = "Browse SO";
            // 
            // locationsToolStripMenuItem
            // 
            this.locationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLocationToolStripMenuItem});
            this.locationsToolStripMenuItem.Name = "locationsToolStripMenuItem";
            this.locationsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.locationsToolStripMenuItem.Text = "Locations";
            // 
            // addLocationToolStripMenuItem
            // 
            this.addLocationToolStripMenuItem.Name = "addLocationToolStripMenuItem";
            this.addLocationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addLocationToolStripMenuItem.Text = "Add Location";
            this.addLocationToolStripMenuItem.Click += new System.EventHandler(this.addLocationToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // SCIM_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "SCIM_Dashboard";
            this.Text = "SCIM_Dashboard";
            this.Load += new System.EventHandler(this.SCIM_Dashboard_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem menuUser;
        private System.Windows.Forms.ToolStripMenuItem addUserMnuItm;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsMenu;
        private System.Windows.Forms.ToolStripMenuItem addProdMnuItm;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem definePOToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem browsePOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defineSOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseSOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLocationToolStripMenuItem;
    }
}



