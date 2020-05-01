using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
     class Bill
    {
        List<Product> Products;
        public Bill()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public int TotalPrice()
        {
            return Products.Sum(p => p.GetPrice());
        }

        public int TotalCalo()
        {
            return Products.Sum(c => c.GetCalo());
        }
        public void ShowDescription()
        {
            foreach (var product in Products)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}
