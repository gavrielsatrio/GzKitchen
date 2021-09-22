namespace GzKitchen
{
    partial class FormNavigationAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNavigationAdmin));
            this.btnManageAccount = new System.Windows.Forms.Panel();
            this.lblManageAccount = new System.Windows.Forms.Label();
            this.picBoxManageAccount = new System.Windows.Forms.PictureBox();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.lblAdminEmail = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.picBoxAdmin = new System.Windows.Forms.PictureBox();
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.btnManageMenu = new System.Windows.Forms.Panel();
            this.lblManageMenu = new System.Windows.Forms.Label();
            this.picBoxManageMenu = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.picBoxLogout = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Panel();
            this.btnManageAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxManageAccount)).BeginInit();
            this.panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdmin)).BeginInit();
            this.panelNavBar.SuspendLayout();
            this.btnManageMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxManageMenu)).BeginInit();
            this.panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogout)).BeginInit();
            this.btnLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageAccount.Controls.Add(this.lblManageAccount);
            this.btnManageAccount.Controls.Add(this.picBoxManageAccount);
            this.btnManageAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageAccount.Location = new System.Drawing.Point(12, 14);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Padding = new System.Windows.Forms.Padding(2);
            this.btnManageAccount.Size = new System.Drawing.Size(196, 60);
            this.btnManageAccount.TabIndex = 5;
            this.btnManageAccount.Tag = "btnSideBar-Selected";
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // lblManageAccount
            // 
            this.lblManageAccount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblManageAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageAccount.Location = new System.Drawing.Point(55, 2);
            this.lblManageAccount.Name = "lblManageAccount";
            this.lblManageAccount.Size = new System.Drawing.Size(139, 56);
            this.lblManageAccount.TabIndex = 10;
            this.lblManageAccount.Text = "Manage Account";
            this.lblManageAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblManageAccount.Click += new System.EventHandler(this.lblManageAccount_Click);
            // 
            // picBoxManageAccount
            // 
            this.picBoxManageAccount.Image = ((System.Drawing.Image)(resources.GetObject("picBoxManageAccount.Image")));
            this.picBoxManageAccount.Location = new System.Drawing.Point(16, 22);
            this.picBoxManageAccount.Name = "picBoxManageAccount";
            this.picBoxManageAccount.Size = new System.Drawing.Size(24, 17);
            this.picBoxManageAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxManageAccount.TabIndex = 9;
            this.picBoxManageAccount.TabStop = false;
            this.picBoxManageAccount.Click += new System.EventHandler(this.picBoxManageAccount_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.panelAdmin.Controls.Add(this.lblAdminEmail);
            this.panelAdmin.Controls.Add(this.lblAdminName);
            this.panelAdmin.Controls.Add(this.picBoxAdmin);
            this.panelAdmin.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdmin.Location = new System.Drawing.Point(12, 12);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(760, 70);
            this.panelAdmin.TabIndex = 10;
            // 
            // lblAdminEmail
            // 
            this.lblAdminEmail.AutoSize = true;
            this.lblAdminEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdminEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblAdminEmail.Location = new System.Drawing.Point(59, 39);
            this.lblAdminEmail.Name = "lblAdminEmail";
            this.lblAdminEmail.Size = new System.Drawing.Size(112, 15);
            this.lblAdminEmail.TabIndex = 15;
            this.lblAdminEmail.Text = "admin@gmail.com";
            this.lblAdminEmail.Click += new System.EventHandler(this.lblAdminEmail_Click);
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblAdminName.Location = new System.Drawing.Point(58, 15);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(68, 24);
            this.lblAdminName.TabIndex = 14;
            this.lblAdminName.Text = "Gavriel";
            this.lblAdminName.Click += new System.EventHandler(this.lblAdminName_Click);
            // 
            // picBoxAdmin
            // 
            this.picBoxAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxAdmin.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAdmin.Image")));
            this.picBoxAdmin.Location = new System.Drawing.Point(16, 19);
            this.picBoxAdmin.Name = "picBoxAdmin";
            this.picBoxAdmin.Size = new System.Drawing.Size(32, 32);
            this.picBoxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAdmin.TabIndex = 13;
            this.picBoxAdmin.TabStop = false;
            this.picBoxAdmin.Click += new System.EventHandler(this.picBoxAdmin_Click);
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.panelNavBar.Controls.Add(this.panelAdmin);
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavBar.Location = new System.Drawing.Point(0, 0);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Padding = new System.Windows.Forms.Padding(12);
            this.panelNavBar.Size = new System.Drawing.Size(784, 94);
            this.panelNavBar.TabIndex = 11;
            // 
            // btnManageMenu
            // 
            this.btnManageMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageMenu.Controls.Add(this.lblManageMenu);
            this.btnManageMenu.Controls.Add(this.picBoxManageMenu);
            this.btnManageMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageMenu.Location = new System.Drawing.Point(12, 80);
            this.btnManageMenu.Name = "btnManageMenu";
            this.btnManageMenu.Padding = new System.Windows.Forms.Padding(2);
            this.btnManageMenu.Size = new System.Drawing.Size(196, 60);
            this.btnManageMenu.TabIndex = 10;
            this.btnManageMenu.Tag = "btnSideBar-NotSelected";
            this.btnManageMenu.Click += new System.EventHandler(this.btnManageMenu_Click);
            // 
            // lblManageMenu
            // 
            this.lblManageMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblManageMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageMenu.Location = new System.Drawing.Point(55, 2);
            this.lblManageMenu.Name = "lblManageMenu";
            this.lblManageMenu.Size = new System.Drawing.Size(139, 56);
            this.lblManageMenu.TabIndex = 12;
            this.lblManageMenu.Text = "Manage Menu";
            this.lblManageMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblManageMenu.Click += new System.EventHandler(this.lblManageMenu_Click);
            // 
            // picBoxManageMenu
            // 
            this.picBoxManageMenu.Image = ((System.Drawing.Image)(resources.GetObject("picBoxManageMenu.Image")));
            this.picBoxManageMenu.Location = new System.Drawing.Point(16, 18);
            this.picBoxManageMenu.Name = "picBoxManageMenu";
            this.picBoxManageMenu.Size = new System.Drawing.Size(24, 24);
            this.picBoxManageMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxManageMenu.TabIndex = 10;
            this.picBoxManageMenu.TabStop = false;
            this.picBoxManageMenu.Click += new System.EventHandler(this.picBoxManageMenu_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(220, 94);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(14);
            this.panelContent.Size = new System.Drawing.Size(564, 347);
            this.panelContent.TabIndex = 13;
            // 
            // panelSideBar
            // 
            this.panelSideBar.Controls.Add(this.btnLogout);
            this.panelSideBar.Controls.Add(this.btnManageAccount);
            this.panelSideBar.Controls.Add(this.btnManageMenu);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 94);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(220, 347);
            this.panelSideBar.TabIndex = 12;
            // 
            // lblLogout
            // 
            this.lblLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.Location = new System.Drawing.Point(70, 2);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(148, 56);
            this.lblLogout.TabIndex = 12;
            this.lblLogout.Text = "Logout";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // picBoxLogout
            // 
            this.picBoxLogout.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogout.Image")));
            this.picBoxLogout.Location = new System.Drawing.Point(28, 20);
            this.picBoxLogout.Name = "picBoxLogout";
            this.picBoxLogout.Size = new System.Drawing.Size(20, 20);
            this.picBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogout.TabIndex = 13;
            this.picBoxLogout.TabStop = false;
            this.picBoxLogout.Click += new System.EventHandler(this.picBoxLogout_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Controls.Add(this.picBoxLogout);
            this.btnLogout.Controls.Add(this.lblLogout);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Location = new System.Drawing.Point(0, 287);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(2);
            this.btnLogout.Size = new System.Drawing.Size(220, 60);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Tag = "btnSideBar-NotSelected";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormNavigationAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelNavBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNavigationAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gz Kitchen - Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNavigationAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormNavigationAdmin_Load);
            this.btnManageAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxManageAccount)).EndInit();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdmin)).EndInit();
            this.panelNavBar.ResumeLayout(false);
            this.btnManageMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxManageMenu)).EndInit();
            this.panelSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogout)).EndInit();
            this.btnLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel btnManageAccount;
        private System.Windows.Forms.PictureBox picBoxManageAccount;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.PictureBox picBoxAdmin;
        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Label lblAdminEmail;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Panel btnManageMenu;
        private System.Windows.Forms.PictureBox picBoxManageMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Label lblManageAccount;
        private System.Windows.Forms.Label lblManageMenu;
        private System.Windows.Forms.Panel btnLogout;
        private System.Windows.Forms.PictureBox picBoxLogout;
        private System.Windows.Forms.Label lblLogout;
    }
}