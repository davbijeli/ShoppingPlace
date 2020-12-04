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
    public partial class frmItemDetails : Form
    {
        Items item = new Items();
        public frmItemDetails(Items item)
        {
            InitializeComponent();
            this.item = item;
        }

        private void frmItemDetails_Load(object sender, EventArgs e)
        {
            txtItemId.Text = item.Id.ToString();
            txtCategory.Text = item.Category;
            txtName.Text = item.Name;
            txtPrice.Text = item.Price.ToString();
        }
    }
}
