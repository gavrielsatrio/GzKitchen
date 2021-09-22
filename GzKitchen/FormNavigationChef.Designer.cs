namespace GzKitchen
{
    partial class FormNavigationChef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNavigationChef));
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.panelChef = new System.Windows.Forms.Panel();
            this.lblChefEmail = new System.Windows.Forms.Label();
            this.lblChefName = new System.Windows.Forms.Label();
            this.picBoxChef = new System.Windows.Forms.PictureBox();
            this.lblTableNo = new System.Windows.Forms.Label();
            this.comboOrderAndTable = new System.Windows.Forms.ComboBox();
            this.lblMenuToCook = new System.Windows.Forms.Label();
            this.panelMenuToCook = new System.Windows.Forms.Panel();
            this.btnConfirmChanges = new System.Windows.Forms.Button();
            this.timerShowBtnConfirmChanges = new System.Windows.Forms.Timer(this.components);
            this.panelNavBar.SuspendLayout();
            this.panelChef.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChef)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.panelNavBar.Controls.Add(this.panelChef);
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavBar.Location = new System.Drawing.Point(0, 0);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Padding = new System.Windows.Forms.Padding(12);
            this.panelNavBar.Size = new System.Drawing.Size(616, 94);
            this.panelNavBar.TabIndex = 12;
            // 
            // panelChef
            // 
            this.panelChef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.panelChef.Controls.Add(this.lblChefEmail);
            this.panelChef.Controls.Add(this.lblChefName);
            this.panelChef.Controls.Add(this.picBoxChef);
            this.panelChef.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelChef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChef.Location = new System.Drawing.Point(12, 12);
            this.panelChef.Name = "panelChef";
            this.panelChef.Size = new System.Drawing.Size(592, 70);
            this.panelChef.TabIndex = 10;
            // 
            // lblChefEmail
            // 
            this.lblChefEmail.AutoSize = true;
            this.lblChefEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblChefEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChefEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblChefEmail.Location = new System.Drawing.Point(59, 39);
            this.lblChefEmail.Name = "lblChefEmail";
            this.lblChefEmail.Size = new System.Drawing.Size(112, 15);
            this.lblChefEmail.TabIndex = 15;
            this.lblChefEmail.Text = "admin@gmail.com";
            this.lblChefEmail.Click += new System.EventHandler(this.lblChefEmail_Click);
            // 
            // lblChefName
            // 
            this.lblChefName.AutoSize = true;
            this.lblChefName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblChefName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChefName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblChefName.Location = new System.Drawing.Point(58, 15);
            this.lblChefName.Name = "lblChefName";
            this.lblChefName.Size = new System.Drawing.Size(68, 24);
            this.lblChefName.TabIndex = 14;
            this.lblChefName.Text = "Gavriel";
            this.lblChefName.Click += new System.EventHandler(this.lblChefName_Click);
            // 
            // picBoxChef
            // 
            this.picBoxChef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxChef.Image = ((System.Drawing.Image)(resources.GetObject("picBoxChef.Image")));
            this.picBoxChef.Location = new System.Drawing.Point(16, 19);
            this.picBoxChef.Name = "picBoxChef";
            this.picBoxChef.Size = new System.Drawing.Size(32, 32);
            this.picBoxChef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxChef.TabIndex = 13;
            this.picBoxChef.TabStop = false;
            this.picBoxChef.Click += new System.EventHandler(this.picBoxChef_Click);
            // 
            // lblTableNo
            // 
            this.lblTableNo.AutoSize = true;
            this.lblTableNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNo.Location = new System.Drawing.Point(12, 110);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(150, 16);
            this.lblTableNo.TabIndex = 57;
            this.lblTableNo.Text = "Order ID and Table No :";
            // 
            // comboOrderAndTable
            // 
            this.comboOrderAndTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOrderAndTable.FormattingEnabled = true;
            this.comboOrderAndTable.Location = new System.Drawing.Point(168, 109);
            this.comboOrderAndTable.Name = "comboOrderAndTable";
            this.comboOrderAndTable.Size = new System.Drawing.Size(130, 21);
            this.comboOrderAndTable.TabIndex = 0;
            this.comboOrderAndTable.SelectedIndexChanged += new System.EventHandler(this.comboOrderAndTable_SelectedIndexChanged);
            // 
            // lblMenuToCook
            // 
            this.lblMenuToCook.AutoSize = true;
            this.lblMenuToCook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuToCook.Location = new System.Drawing.Point(12, 137);
            this.lblMenuToCook.Name = "lblMenuToCook";
            this.lblMenuToCook.Size = new System.Drawing.Size(94, 16);
            this.lblMenuToCook.TabIndex = 57;
            this.lblMenuToCook.Text = "Menu to cook :";
            // 
            // panelMenuToCook
            // 
            this.panelMenuToCook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenuToCook.Location = new System.Drawing.Point(12, 156);
            this.panelMenuToCook.Name = "panelMenuToCook";
            this.panelMenuToCook.Size = new System.Drawing.Size(400, 273);
            this.panelMenuToCook.TabIndex = 1;
            // 
            // btnConfirmChanges
            // 
            this.btnConfirmChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.btnConfirmChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnConfirmChanges.Location = new System.Drawing.Point(424, 379);
            this.btnConfirmChanges.Name = "btnConfirmChanges";
            this.btnConfirmChanges.Size = new System.Drawing.Size(180, 50);
            this.btnConfirmChanges.TabIndex = 58;
            this.btnConfirmChanges.Text = "Confirm Changes";
            this.btnConfirmChanges.UseVisualStyleBackColor = false;
            this.btnConfirmChanges.Click += new System.EventHandler(this.btnConfirmChanges_Click);
            // 
            // timerShowBtnConfirmChanges
            // 
            this.timerShowBtnConfirmChanges.Interval = 10;
            this.timerShowBtnConfirmChanges.Tick += new System.EventHandler(this.timerShowBtnConfirmChanges_Tick);
            // 
            // FormNavigationChef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(616, 441);
            this.Controls.Add(this.btnConfirmChanges);
            this.Controls.Add(this.panelMenuToCook);
            this.Controls.Add(this.comboOrderAndTable);
            this.Controls.Add(this.lblMenuToCook);
            this.Controls.Add(this.lblTableNo);
            this.Controls.Add(this.panelNavBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNavigationChef";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gz Kitchen - Chef";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNavigationChef_FormClosed);
            this.Load += new System.EventHandler(this.FormNavigationChef_Load);
            this.panelNavBar.ResumeLayout(false);
            this.panelChef.ResumeLayout(false);
            this.panelChef.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Panel panelChef;
        private System.Windows.Forms.Label lblChefEmail;
        private System.Windows.Forms.Label lblChefName;
        private System.Windows.Forms.PictureBox picBoxChef;
        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.ComboBox comboOrderAndTable;
        private System.Windows.Forms.Label lblMenuToCook;
        private System.Windows.Forms.Panel panelMenuToCook;
        private System.Windows.Forms.Button btnConfirmChanges;
        private System.Windows.Forms.Timer timerShowBtnConfirmChanges;
    }
}