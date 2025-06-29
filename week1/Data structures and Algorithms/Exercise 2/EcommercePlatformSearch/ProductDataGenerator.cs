using System;

namespace EcommercePlatformSearch
{
    public static class ProductDataGenerator
    {
        private static readonly string[] Categories = 
        {
            "Electronics", "Clothing", "Books", "Home", "Sports", "Beauty", "Toys", "Automotive"
        };

        private static readonly string[] ProductNames = 
        {
            "Laptop Pro", "Smartphone X", "Wireless Headphones", "Gaming Console", "Smart Watch",
            "T-Shirt", "Jeans", "Sneakers", "Jacket", "Dress",
            "Programming Guide", "Mystery Novel", "Cookbook", "Biography", "Textbook",
            "Coffee Maker", "Vacuum Cleaner", "Table Lamp", "Sofa", "Dining Set",
            "Basketball", "Tennis Racket", "Yoga Mat", "Dumbbells", "Bicycle",
            "Face Cream", "Shampoo", "Lipstick", "Perfume", "Skincare Set",
            "Action Figure", "Board Game", "Puzzle", "Remote Car", "Doll",
            "Car Battery", "Motor Oil", "Tire", "Car Cover", "GPS Navigator"
        };

        public static Product[] GenerateProducts(int count)
        {
            var products = new Product[count];
            var random = new Random(42);

            for (int i = 0; i < count; i++)
            {
                int productId = random.Next(1000, 9999);
                string productName = ProductNames[random.Next(ProductNames.Length)];
                string category = Categories[random.Next(Categories.Length)];
                decimal price = (decimal)(random.NextDouble() * 999 + 1);

                products[i] = new Product(productId, $"{productName} {i + 1}", category, price);
            }

            return products;
        }

        public static Product[] GenerateUniqueProducts(int count)
        {
            var products = new Product[count];
            var random = new Random(42);

            for (int i = 0; i < count; i++)
            {
                int productId = 1000 + i;
                string productName = ProductNames[random.Next(ProductNames.Length)];
                string category = Categories[random.Next(Categories.Length)];
                decimal price = (decimal)(random.NextDouble() * 999 + 1);

                products[i] = new Product(productId, $"{productName} {i + 1}", category, price);
            }

            return products;
        }
    }
}
