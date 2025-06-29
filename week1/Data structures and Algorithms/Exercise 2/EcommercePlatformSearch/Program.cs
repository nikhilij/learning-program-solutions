using System;

namespace EcommercePlatformSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== E-commerce Platform Search Function Analysis ===\n");

            Console.WriteLine("=== Understanding Asymptotic Notation ===");
            Console.WriteLine("Big O Notation Analysis:");
            Console.WriteLine("- Linear Search: O(n) - searches through each element sequentially");
            Console.WriteLine("- Binary Search: O(log n) - divides search space in half each iteration");
            Console.WriteLine();
            Console.WriteLine("Search Operation Scenarios:");
            Console.WriteLine("Linear Search:");
            Console.WriteLine("  Best Case: O(1) - target is first element");
            Console.WriteLine("  Average Case: O(n/2) - target is in middle");
            Console.WriteLine("  Worst Case: O(n) - target is last element or not found");
            Console.WriteLine();
            Console.WriteLine("Binary Search:");
            Console.WriteLine("  Best Case: O(1) - target is middle element");
            Console.WriteLine("  Average Case: O(log n) - consistent logarithmic performance");
            Console.WriteLine("  Worst Case: O(log n) - target is at leaf level or not found");
            Console.WriteLine("\n" + new string('=', 60) + "\n");

            var products = ProductDataGenerator.GenerateUniqueProducts(1000);
            var sortedProducts = SearchAlgorithms.SortProductsById(products);

            Console.WriteLine($"Generated {products.Length} products for testing\n");

            Console.WriteLine("=== Sample Products ===");
            for (int i = 0; i < Math.Min(5, products.Length); i++)
            {
                Console.WriteLine($"{i + 1}. {products[i]}");
            }
            Console.WriteLine("...\n");

            int targetId = 1500;
            Console.WriteLine($"Searching for Product ID: {targetId}\n");

            Console.WriteLine("=== Linear Search Test ===");
            var linearResult = SearchAlgorithms.LinearSearch(products, targetId);
            linearResult.DisplayResult();

            Console.WriteLine("=== Binary Search Test ===");
            var binaryResult = SearchAlgorithms.BinarySearch(sortedProducts, targetId);
            binaryResult.DisplayResult();

            Console.WriteLine("=== Performance Comparison ===");
            Console.WriteLine($"Linear Search - Comparisons: {linearResult.Comparisons}, Time: {linearResult.ElapsedMicroseconds:F2} μs");
            Console.WriteLine($"Binary Search - Comparisons: {binaryResult.Comparisons}, Time: {binaryResult.ElapsedMicroseconds:F2} μs");
            
            if (linearResult.Comparisons > binaryResult.Comparisons)
            {
                double improvement = (double)linearResult.Comparisons / binaryResult.Comparisons;
                Console.WriteLine($"Binary search is {improvement:F1}x more efficient in comparisons");
            }
            Console.WriteLine();

            Console.WriteLine("=== Testing Different Dataset Sizes ===");
            TestPerformanceAtScale();

            Console.WriteLine("=== Algorithm Suitability Analysis ===");
            Console.WriteLine("For E-commerce Platform:");
            Console.WriteLine("✓ Binary Search is MORE suitable because:");
            Console.WriteLine("  - O(log n) vs O(n) time complexity");
            Console.WriteLine("  - Significantly fewer comparisons for large datasets");
            Console.WriteLine("  - Consistent performance even with millions of products");
            Console.WriteLine("  - Requirement: Products must be sorted by search key");
            Console.WriteLine();
            Console.WriteLine("✓ Linear Search is suitable when:");
            Console.WriteLine("  - Data is unsorted and sorting cost is high");
            Console.WriteLine("  - Small datasets (< 100 items)");
            Console.WriteLine("  - Searching by non-indexed attributes");
            Console.WriteLine("  - Memory-constrained environments");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        private static void TestPerformanceAtScale()
        {
            int[] sizes = { 100, 1000, 10000 };
            
            Console.WriteLine($"{"Size",-8} {"Linear Comparisons",-18} {"Binary Comparisons",-18} {"Efficiency Ratio",-15}");
            Console.WriteLine(new string('-', 65));

            foreach (int size in sizes)
            {
                var testProducts = ProductDataGenerator.GenerateUniqueProducts(size);
                var testSorted = SearchAlgorithms.SortProductsById(testProducts);
                
                int targetId = 1000 + size / 2;
                
                var linearResult = SearchAlgorithms.LinearSearch(testProducts, targetId);
                var binaryResult = SearchAlgorithms.BinarySearch(testSorted, targetId);
                
                double ratio = (double)linearResult.Comparisons / binaryResult.Comparisons;
                
                Console.WriteLine($"{size,-8} {linearResult.Comparisons,-18} {binaryResult.Comparisons,-18} {ratio,-15:F1}x");
            }
            Console.WriteLine();
        }
    }
}
