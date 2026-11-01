using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Product
{
    internal class ProductModel
    {
        private string name;
        private string description;
        private float purchase_price;
        private float Sale_price;
        private float discount;
        private int stock;

        public ProductModel(string name, string description, float purchase_price, float sale_price, float discount,int stock)
        {
            this.name = name;
            this.description = description;
            this.purchase_price = purchase_price;
            Sale_price = sale_price;
            this.discount = discount;
            this.stock = stock;
        }
        public void SetName(string name)
        {  this.name = name; }
        public string GetName() { return this.name; }
        public void SetDescription(string description) { this.description = description; }
        public string GetDescription() { return this.description; }
        public void SetPurchasePrice(float price) { this.purchase_price = price; }
        public float GetPurchasePrice() { return this.purchase_price; }
        public void SetSalePrice(float price) {this.Sale_price = price;  }
        public float GetSalePrice() {return this.Sale_price - discount; }
        public int GetStock() { return this.stock; }
        public void Setstock(int stock) { this.stock = stock; }
        public float GetDiscount() { return this.discount;}
        public override string ToString()
        {
                return $"{name},{description},{purchase_price},{Sale_price},{discount}";
        }
    }
}
