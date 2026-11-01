using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Order
{
    internal class OrderRepo
    {
        private string file = "orders.txt";

        public void SaveInFile(OrderModel order)
        {
            using (StreamWriter stream = new StreamWriter(file, true))
            {
                stream.WriteLine(order.ToString());
            }
        }

        public void SaveAllInFile(List<OrderModel> orderList)
        {
            using (StreamWriter stream = new StreamWriter(file, false))
            {
                foreach (OrderModel order in orderList)
                {
                    stream.WriteLine(order.ToString());
                }
            }
        }


        public List<OrderModel> GetOrdersFromFile()
        {
            List<OrderModel> orderList = new List<OrderModel>();

            if (!File.Exists(file))
            {
                return orderList;
            }

            using (StreamReader stream = new StreamReader(file))
            {
                string line = "";
                while ((line = stream.ReadLine()) != null)
                {
                    if (line == "")
                    {
                        continue;
                    }

                    List<string> parts = new List<string>(line.Split(','));
                    int id = int.Parse(parts[0]);
                    string customerName = parts[1];
                    string customerPhone = parts[2];
                    string productName = parts[3];
                    int quantity = int.Parse(parts[4]);
                    float total = float.Parse(parts[5]);

                    OrderModel order = new OrderModel(id, customerName, customerPhone, productName, quantity, total);
                    orderList.Add(order);
                }
            }
            return orderList;
        }
    }
}
