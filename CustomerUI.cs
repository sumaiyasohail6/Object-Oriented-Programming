using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Customer
{
    internal class CustomerUI
    {
        

            CustomerService service = new CustomerService();

            public void CustomerMenu()
            {
                while (true)
                {
                    Console.Clear();
                    string option = CustomerMenuOptions();

                    if (option == "1")
                    {
                        CustomerModel customer = TakeInput();
                        service.SaveCustomer(customer);
                    }
                    else if (option == "2")
                    {
                        UpdateCustomer();
                    }
                    else if (option == "3")
                    {
                        DeleteCustomer();
                    }
                    else if (option == "4")
                    {
                        DisplayAll();
                    }
                    else if (option == "5")
                    {
                        break;
                    }
                }
            }

            public CustomerModel TakeInput()
            {
                Console.Write("Enter Customer Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Customer Phone: ");
                string phone = Console.ReadLine();

                Console.Write("Enter Customer Address: ");
                string address = Console.ReadLine();

                CustomerModel customer =
                    new CustomerModel(name, phone);

                return customer;
            }

            public void UpdateCustomer()
            {
                Console.Write("Enter Customer Phone: ");
                string phone = Console.ReadLine();

                Console.Write("Enter New Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter New Address: ");
                string address = Console.ReadLine();

                service.UpdateCustomer(phone, name);
            }

            public void DeleteCustomer()
            {
                Console.Write("Enter Customer Phone: ");
                string phone = Console.ReadLine();

                service.DeleteCustomer(phone);
            }

            public void DisplayAll()
            {
                foreach (CustomerModel c in service.GetAllCustomers())
                {
                    Console.WriteLine(c.ToString());
                }

                Console.ReadKey();
            }

            public string CustomerMenuOptions()
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("       Customer Management");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1 Add");
                Console.WriteLine("2 Update");
                Console.WriteLine("3 Delete");
                Console.WriteLine("4 View All");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("5 Back");
                Console.ForegroundColor = ConsoleColor.White;

                string option = Console.ReadLine();
                return option;
            }
        }
    }




        
