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
    public partial class frmAdminView : Form
    {
        public string users;
        public string items;
        public string orders;
        public frmAdminView(string users, string items, string orders)
        {
            InitializeComponent();
            this.users = users;
            this.items = items;
            this.orders = orders;
        }

        private void frmAdminView_Load(object sender, EventArgs e)
        {
            LoadingData data = new LoadingData();
            data.LoadUsers(users);
            data.LoadItems(items);
            data.LoadOrders(orders);

            BindingSource bs1 = new BindingSource(data.usersList, null);
            BindingSource bs2 = new BindingSource(data.itemsList, null);
            BindingSource bs3 = new BindingSource(data.ordersList, null);

            dgvUsers.DataSource = bs1;
            dgvItems.DataSource = bs2;
            dgvOrders.DataSource = bs3;
        }

        private void btnSeeUserDetails_Click(object sender, EventArgs e)
        {
            Users selectedUser = (Users)dgvUsers.CurrentRow.DataBoundItem;
            frmUserDetails details = new frmUserDetails(selectedUser);
            details.Show();
        }

        private void btnItemDetails_Click(object sender, EventArgs e)
        {
            Items selectedItem = (Items)dgvItems.CurrentRow.DataBoundItem;
            frmItemDetails details = new frmItemDetails(selectedItem);
            details.Show();
        }

        private void btnSeeOrderDetails_Click(object sender, EventArgs e)
        {
            Orders selectedOrder = (Orders)dgvOrders.CurrentRow.DataBoundItem;
            frmDetailsForOrder details = new frmDetailsForOrder(selectedOrder);
            details.Show();
        }
    }
}
