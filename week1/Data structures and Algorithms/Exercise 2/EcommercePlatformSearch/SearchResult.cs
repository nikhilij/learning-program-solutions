using System;

namespace EcommercePlatformSearch
{
    public class SearchResult
    {
        public bool Found { get; set; }
        public int Index { get; set; }
        public Product? Product { get; set; }
        public int Comparisons { get; set; }
        public double ElapsedMicroseconds { get; set; }
        public string Algorithm { get; set; } = string.Empty;

        public void DisplayResult()
        {
            Console.WriteLine($"Algorithm: {Algorithm}");
            Console.WriteLine($"Found: {Found}");
            if (Found && Product != null)
            {
                Console.WriteLine($"Product: {Product}");
                Console.WriteLine($"Index: {Index}");
            }
            Console.WriteLine($"Comparisons: {Comparisons}");
            Console.WriteLine($"Time: {ElapsedMicroseconds:F2} microseconds");
            Console.WriteLine();
        }
    }
}
