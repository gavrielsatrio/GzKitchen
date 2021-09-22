namespace GzKitchen
{
    partial class FormPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            this.lblTableNo = new System.Windows.Forms.Label();
            this.btnProceedPayment = new System.Windows.Forms.Button();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.txtTableNo = new System.Windows.Forms.TextBox();
            this.txtTotalPayment = new System.Windows.Forms.Label();
            this.lblAmountTendered = new System.Windows.Forms.Label();
            this.txtAmountTendered = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTableNo
            // 
            this.lblTableNo.AutoSize = true;
            this.lblTableNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNo.Location = new System.Drawing.Point(24, 255);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(71, 16);
            this.lblTableNo.TabIndex = 48;
            this.lblTableNo.Text = "Table No :";
            // 
            // btnProceedPayment
            // 
            this.btnProceedPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.btnProceedPayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnProceedPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceedPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceedPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnProceedPayment.Location = new System.Drawing.Point(24, 307);
            this.btnProceedPayment.Name = "btnProceedPayment";
            this.btnProceedPayment.Size = new System.Drawing.Size(336, 50);
            this.btnProceedPayment.TabIndex = 2;
            this.btnProceedPayment.Text = "Proceed Payment";
            this.btnProceedPayment.UseVisualStyleBackColor = false;
            this.btnProceedPayment.Click += new System.EventHandler(this.btnProceedPayment_Click);
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayment.Location = new System.Drawing.Point(24, 24);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(101, 16);
            this.lblTotalPayment.TabIndex = 56;
            this.lblTotalPayment.Text = "Total Payment :";
            // 
            // txtTableNo
            // 
            this.txtTableNo.Location = new System.Drawing.Point(101, 254);
            this.txtTableNo.Name = "txtTableNo";
            this.txtTableNo.Size = new System.Drawing.Size(100, 20);
            this.txtTableNo.TabIndex = 1;
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.AutoSize = true;
            this.txtTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPayment.Location = new System.Drawing.Point(24, 48);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.Size = new System.Drawing.Size(121, 29);
            this.txtTotalPayment.TabIndex = 56;
            this.txtTotalPayment.Text = "Rp 10.000";
            // 
            // lblAmountTendered
            // 
            this.lblAmountTendered.AutoSize = true;
            this.lblAmountTendered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountTendered.Location = new System.Drawing.Point(24, 93);
            this.lblAmountTendered.Name = "lblAmountTendered";
            this.lblAmountTendered.Size = new System.Drawing.Size(122, 16);
            this.lblAmountTendered.TabIndex = 56;
            this.lblAmountTendered.Text = "Amount Tendered :";
            // 
            // txtAmountTendered
            // 
            this.txtAmountTendered.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountTendered.Location = new System.Drawing.Point(24, 112);
            this.txtAmountTendered.Margin = new System.Windows.Forms.Padding(6);
            this.txtAmountTendered.Name = "txtAmountTendered";
            this.txtAmountTendered.Size = new System.Drawing.Size(336, 38);
            this.txtAmountTendered.TabIndex = 0;
            this.txtAmountTendered.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAmountTendered_KeyUp);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(24, 166);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(61, 16);
            this.lblChange.TabIndex = 56;
            this.lblChange.Text = "Change :";
            // 
            // txtChange
            // 
            this.txtChange.AutoSize = true;
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(24, 190);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(63, 29);
            this.txtChange.TabIndex = 56;
            this.txtChange.Text = "Rp 0";
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(384, 381);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtTotalPayment);
            this.Controls.Add(this.lblAmountTendered);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblTotalPayment);
            this.Controls.Add(this.btnProceedPayment);
            this.Controls.Add(this.txtAmountTendered);
            this.Controls.Add(this.txtTableNo);
            this.Controls.Add(this.lblTableNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPayment";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gz Kitchen - Payment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPayment_FormClosed);
            this.Load += new System.EventHandler(this.FormPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.Button btnProceedPayment;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.TextBox txtTableNo;
        private System.Windows.Forms.Label txtTotalPayment;
        private System.Windows.Forms.Label lblAmountTendered;
        private System.Windows.Forms.TextBox txtAmountTendered;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label txtChange;
    }
}