using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Customer
{
    internal class CustomerRepo
    {
        private string file = "customers.txt";

        public void SaveInFile(CustomerModel customer)
        {
            using (StreamWriter stream = new StreamWriter(file, true))
            {
                stream.WriteLine(customer.ToString());
            }
        }

        public void SaveAllInFile(List<CustomerModel> customerList)
        {
            using (StreamWriter stream = new StreamWriter(file, false))
            {
                foreach (CustomerModel customer in customerList)
                {
                    stream.WriteLine(customer.ToString());
                }
            }
        }

        public List<CustomerModel> GetCustomersFromFile()
        {
            List<CustomerModel> customerList = new List<CustomerModel>();

            if (!File.Exists(file))
            {
                return customerList;
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
                    string name = parts[0];
                    string phone = parts[1];

                    CustomerModel customer = new CustomerModel(name, phone);
                    customerList.Add(customer);
                }
            }
            return customerList;
        }
    }
}
    
