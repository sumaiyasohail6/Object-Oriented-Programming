using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Product
{
    internal class ProductService
    {
        private ProductRepo repo;
        public ProductService()
        {
            repo = new ProductRepo();
        }
        public List<ProductModel>GetAllData()
        {
            return repo.GetProductsFromFile();
        }
        public void SaveProduct(ProductModel product)
        {
            repo.SaveInFile(product);
        }
        public ProductModel SearchbyName(string name)
        {
            foreach (ProductModel product in repo.GetProductsFromFile())
            {
                if (product.GetName() == name)
                {
                    return product;
                }
            }
            return null;
        }
        public bool UpdateProductPrice(string name, float Saleprice)
        {
            List<ProductModel> products = repo.GetProductsFromFile();
            foreach (ProductModel product in products)
            {
                if (product.GetName() == name)
                {
                    product.SetSalePrice(Saleprice);
                    repo.SaveAllDataToFile(products);
                    return true;
                }
            }
            return false;

        }
        public bool DeleteProducts(string name)
        {
            List<ProductModel> products = repo.GetProductsFromFile();
            int count = 0;
            foreach (ProductModel product in products)
            {
                if (product.GetName() == name)
                {
                    products.RemoveAt(count);
                    repo.SaveAllDataToFile(products);
                    return true;
                }
                count++;

            }
            return false;
        }
    }
}
