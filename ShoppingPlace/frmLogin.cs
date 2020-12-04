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
    public partial class frmLogin : Form
    {
        public string users;
        public string items;
        public string orders;
        public frmLogin(string users, string items, string orders)
        {
            InitializeComponent();
            this.users = users;
            this.items = items;
            this.orders = orders;
        }

        private void lnklblRegistrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistration register = new frmRegistration(users, items, orders);
            register.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoadingData data = new LoadingData();
            data.LoadUsers(users);
            foreach(var item in data.usersList)
            {
                if(txtUserName.Text == item.UserName && txtPassword.Text == item.Password)
                {
                    frmSupply supply = new frmSupply(users, items, orders, item.UserName);
                    supply.Show();
                }
                else if(txtUserName.Text == "user" && txtPassword.Text == "0000")
                {
                    frmAdminView admin = new frmAdminView(users, items, orders);
                    admin.Show();
                }
                else
                {
                    lblError.Text = "User name or password is not correct!";
                }
            }
        }
    }
}
