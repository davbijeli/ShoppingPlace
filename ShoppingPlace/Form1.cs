using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingPlace
{
    public partial class frmMain : Form
    {
        public string users;
        public string items;
        public string orders;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLoadUsers_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            if (file.FileName.Contains("user"))
            {
                lblLoadUsers.ForeColor = Color.Green;
                lblLoadUsers.Text = "OK";
                users = file.FileName;
            }
        }

        private void btnLoadArticles_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            if (file.FileName.Contains("item"))
            {
                lblLoadArticles.ForeColor = Color.Green;
                lblLoadArticles.Text = "OK";
                items = file.FileName;
            }
        }

        private void btnLoadOrders_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            if (file.FileName.Contains("order"))
            {
                lblLoadOrders.ForeColor = Color.Green;
                lblLoadOrders.Text = "OK";
                orders = file.FileName;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(lblLoadUsers.Text == "OK" && lblLoadArticles.Text == "OK" && lblLoadOrders.Text == "OK")
            {
                frmLogin login = new frmLogin(users, items, orders);
                login.Show();
            }
        }
    }
}
