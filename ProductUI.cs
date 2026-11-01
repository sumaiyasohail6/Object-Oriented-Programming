using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Product
{
    internal class ProductUI
    {
         ProductService service=new ProductService();
        public void ProductDriver()
        {
            while(true)
            {
                Console.Clear();
                string option = ProductMenu();
                if (option == "1")
                {
                    ProductModel product = TakeInput();
                    service.SaveProduct(product);
                }
                else if (option == "2")
                {
                 UpdateProduct();
                }
                else if (option == "3")
                {
                    DeleteProduct();
                }
                else if (option == "4")
                {
                    DisplayAll();
                }
                else if (option == "5")
                {
                    break;
                }
                else { Console.WriteLine("Wrong Option Selected"); }
            }

        }
        public void DeleteProduct()
        {
            Console.WriteLine("Enter product name");
            string name = Console.ReadLine();
          

            service.DeleteProducts(name);
        }

        public void UpdateProduct()
        {
            Console.WriteLine("Enter product name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter product price");
            float price=float.Parse(Console.ReadLine());

            service.UpdateProductPrice(name, price);
        }
        public void DisplayAll()
        {
            foreach (ProductModel p in service.GetAllData())
            {
             Console.WriteLine(p.ToString());
            }
            Console.ReadKey();
        }

        public ProductModel TakeInput()
        {
            Console.WriteLine("Enter Product Name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter product description");
            string description=Console.ReadLine();
            Console.WriteLine("Enter purchase price");
            float purchase_price=float.Parse (Console.ReadLine());
            Console.WriteLine("Enter sale price");
            float sale_price=float.Parse (Console.ReadLine());
            Console.WriteLine("Enter discount");
            float discount=float.Parse (Console.ReadLine());
            Console.Write("Enter Stock");
            int stock=int.Parse(Console.ReadLine());
            ProductModel product=new ProductModel(name,description,purchase_price,sale_price,discount,stock);
            return product;
        }
        public string ProductMenu()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("        Product Management        ");
            Console.WriteLine("----------------------------------");
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

