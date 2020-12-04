namespace ShoppingPlace
{
    partial class frmAdminView
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.lblUsers = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.lblItems = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.lblOrders = new System.Windows.Forms.Label();
            this.btnSeeUserDetails = new System.Windows.Forms.Button();
            this.btnItemDetails = new System.Windows.Forms.Button();
            this.btnSeeOrderDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(12, 95);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(267, 558);
            this.dgvUsers.TabIndex = 0;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(85, 61);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(113, 31);
            this.lblUsers.TabIndex = 1;
            this.lblUsers.Text = "USERS";
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(296, 95);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(275, 558);
            this.dgvItems.TabIndex = 2;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(380, 61);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(102, 31);
            this.lblItems.TabIndex = 3;
            this.lblItems.Text = "ITEMS";
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(587, 95);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(502, 558);
            this.dgvOrders.TabIndex = 4;
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.Location = new System.Drawing.Point(777, 61);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(137, 31);
            this.lblOrders.TabIndex = 5;
            this.lblOrders.Text = "ORDERS";
            // 
            // btnSeeUserDetails
            // 
            this.btnSeeUserDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeUserDetails.Location = new System.Drawing.Point(13, 660);
            this.btnSeeUserDetails.Name = "btnSeeUserDetails";
            this.btnSeeUserDetails.Size = new System.Drawing.Size(266, 49);
            this.btnSeeUserDetails.TabIndex = 6;
            this.btnSeeUserDetails.Text = "SEE DETAILS";
            this.btnSeeUserDetails.UseVisualStyleBackColor = true;
            this.btnSeeUserDetails.Click += new System.EventHandler(this.btnSeeUserDetails_Click);
            // 
            // btnItemDetails
            // 
            this.btnItemDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemDetails.Location = new System.Drawing.Point(296, 660);
            this.btnItemDetails.Name = "btnItemDetails";
            this.btnItemDetails.Size = new System.Drawing.Size(275, 49);
            this.btnItemDetails.TabIndex = 7;
            this.btnItemDetails.Text = "SEE DETAILS";
            this.btnItemDetails.UseVisualStyleBackColor = true;
            this.btnItemDetails.Click += new System.EventHandler(this.btnItemDetails_Click);
            // 
            // btnSeeOrderDetails
            // 
            this.btnSeeOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeOrderDetails.Location = new System.Drawing.Point(587, 660);
            this.btnSeeOrderDetails.Name = "btnSeeOrderDetails";
            this.btnSeeOrderDetails.Size = new System.Drawing.Size(502, 49);
            this.btnSeeOrderDetails.TabIndex = 8;
            this.btnSeeOrderDetails.Text = "SEE DETAILS";
            this.btnSeeOrderDetails.UseVisualStyleBackColor = true;
            this.btnSeeOrderDetails.Click += new System.EventHandler(this.btnSeeOrderDetails_Click);
            // 
            // frmAdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1101, 721);
            this.Controls.Add(this.btnSeeOrderDetails);
            this.Controls.Add(this.btnItemDetails);
            this.Controls.Add(this.btnSeeUserDetails);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.dgvUsers);
            this.Name = "frmAdminView";
            this.Text = "SHOPPING PLACE | Admin";
            this.Load += new System.EventHandler(this.frmAdminView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Button btnSeeUserDetails;
        private System.Windows.Forms.Button btnItemDetails;
        private System.Windows.Forms.Button btnSeeOrderDetails;
    }
}