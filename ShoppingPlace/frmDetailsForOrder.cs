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
    public partial class frmDetailsForOrder : Form
    {
        Orders order = new Orders();
        public frmDetailsForOrder(Orders order)
        {
            InitializeComponent();
            this.order = order;
        }

        private void frmDetailsForOrder_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = order.Id.ToString();
            txtDateTime.Text = order.DateTime.ToString();
            txtDeliverer.Text = order.Deliverer;
            txtItem.Text = order.Item;
            txtQuantity.Text = order.Quantity.ToString();
            txtTotal.Text = order.Total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
