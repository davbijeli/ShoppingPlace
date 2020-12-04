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
    public partial class frmUserDetails : Form
    {
        public string users;
        Users user = new Users();
        public frmUserDetails(Users user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            txtIdNo.Text = user.Id.ToString();
            txtName.Text = user.Name;
            txtSurname.Text = user.Surname;
            txtUsername.Text = user.UserName;
            txtPassword.Text = user.Password;
        }
    }
}
