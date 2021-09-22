namespace GzKitchen
{
    partial class FormNavigationCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNavigationCashier));
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.panelCashier = new System.Windows.Forms.Panel();
            this.lblCashierEmail = new System.Windows.Forms.Label();
            this.lblCashierName = new System.Windows.Forms.Label();
            this.picBoxCashier = new System.Windows.Forms.PictureBox();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.panelOrderedMenu = new System.Windows.Forms.Panel();
            this.btnCharge = new System.Windows.Forms.Button();
            this.lblOrderedMenu = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMenuList = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.picBoxSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblMenuList = new System.Windows.Forms.Label();
            this.panelNavBar.SuspendLayout();
            this.panelCashier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCashier)).BeginInit();
            this.panelPayment.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.panelNavBar.Controls.Add(this.panelCashier);
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavBar.Location = new System.Drawing.Point(0, 0);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Padding = new System.Windows.Forms.Padding(12);
            this.panelNavBar.Size = new System.Drawing.Size(1084, 94);
            this.panelNavBar.TabIndex = 12;
            // 
            // panelCashier
            // 
            this.panelCashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.panelCashier.Controls.Add(this.lblCashierEmail);
            this.panelCashier.Controls.Add(this.lblCashierName);
            this.panelCashier.Controls.Add(this.picBoxCashier);
            this.panelCashier.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelCashier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCashier.Location = new System.Drawing.Point(12, 12);
            this.panelCashier.Name = "panelCashier";
            this.panelCashier.Size = new System.Drawing.Size(1060, 70);
            this.panelCashier.TabIndex = 10;
            // 
            // lblCashierEmail
            // 
            this.lblCashierEmail.AutoSize = true;
            this.lblCashierEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCashierEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblCashierEmail.Location = new System.Drawing.Point(59, 39);
            this.lblCashierEmail.Name = "lblCashierEmail";
            this.lblCashierEmail.Size = new System.Drawing.Size(112, 15);
            this.lblCashierEmail.TabIndex = 15;
            this.lblCashierEmail.Text = "admin@gmail.com";
            this.lblCashierEmail.Click += new System.EventHandler(this.lblCashierEmail_Click);
            // 
            // lblCashierName
            // 
            this.lblCashierName.AutoSize = true;
            this.lblCashierName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCashierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblCashierName.Location = new System.Drawing.Point(58, 15);
            this.lblCashierName.Name = "lblCashierName";
            this.lblCashierName.Size = new System.Drawing.Size(68, 24);
            this.lblCashierName.TabIndex = 14;
            this.lblCashierName.Text = "Gavriel";
            this.lblCashierName.Click += new System.EventHandler(this.lblCashierName_Click);
            // 
            // picBoxCashier
            // 
            this.picBoxCashier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxCashier.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCashier.Image")));
            this.picBoxCashier.Location = new System.Drawing.Point(16, 19);
            this.picBoxCashier.Name = "picBoxCashier";
            this.picBoxCashier.Size = new System.Drawing.Size(32, 32);
            this.picBoxCashier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCashier.TabIndex = 13;
            this.picBoxCashier.TabStop = false;
            this.picBoxCashier.Click += new System.EventHandler(this.picBoxCashier_Click);
            // 
            // panelPayment
            // 
            this.panelPayment.Controls.Add(this.panelTotal);
            this.panelPayment.Controls.Add(this.panelOrderedMenu);
            this.panelPayment.Controls.Add(this.btnCharge);
            this.panelPayment.Controls.Add(this.lblOrderedMenu);
            this.panelPayment.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPayment.Location = new System.Drawing.Point(644, 94);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Padding = new System.Windows.Forms.Padding(24);
            this.panelPayment.Size = new System.Drawing.Size(440, 347);
            this.panelPayment.TabIndex = 52;
            // 
            // panelTotal
            // 
            this.panelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTotal.Controls.Add(this.lblTotal);
            this.panelTotal.Controls.Add(this.txtTotal);
            this.panelTotal.Location = new System.Drawing.Point(24, 239);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(392, 28);
            this.panelTotal.TabIndex = 56;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 28);
            this.lblTotal.TabIndex = 56;
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Location = new System.Drawing.Point(152, 0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(240, 28);
            this.txtTotal.TabIndex = 55;
            this.txtTotal.Text = "Rp 0";
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelOrderedMenu
            // 
            this.panelOrderedMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOrderedMenu.AutoScroll = true;
            this.panelOrderedMenu.Location = new System.Drawing.Point(24, 70);
            this.panelOrderedMenu.Name = "panelOrderedMenu";
            this.panelOrderedMenu.Size = new System.Drawing.Size(404, 163);
            this.panelOrderedMenu.TabIndex = 51;
            // 
            // btnCharge
            // 
            this.btnCharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.btnCharge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnCharge.Location = new System.Drawing.Point(24, 273);
            this.btnCharge.Name = "btnCharge";
            this.btnCharge.Size = new System.Drawing.Size(392, 50);
            this.btnCharge.TabIndex = 54;
            this.btnCharge.Text = "Charge";
            this.btnCharge.UseVisualStyleBackColor = false;
            this.btnCharge.Click += new System.EventHandler(this.btnCharge_Click);
            // 
            // lblOrderedMenu
            // 
            this.lblOrderedMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderedMenu.Location = new System.Drawing.Point(24, 24);
            this.lblOrderedMenu.Name = "lblOrderedMenu";
            this.lblOrderedMenu.Size = new System.Drawing.Size(180, 30);
            this.lblOrderedMenu.TabIndex = 51;
            this.lblOrderedMenu.Text = "Ordered Menu";
            this.lblOrderedMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelMenu.Controls.Add(this.panelMenuList);
            this.panelMenu.Controls.Add(this.panelSearch);
            this.panelMenu.Controls.Add(this.lblMenuList);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 94);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(644, 347);
            this.panelMenu.TabIndex = 53;
            // 
            // panelMenuList
            // 
            this.panelMenuList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenuList.AutoScroll = true;
            this.panelMenuList.AutoScrollMargin = new System.Drawing.Size(12, 12);
            this.panelMenuList.Location = new System.Drawing.Point(24, 80);
            this.panelMenuList.Name = "panelMenuList";
            this.panelMenuList.Size = new System.Drawing.Size(596, 243);
            this.panelMenuList.TabIndex = 50;
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panelSearch.Controls.Add(this.picBoxSearch);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Location = new System.Drawing.Point(337, 24);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(283, 39);
            this.panelSearch.TabIndex = 49;
            // 
            // picBoxSearch
            // 
            this.picBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("picBoxSearch.Image")));
            this.picBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.picBoxSearch.Name = "picBoxSearch";
            this.picBoxSearch.Size = new System.Drawing.Size(15, 15);
            this.picBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSearch.TabIndex = 49;
            this.picBoxSearch.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(38, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(242, 15);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // lblMenuList
            // 
            this.lblMenuList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuList.Location = new System.Drawing.Point(24, 24);
            this.lblMenuList.Name = "lblMenuList";
            this.lblMenuList.Size = new System.Drawing.Size(142, 30);
            this.lblMenuList.TabIndex = 48;
            this.lblMenuList.Text = "Menu List";
            this.lblMenuList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormNavigationCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1084, 441);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelPayment);
            this.Controls.Add(this.panelNavBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNavigationCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gz Kitchen - Cashier";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNavigationCashier_FormClosed);
            this.Load += new System.EventHandler(this.FormNavigationCashier_Load);
            this.panelNavBar.ResumeLayout(false);
            this.panelCashier.ResumeLayout(false);
            this.panelCashier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCashier)).EndInit();
            this.panelPayment.ResumeLayout(false);
            this.panelTotal.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Panel panelCashier;
        private System.Windows.Forms.Label lblCashierEmail;
        private System.Windows.Forms.Label lblCashierName;
        private System.Windows.Forms.PictureBox picBoxCashier;
        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblMenuList;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox picBoxSearch;
        private System.Windows.Forms.Panel panelMenuList;
        private System.Windows.Forms.Label lblOrderedMenu;
        private System.Windows.Forms.Button btnCharge;
        private System.Windows.Forms.Panel panelOrderedMenu;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}