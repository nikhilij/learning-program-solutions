using System;

namespace EcommercePlatformSearch
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public Product(int productId, string productName, string category, decimal price)
        {
            ProductId = productId;
            ProductName = productName ?? string.Empty;
            Category = category ?? string.Empty;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID: {ProductId}, Name: {ProductName}, Category: {Category}, Price: ${Price:F2}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Product other)
            {
                return ProductId == other.ProductId;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return ProductId.GetHashCode();
        }
    }
}
