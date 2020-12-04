namespace ShoppingPlace
{
    partial class frmOrderDetails
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
            this.lbOrderDetails = new System.Windows.Forms.ListBox();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.lblUkupanIznos = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbChooseDistributor = new System.Windows.Forms.ComboBox();
            this.lblDistributor = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOrderDetails
            // 
            this.lbOrderDetails.FormattingEnabled = true;
            this.lbOrderDetails.Location = new System.Drawing.Point(99, 80);
            this.lbOrderDetails.Name = "lbOrderDetails";
            this.lbOrderDetails.Size = new System.Drawing.Size(366, 251);
            this.lbOrderDetails.TabIndex = 0;
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDetails.Location = new System.Drawing.Point(161, 31);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(247, 31);
            this.lblOrderDetails.TabIndex = 1;
            this.lblOrderDetails.Text = "ORDER DETAILS";
            // 
            // lblUkupanIznos
            // 
            this.lblUkupanIznos.AutoSize = true;
            this.lblUkupanIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupanIznos.ForeColor = System.Drawing.Color.Yellow;
            this.lblUkupanIznos.Location = new System.Drawing.Point(414, 361);
            this.lblUkupanIznos.Name = "lblUkupanIznos";
            this.lblUkupanIznos.Size = new System.Drawing.Size(24, 26);
            this.lblUkupanIznos.TabIndex = 2;
            this.lblUkupanIznos.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(322, 361);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(86, 26);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "TOTAL:";
            // 
            // cmbChooseDistributor
            // 
            this.cmbChooseDistributor.FormattingEnabled = true;
            this.cmbChooseDistributor.Location = new System.Drawing.Point(327, 337);
            this.cmbChooseDistributor.Name = "cmbChooseDistributor";
            this.cmbChooseDistributor.Size = new System.Drawing.Size(138, 21);
            this.cmbChooseDistributor.TabIndex = 4;
            this.cmbChooseDistributor.SelectedIndexChanged += new System.EventHandler(this.cmbChooseDistributor_SelectedIndexChanged);
            // 
            // lblDistributor
            // 
            this.lblDistributor.AutoSize = true;
            this.lblDistributor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistributor.Location = new System.Drawing.Point(176, 338);
            this.lblDistributor.Name = "lblDistributor";
            this.lblDistributor.Size = new System.Drawing.Size(145, 20);
            this.lblDistributor.TabIndex = 5;
            this.lblDistributor.Text = "Choose Distributor:";
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(327, 402);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(138, 50);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(558, 464);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblDistributor);
            this.Controls.Add(this.cmbChooseDistributor);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblUkupanIznos);
            this.Controls.Add(this.lblOrderDetails);
            this.Controls.Add(this.lbOrderDetails);
            this.Name = "frmOrderDetails";
            this.Text = "SHOPPING PLACE | Order Details";
            this.Load += new System.EventHandler(this.frmOrderDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.ListBox lbOrderDetails;
        private System.Windows.Forms.Label lblUkupanIznos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cmbChooseDistributor;
        private System.Windows.Forms.Label lblDistributor;
        private System.Windows.Forms.Button btnOrder;
    }
}