using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCollectionSample
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }

        public IList<Product> GetProductList()
        {
            IList<Product> products = new List<Product>()
            {
                new Product()
                {
                       ProductId = 1,
                       ProductName = "Milk",
                       CategoryName = "Drink",
                       Price = 30
                },

                new Product()
                {
                       ProductId = 2,
                       ProductName = "Apple",
                       CategoryName = "Fruit",
                       Price = 10
                },

                new Product()
                {
                       ProductId = 3,
                       ProductName = "Watermelon",
                       CategoryName = "Fruit",
                       Price = 80
                },

                new Product()
                {
                       ProductId = 4,
                       ProductName = "Chocolate",
                       CategoryName = "Junk Food",
                       Price = 20
                }
            };
            return products;
        }
    }
}
