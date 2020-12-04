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
    public partial class frmSupply : Form
    {
        public string users;
        public string items;
        public string orders;
        public string logUser;
        public List<Items> orderedItems = new List<Items>();
        public frmSupply(string users, string items, string orders, string logUser)
        {
            InitializeComponent();
            this.users = users;
            this.items = items;
            this.orders = orders;
            this.logUser = logUser;
            lblNameValue.Text = logUser;
            cmbCategory.Items.Add("MLIJEČNI PROIZVODI");
            cmbCategory.Items.Add("SLATKIŠI");
            cmbCategory.Items.Add("BIJELA TEHNIKA");
        }

        private void frmSupply_Load(object sender, EventArgs e)
        {
            LoadingData data = new LoadingData();
            data.LoadItems(items);

            BindingSource bs = new BindingSource(data.itemsList,null);
            dgvItemsList.DataSource = bs;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            Items selectedItem = (Items)dgvItemsList.CurrentRow.DataBoundItem;
            orderedItems.Add(selectedItem);
            BindingSource bs = new BindingSource(orderedItems, null);
            dgvCart.DataSource = bs;
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            Items selectedItem = (Items)dgvCart.CurrentRow.DataBoundItem;
            orderedItems.Remove(selectedItem);
            BindingSource bs = new BindingSource(orderedItems, null);
            dgvCart.DataSource = bs;
        }

        private void btnOrderItems_Click(object sender, EventArgs e)
        {
            frmOrderDetails details = new frmOrderDetails(orderedItems, logUser, orders);
            details.ShowDialog();
        }
    }
}
