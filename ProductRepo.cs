using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Product
{
    internal class ProductRepo
    {
        private readonly string file = "product.txt";
        public ProductRepo() { }
        public void SaveInFile(ProductModel product)
        {
            using (StreamWriter stream = new StreamWriter(file, true))
            {
                stream.WriteLine(product.ToString());
            }
        }
        // to update any product 
        public void SaveAllDataToFile(List<ProductModel> products)
        {
            File.WriteAllText(file, string.Empty);
            foreach (ProductModel product in products)
            {
                SaveInFile(product);
            }
        }   
        //{name},{description},{purchase_price},{Sale_price},{discount}"
        public List<ProductModel> GetProductsFromFile()
        {
            List<ProductModel> productsList = new List<ProductModel>();
            using (StreamReader stream = new StreamReader(file))
            {
                string line = "";
                while ((line = stream.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string productName = parts[0];
                    string description = parts[1];
                    float purchaseprice = float.Parse(parts[2]);
                    float saleprice = float.Parse(parts[3]);
                    float discount = float.Parse(parts[4]);
                    int stock=int.Parse(parts[5]);
                    ProductModel productModel = new ProductModel(productName,description,purchaseprice,saleprice,discount,stock);
                    productsList.Add(productModel);
                }
            }
            return productsList;
        }
    }
}
