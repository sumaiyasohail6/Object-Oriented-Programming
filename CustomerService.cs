using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Customer
{
    internal class CustomerService
    {

        private CustomerRepo repo = new CustomerRepo();

        public string AddCustomer(string name, string phone)
        {
            if (name == "")
            {
                return "Name is required.";
            }

            if (phone == "")
            {
                return "Phone is required.";
            }

            List<CustomerModel> customerList = repo.GetCustomersFromFile();

            foreach (CustomerModel customer in customerList)
            {
                if (customer.GetPhone() == phone)
                {
                    return "Customer already exists.";
                }
            }

            CustomerModel newCustomer = new CustomerModel(name, phone);
            repo.SaveInFile(newCustomer);
            return "Customer added.";
        }

        public string UpdateCustomer(string phone, string newName)
        {
            if (newName == "")
            {
                return "Name is required.";
            }

            List<CustomerModel> customerList = repo.GetCustomersFromFile();

            foreach (CustomerModel customer in customerList)
            {
                if (customer.GetPhone() == phone)
                {
                    customer.SetName(newName);
                    repo.SaveAllInFile(customerList);
                    return "Customer updated.";
                }
            }

            return "Customer not found.";
        }

        public string DeleteCustomer(string phone)
        {
            List<CustomerModel> customerList = repo.GetCustomersFromFile();

            foreach (CustomerModel customer in customerList)
            {
                if (customer.GetPhone() == phone)
                {
                    customerList.Remove(customer);
                    repo.SaveAllInFile(customerList);
                    return "Customer deleted.";
                }
            }

            return "Customer not found.";
        }

        public List<CustomerModel> GetAllCustomers()
        {
            return repo.GetCustomersFromFile();
        }
        public void SaveCustomer (CustomerModel customer)
        {
            repo.SaveInFile(customer);
        }
    }
}

