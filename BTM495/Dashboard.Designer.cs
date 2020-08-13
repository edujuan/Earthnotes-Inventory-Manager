namespace BTM495
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.signOutButton = new System.Windows.Forms.Button();
            this.missingButton = new System.Windows.Forms.Button();
            this.notificationsButton = new System.Windows.Forms.Button();
            this.SubMenuPanel = new System.Windows.Forms.Panel();
            this.orderDemoButton = new System.Windows.Forms.Button();
            this.addProductsButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.SubMenuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.Pink;
            this.panelSideMenu.Controls.Add(this.signOutButton);
            this.panelSideMenu.Controls.Add(this.missingButton);
            this.panelSideMenu.Controls.Add(this.notificationsButton);
            this.panelSideMenu.Controls.Add(this.SubMenuPanel);
            this.panelSideMenu.Controls.Add(this.inventoryButton);
            this.panelSideMenu.Controls.Add(this.logoPanel);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 570);
            this.panelSideMenu.TabIndex = 1;
            // 
            // signOutButton
            // 
            this.signOutButton.BackColor = System.Drawing.Color.Pink;
            this.signOutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.signOutButton.FlatAppearance.BorderSize = 0;
            this.signOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOutButton.ForeColor = System.Drawing.Color.White;
            this.signOutButton.Image = global::BTM495.Properties.Resources.SignOutIconSmall;
            this.signOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signOutButton.Location = new System.Drawing.Point(0, 492);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.signOutButton.Size = new System.Drawing.Size(250, 68);
            this.signOutButton.TabIndex = 7;
            this.signOutButton.Text = "  Sign Out";
            this.signOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.signOutButton.UseVisualStyleBackColor = false;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // missingButton
            // 
            this.missingButton.BackColor = System.Drawing.Color.Pink;
            this.missingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.missingButton.FlatAppearance.BorderSize = 0;
            this.missingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.missingButton.ForeColor = System.Drawing.Color.White;
            this.missingButton.Image = global::BTM495.Properties.Resources.MissingInventoryIconSmall;
            this.missingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.missingButton.Location = new System.Drawing.Point(0, 424);
            this.missingButton.Name = "missingButton";
            this.missingButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.missingButton.Size = new System.Drawing.Size(250, 68);
            this.missingButton.TabIndex = 6;
            this.missingButton.Text = "  Missing";
            this.missingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.missingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.missingButton.UseVisualStyleBackColor = false;
            this.missingButton.Click += new System.EventHandler(this.missingButton_Click);
            // 
            // notificationsButton
            // 
            this.notificationsButton.BackColor = System.Drawing.Color.Pink;
            this.notificationsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.notificationsButton.FlatAppearance.BorderSize = 0;
            this.notificationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationsButton.ForeColor = System.Drawing.Color.White;
            this.notificationsButton.Image = global::BTM495.Properties.Resources.NotifyIconsSmall;
            this.notificationsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notificationsButton.Location = new System.Drawing.Point(0, 356);
            this.notificationsButton.Name = "notificationsButton";
            this.notificationsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.notificationsButton.Size = new System.Drawing.Size(250, 68);
            this.notificationsButton.TabIndex = 3;
            this.notificationsButton.Text = "  Notifications";
            this.notificationsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notificationsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.notificationsButton.UseVisualStyleBackColor = false;
            this.notificationsButton.Click += new System.EventHandler(this.notificationsButton_Click);
            // 
            // SubMenuPanel
            // 
            this.SubMenuPanel.BackColor = System.Drawing.Color.Pink;
            this.SubMenuPanel.Controls.Add(this.orderDemoButton);
            this.SubMenuPanel.Controls.Add(this.addProductsButton);
            this.SubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuPanel.Location = new System.Drawing.Point(0, 231);
            this.SubMenuPanel.Name = "SubMenuPanel";
            this.SubMenuPanel.Size = new System.Drawing.Size(250, 125);
            this.SubMenuPanel.TabIndex = 2;
            // 
            // orderDemoButton
            // 
            this.orderDemoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.orderDemoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderDemoButton.FlatAppearance.BorderSize = 0;
            this.orderDemoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderDemoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDemoButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.orderDemoButton.Location = new System.Drawing.Point(0, 63);
            this.orderDemoButton.Name = "orderDemoButton";
            this.orderDemoButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.orderDemoButton.Size = new System.Drawing.Size(250, 63);
            this.orderDemoButton.TabIndex = 1;
            this.orderDemoButton.Text = "Order Demo";
            this.orderDemoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderDemoButton.UseVisualStyleBackColor = false;
            this.orderDemoButton.Click += new System.EventHandler(this.orderDemoButton_Click);
            // 
            // addProductsButton
            // 
            this.addProductsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.addProductsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addProductsButton.FlatAppearance.BorderSize = 0;
            this.addProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductsButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addProductsButton.Location = new System.Drawing.Point(0, 0);
            this.addProductsButton.Name = "addProductsButton";
            this.addProductsButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.addProductsButton.Size = new System.Drawing.Size(250, 63);
            this.addProductsButton.TabIndex = 0;
            this.addProductsButton.Text = "Add Products";
            this.addProductsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProductsButton.UseVisualStyleBackColor = false;
            this.addProductsButton.Click += new System.EventHandler(this.addProductsButton_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.BackColor = System.Drawing.Color.Pink;
            this.inventoryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventoryButton.FlatAppearance.BorderSize = 0;
            this.inventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryButton.ForeColor = System.Drawing.Color.White;
            this.inventoryButton.Image = global::BTM495.Properties.Resources.AvailableInventoryIconSmall;
            this.inventoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryButton.Location = new System.Drawing.Point(0, 163);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.inventoryButton.Size = new System.Drawing.Size(250, 68);
            this.inventoryButton.TabIndex = 1;
            this.inventoryButton.Text = "  Inventory";
            this.inventoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inventoryButton.UseVisualStyleBackColor = false;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.Pink;
            this.logoPanel.Controls.Add(this.logoPictureBox);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(250, 163);
            this.logoPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(73, 28);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(107, 106);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 1;
            this.logoPictureBox.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(696, 570);
            this.panelChildForm.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 570);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Dashboard";
            this.Text = "Inventory Manager";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.SubMenuPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel SubMenuPanel;
        private System.Windows.Forms.Button orderDemoButton;
        private System.Windows.Forms.Button addProductsButton;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Button missingButton;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button notificationsButton;
    }
}

