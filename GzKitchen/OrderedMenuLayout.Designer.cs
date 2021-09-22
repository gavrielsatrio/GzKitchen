namespace GzKitchen
{
    partial class OrderedMenuLayout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderedMenuLayout));
            this.lblOrderedMenuSubtotal = new System.Windows.Forms.Label();
            this.lblOrderedMenuQty = new System.Windows.Forms.Label();
            this.picBoxOrderedMenu = new System.Windows.Forms.PictureBox();
            this.lblOrderedMenuPrice = new System.Windows.Forms.Label();
            this.lblOrderedMenuName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOrderedMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderedMenuSubtotal
            // 
            this.lblOrderedMenuSubtotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblOrderedMenuSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderedMenuSubtotal.Location = new System.Drawing.Point(263, 0);
            this.lblOrderedMenuSubtotal.Name = "lblOrderedMenuSubtotal";
            this.lblOrderedMenuSubtotal.Size = new System.Drawing.Size(80, 84);
            this.lblOrderedMenuSubtotal.TabIndex = 3;
            this.lblOrderedMenuSubtotal.Text = "Rp 2000000";
            this.lblOrderedMenuSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrderedMenuQty
            // 
            this.lblOrderedMenuQty.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblOrderedMenuQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderedMenuQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblOrderedMenuQty.Location = new System.Drawing.Point(229, 0);
            this.lblOrderedMenuQty.Name = "lblOrderedMenuQty";
            this.lblOrderedMenuQty.Size = new System.Drawing.Size(34, 84);
            this.lblOrderedMenuQty.TabIndex = 2;
            this.lblOrderedMenuQty.Text = "x20";
            this.lblOrderedMenuQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picBoxOrderedMenu
            // 
            this.picBoxOrderedMenu.Image = ((System.Drawing.Image)(resources.GetObject("picBoxOrderedMenu.Image")));
            this.picBoxOrderedMenu.Location = new System.Drawing.Point(12, 12);
            this.picBoxOrderedMenu.Name = "picBoxOrderedMenu";
            this.picBoxOrderedMenu.Size = new System.Drawing.Size(60, 60);
            this.picBoxOrderedMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxOrderedMenu.TabIndex = 0;
            this.picBoxOrderedMenu.TabStop = false;
            // 
            // lblOrderedMenuPrice
            // 
            this.lblOrderedMenuPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderedMenuPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderedMenuPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblOrderedMenuPrice.Location = new System.Drawing.Point(78, 42);
            this.lblOrderedMenuPrice.Name = "lblOrderedMenuPrice";
            this.lblOrderedMenuPrice.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblOrderedMenuPrice.Size = new System.Drawing.Size(145, 30);
            this.lblOrderedMenuPrice.TabIndex = 1;
            this.lblOrderedMenuPrice.Text = "Rp 10";
            // 
            // lblOrderedMenuName
            // 
            this.lblOrderedMenuName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderedMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderedMenuName.Location = new System.Drawing.Point(78, 12);
            this.lblOrderedMenuName.Name = "lblOrderedMenuName";
            this.lblOrderedMenuName.Padding = new System.Windows.Forms.Padding(8, 0, 0, 2);
            this.lblOrderedMenuName.Size = new System.Drawing.Size(145, 30);
            this.lblOrderedMenuName.TabIndex = 0;
            this.lblOrderedMenuName.Text = "Menu 1";
            this.lblOrderedMenuName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.btnDelete.Location = new System.Drawing.Point(343, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.btnDelete.Size = new System.Drawing.Size(41, 28);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "X";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // OrderedMenuLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.lblOrderedMenuQty);
            this.Controls.Add(this.lblOrderedMenuSubtotal);
            this.Controls.Add(this.lblOrderedMenuPrice);
            this.Controls.Add(this.lblOrderedMenuName);
            this.Controls.Add(this.picBoxOrderedMenu);
            this.Controls.Add(this.btnDelete);
            this.Name = "OrderedMenuLayout";
            this.Size = new System.Drawing.Size(384, 84);
            this.Load += new System.EventHandler(this.OrderedMenuLayout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOrderedMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOrderedMenuPrice;
        private System.Windows.Forms.Label lblOrderedMenuQty;
        private System.Windows.Forms.Label lblOrderedMenuSubtotal;
        private System.Windows.Forms.PictureBox picBoxOrderedMenu;
        private System.Windows.Forms.Label lblOrderedMenuName;
        private System.Windows.Forms.Label btnDelete;
    }
}
