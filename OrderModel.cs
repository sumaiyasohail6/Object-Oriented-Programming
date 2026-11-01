using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Order
{
    internal class OrderModel
    {
        private int id;
        private string customerName;
        private string customerPhone;
        private string productName;
        private int quantity;
        private float total;

        public OrderModel()
        {
        }

        public OrderModel(int id, string customerName, string customerPhone, string productName, int quantity, float total)
        {
            this.id = id;
            this.customerName = customerName;
            this.customerPhone = customerPhone;
            this.productName = productName;
            this.quantity = quantity;
            this.total = total;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return this.id;
        }

        public void SetCustomerName(string customerName)
        {
            this.customerName = customerName;
        }

        public string GetCustomerName()
        {
            return this.customerName;
        }

        public void SetCustomerPhone(string customerPhone)
        {
            this.customerPhone = customerPhone;
        }

        public string GetCustomerPhone()
        {
            return this.customerPhone;
        }

        public void SetProductName(string productName)
        {
            this.productName = productName;
        }

        public string GetProductName()
        {
            return this.productName;
        }

        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public int GetQuantity()
        {
            return this.quantity;
        }

        public void SetTotal(float total)
        {
            this.total = total;
        }

        public float GetTotal()
        {
            return this.total;
        }

        public override string ToString()
        {
            return $"{id},{customerName},{customerPhone},{productName},{quantity},{total}";
        }
    }
}
