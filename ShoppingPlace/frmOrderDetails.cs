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
    public partial class frmOrderDetails : Form
    {
        public List<Items> orderedItems = new List<Items>();
        public string logUser = "";
        public string orderPath = "";
        public double sum = 0;
        public frmOrderDetails(List<Items> ordersList, string user, string path)
        {
            InitializeComponent();
            this.orderedItems = ordersList;
            this.logUser = user;
            this.orderPath = path;
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            cmbChooseDistributor.Items.Add("HRVATSKA POŠTA");
            cmbChooseDistributor.Items.Add("GLS");
            cmbChooseDistributor.Items.Add("OVERSEAS EXPRESS");

            

            foreach(var item in orderedItems)
            {
                sum = sum + item.Price;
                lbOrderDetails.Items.Add(item.Name + " : " + item.Price);
            }
            lblUkupanIznos.Text = sum.ToString(); 
        }

        private void cmbChooseDistributor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choosedDistributor = cmbChooseDistributor.SelectedItem.ToString();
            lblUkupanIznos.Text = sum.ToString();

            if (choosedDistributor == "HRVATSKA POŠTA")
            {
                lblUkupanIznos.Text = (double.Parse(lblUkupanIznos.Text) + 25).ToString();
            }
            if (choosedDistributor == "GLS")
            {
                lblUkupanIznos.Text = (double.Parse(lblUkupanIznos.Text) + 30).ToString();
            }
            if (choosedDistributor == "OVERSEAS EXPRESS")
            {
                lblUkupanIznos.Text = (double.Parse(lblUkupanIznos.Text) + 20).ToString();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            foreach(var item in orderedItems)
            {
                System.IO.File.AppendAllText(orderPath, logUser + "Order" + ";" + logUser + ";" + item.Name + ";" + "1" + ";" + item.Price + ";" + cmbChooseDistributor.SelectedItem.ToString() + ";" + DateTime.Now + "\n");
            }
        }
    }
}
