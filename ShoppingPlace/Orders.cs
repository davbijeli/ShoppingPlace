using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingPlace
{
    public class Orders
    {
        public string Id { get; set; }
        public string User { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
        public string Deliverer { get; set; }
        public string DateTime { get; set; }
    }
}
