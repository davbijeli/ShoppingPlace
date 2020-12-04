namespace ShoppingPlace
{
    partial class frmMain
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
            this.btnLoadUsers = new System.Windows.Forms.Button();
            this.btnLoadArticles = new System.Windows.Forms.Button();
            this.btnLoadOrders = new System.Windows.Forms.Button();
            this.lblLoadUsers = new System.Windows.Forms.Label();
            this.lblLoadArticles = new System.Windows.Forms.Label();
            this.lblLoadOrders = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoadUsers
            // 
            this.btnLoadUsers.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadUsers.Location = new System.Drawing.Point(63, 93);
            this.btnLoadUsers.Name = "btnLoadUsers";
            this.btnLoadUsers.Size = new System.Drawing.Size(166, 68);
            this.btnLoadUsers.TabIndex = 0;
            this.btnLoadUsers.Text = "LOADING USERS";
            this.btnLoadUsers.UseVisualStyleBackColor = true;
            this.btnLoadUsers.Click += new System.EventHandler(this.btnLoadUsers_Click);
            // 
            // btnLoadArticles
            // 
            this.btnLoadArticles.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadArticles.Location = new System.Drawing.Point(63, 167);
            this.btnLoadArticles.Name = "btnLoadArticles";
            this.btnLoadArticles.Size = new System.Drawing.Size(166, 68);
            this.btnLoadArticles.TabIndex = 1;
            this.btnLoadArticles.Text = "LOADING ITEMS";
            this.btnLoadArticles.UseVisualStyleBackColor = true;
            this.btnLoadArticles.Click += new System.EventHandler(this.btnLoadArticles_Click);
            // 
            // btnLoadOrders
            // 
            this.btnLoadOrders.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadOrders.Location = new System.Drawing.Point(63, 241);
            this.btnLoadOrders.Name = "btnLoadOrders";
            this.btnLoadOrders.Size = new System.Drawing.Size(166, 68);
            this.btnLoadOrders.TabIndex = 2;
            this.btnLoadOrders.Text = "LOADING ORDERS";
            this.btnLoadOrders.UseVisualStyleBackColor = true;
            this.btnLoadOrders.Click += new System.EventHandler(this.btnLoadOrders_Click);
            // 
            // lblLoadUsers
            // 
            this.lblLoadUsers.AutoSize = true;
            this.lblLoadUsers.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadUsers.ForeColor = System.Drawing.Color.Red;
            this.lblLoadUsers.Location = new System.Drawing.Point(244, 112);
            this.lblLoadUsers.Name = "lblLoadUsers";
            this.lblLoadUsers.Size = new System.Drawing.Size(120, 27);
            this.lblLoadUsers.TabIndex = 3;
            this.lblLoadUsers.Text = "NOT LOADED!";
            // 
            // lblLoadArticles
            // 
            this.lblLoadArticles.AutoSize = true;
            this.lblLoadArticles.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadArticles.ForeColor = System.Drawing.Color.Red;
            this.lblLoadArticles.Location = new System.Drawing.Point(244, 186);
            this.lblLoadArticles.Name = "lblLoadArticles";
            this.lblLoadArticles.Size = new System.Drawing.Size(120, 27);
            this.lblLoadArticles.TabIndex = 4;
            this.lblLoadArticles.Text = "NOT LOADED!";
            // 
            // lblLoadOrders
            // 
            this.lblLoadOrders.AutoSize = true;
            this.lblLoadOrders.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadOrders.ForeColor = System.Drawing.Color.Red;
            this.lblLoadOrders.Location = new System.Drawing.Point(244, 260);
            this.lblLoadOrders.Name = "lblLoadOrders";
            this.lblLoadOrders.Size = new System.Drawing.Size(120, 27);
            this.lblLoadOrders.TabIndex = 5;
            this.lblLoadOrders.Text = "NOT LOADED!";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(63, 353);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(166, 68);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "GO TO LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(52, 24);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(321, 66);
            this.lblFormTitle.TabIndex = 7;
            this.lblFormTitle.Text = "LOADING DATA";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(430, 465);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLoadOrders);
            this.Controls.Add(this.lblLoadArticles);
            this.Controls.Add(this.lblLoadUsers);
            this.Controls.Add(this.btnLoadOrders);
            this.Controls.Add(this.btnLoadArticles);
            this.Controls.Add(this.btnLoadUsers);
            this.Name = "frmMain";
            this.Text = "SHOPPING PLACE | File Loading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadUsers;
        private System.Windows.Forms.Button btnLoadArticles;
        private System.Windows.Forms.Button btnLoadOrders;
        private System.Windows.Forms.Label lblLoadUsers;
        private System.Windows.Forms.Label lblLoadArticles;
        private System.Windows.Forms.Label lblLoadOrders;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblFormTitle;
    }
}

