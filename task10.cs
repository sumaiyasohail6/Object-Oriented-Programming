using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK1_TASKS
{
    internal class task10
    {
        static void pizza_points(int minOrders, int minPrice)
        {
            StreamReader sr = new StreamReader("Customers.txt");

            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split(' ');

                string name = parts[0];
                int orders = int.Parse(parts[1]);

                string prices = line.Substring(line.IndexOf('[') + 1);
                prices = prices.Replace("]", "");

                string[] priceList = prices.Split(',');

                int count = 0;

                for (int i = 0; i < priceList.Length; i++)
                {
                    int price = int.Parse(priceList[i]);

                    if (price >= minPrice)
                    {
                        count++;
                    }
                }

                if (count >= minOrders)
                {
                    Console.WriteLine(name);
                }
            }

            sr.Close();
        }

        static void Main()
        {
            pizza_points(5, 20);
        }
    }
}
