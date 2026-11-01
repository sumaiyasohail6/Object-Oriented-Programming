using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Order
{
        internal class OrderUI
        {
            OrderService service = new OrderService();

            public void OrderMenu()
            {
                while (true)
                {
                    Console.Clear();
                    string option = OrderMenuOptions();

                    if (option == "1")
                    {
                        PlaceOrder();
                    }
                    else if (option == "2")
                    {
                        DisplayAll();
                    }
                    else if (option == "3")
                    {
                        SearchOrder();
                    }
                    else if (option == "4")
                    {
                        break;
                    }
                }
            }

            public void PlaceOrder()
            {
                Console.Write("Enter Customer Phone: ");
                string phone = Console.ReadLine();

            Console.Write("Enter Product Name: ");
            string productName = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            service.PlaceOrder(phone, productName, quantity);
        }
        

            public void DisplayAll()
            {
                // Call your existing order display service method here.
            }

            public void SearchOrder()
            {
                Console.Write("Enter Customer Phone: ");
                string phone = Console.ReadLine();

                // Call your existing order search service method here.
            }

            public string OrderMenuOptions()
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("         Order Management");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1 Place Order");
                Console.WriteLine("2 View All Orders");
                Console.WriteLine("3 Search Order");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("4 Back");
                Console.ForegroundColor = ConsoleColor.White;

                string option = Console.ReadLine();
                return option;
            }
        }
    }


