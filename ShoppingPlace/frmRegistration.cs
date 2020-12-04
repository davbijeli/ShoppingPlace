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
    public partial class frmRegistration : Form
    {
        public string users;
        public string items;
        public string orders;
        public frmRegistration(string users, string items, string orders)
        {
            InitializeComponent();
            this.users = users;
            this.items = items;
            this.orders = orders;
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtSurname.Text == "" || txtPIN.Text == "" || txtUserName.Text == "" || txtPassword.Text == "")
            {
                lblErrorMessage.Text = "Error Message: You didn't fill all boxes!";
            }
            else
            {
                System.IO.File.AppendAllText(users, txtPIN.Text + ";" + txtName.Text + ";" + txtSurname.Text + ";" + txtUserName.Text + ";" + txtPassword.Text + Environment.NewLine);
            }  
        }
    }
}
