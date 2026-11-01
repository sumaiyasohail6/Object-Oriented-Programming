using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Customer
{
    internal class CustomerModel
    
        {
            private string name;
            private string phone;

            public CustomerModel()
            {
            }

            public CustomerModel(string name, string phone)
            {
                this.name = name;
                this.phone = phone;
            }

            public void SetName(string name)
            {
                this.name = name;
            }

            public string GetName()
            {
                return this.name;
            }

            public void SetPhone(string phone)
            {
                this.phone = phone;
            }

            public string GetPhone()
            {
                return this.phone;
            }

            public override string ToString()
            {
                return $"{name},{phone}";
            }
        }
    }

