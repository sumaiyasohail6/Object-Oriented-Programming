using OOP_Project.Order;
using OOP_Project.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Customer
{
    internal class shop
    {
      // class for driver code
      public void start()
        {
            while (true)
            {
                Console.Clear();
                string option = MainMenu();
                if(option =="1")
                {
                    ProductUI productUI = new ProductUI();
                    productUI.ProductDriver();
                }
                else if (option=="2")
                {
                    CustomerUI customerUI = new CustomerUI();
                    customerUI.CustomerMenu();
                }
                else if (option=="3")
                {
                    OrderUI orderUI = new OrderUI();
                    orderUI.OrderMenu();
                }
                else if (option=="4")
                {
                    break;
                }
            }
        }
      public string MainMenu()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("-------------POS------------------");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1 to Product Management");
            Console.WriteLine("2 to Customer Management");
            Console.WriteLine("3 to Order Management");
           
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("4 Exit");
            Console.ForegroundColor=ConsoleColor.White;
            string option=Console.ReadLine();
            return option;
        }


    }
}
