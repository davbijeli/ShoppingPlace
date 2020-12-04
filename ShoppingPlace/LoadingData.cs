using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingPlace
{
    public class LoadingData
    {
        public List<Users> usersList = new List<Users>();
        public List<Items> itemsList = new List<Items>();
        public List<Orders> ordersList = new List<Orders>();
        public void LoadUsers(string path)
        {
            string[] usersArray = File.ReadAllLines(path);
            for(int i = 1; i < usersArray.Length; i++)
            {
                string[] usersValues = usersArray[i].Split(';');
                Users user = new Users();
                user.Id = long.Parse(usersValues[0]);
                user.Name = usersValues[1];
                user.Surname = usersValues[2];
                user.UserName = usersValues[3];
                user.Password = usersValues[4];
                usersList.Add(user);
            }
        }

        public void LoadItems(string path)
        {
            string[] itemsArray = File.ReadAllLines(@path);
            for(int i = 1; i < itemsArray.Length; i++)
            {
                string[] itemsValues = itemsArray[i].Split(';');
                Items item = new Items();
                item.Id = int.Parse(itemsValues[0]);
                item.Category = itemsValues[1];
                item.Name = itemsValues[2];
                item.Price = double.Parse(itemsValues[3]);
                itemsList.Add(item);
            }
        }

        public void LoadOrders(string path)
        {
            string[] ordersArray = File.ReadAllLines(path);
            for(int i = 1; i < ordersArray.Length; i++)
            {
                string[] ordersValues = ordersArray[i].Split(';');
                Orders order = new Orders();
                order.Id = ordersValues[0];
                order.User = ordersValues[1];
                order.Item = ordersValues[2];
                order.Quantity = int.Parse(ordersValues[3]);
                order.Total = double.Parse(ordersValues[4]);
                order.Deliverer = ordersValues[5];
                order.DateTime = ordersValues[6];
                ordersList.Add(order);
            }
        }
    }
}
