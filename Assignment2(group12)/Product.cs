using System;

namespace Assignment2_group12
{
   public class Product
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public int Stock { get; set; }

            public Product(int productId, string productName, decimal price, int stock)
            {
                ProductID = productId;
                ProductName = productName;
                Price = price;
                Stock = stock;
            }

            public void IncreaseStock(int amount)
            {
                Stock += amount;
            }

            public void DecreaseStock(int amount)
            {
                if (Stock - amount < 0)
                {
                    throw new InvalidOperationException("Insufficient stock.");
                }
                Stock -= amount;
            }
        }
    }


