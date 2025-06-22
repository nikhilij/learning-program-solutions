using System;
using System.Diagnostics;

namespace EcommercePlatformSearch
{
    public static class SearchAlgorithms
    {
        public static SearchResult LinearSearch(Product[] products, int targetProductId)
        {
            var stopwatch = Stopwatch.StartNew();
            int comparisons = 0;

            for (int i = 0; i < products.Length; i++)
            {
                comparisons++;
                if (products[i].ProductId == targetProductId)
                {
                    stopwatch.Stop();
                    return new SearchResult
                    {
                        Found = true,
                        Index = i,
                        Product = products[i],
                        Comparisons = comparisons,
                        ElapsedMicroseconds = stopwatch.Elapsed.TotalMicroseconds,
                        Algorithm = "Linear Search"
                    };
                }
            }

            stopwatch.Stop();
            return new SearchResult
            {
                Found = false,
                Index = -1,
                Product = null,
                Comparisons = comparisons,
                ElapsedMicroseconds = stopwatch.Elapsed.TotalMicroseconds,
                Algorithm = "Linear Search"
            };
        }

        public static SearchResult LinearSearchByName(Product[] products, string targetProductName)
        {
            var stopwatch = Stopwatch.StartNew();
            int comparisons = 0;

            for (int i = 0; i < products.Length; i++)
            {
                comparisons++;
                if (string.Equals(products[i].ProductName, targetProductName, StringComparison.OrdinalIgnoreCase))
                {
                    stopwatch.Stop();
                    return new SearchResult
                    {
                        Found = true,
                        Index = i,
                        Product = products[i],
                        Comparisons = comparisons,
                        ElapsedMicroseconds = stopwatch.Elapsed.TotalMicroseconds,
                        Algorithm = "Linear Search (by Name)"
                    };
                }
            }

            stopwatch.Stop();
            return new SearchResult
            {
                Found = false,
                Index = -1,
                Product = null,
                Comparisons = comparisons,
                ElapsedMicroseconds = stopwatch.Elapsed.TotalMicroseconds,
                Algorithm = "Linear Search (by Name)"
            };
        }

        public static SearchResult BinarySearch(Product[] sortedProducts, int targetProductId)
        {
            var stopwatch = Stopwatch.StartNew();
            int comparisons = 0;
            int left = 0;
            int right = sortedProducts.Length - 1;

            while (left <= right)
            {
                comparisons++;
                int mid = left + (right - left) / 2;

                if (sortedProducts[mid].ProductId == targetProductId)
                {
                    stopwatch.Stop();
                    return new SearchResult
                    {
                        Found = true,
                        Index = mid,
                        Product = sortedProducts[mid],
                        Comparisons = comparisons,
                        ElapsedMicroseconds = stopwatch.Elapsed.TotalMicroseconds,
                        Algorithm = "Binary Search"
                    };
                }
                else if (sortedProducts[mid].ProductId < targetProductId)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            stopwatch.Stop();
            return new SearchResult
            {
                Found = false,
                Index = -1,
                Product = null,
                Comparisons = comparisons,
                ElapsedMicroseconds = stopwatch.Elapsed.TotalMicroseconds,
                Algorithm = "Binary Search"
            };
        }

        public static Product[] SortProductsById(Product[] products)
        {
            var sortedProducts = new Product[products.Length];
            Array.Copy(products, sortedProducts, products.Length);
            Array.Sort(sortedProducts, (p1, p2) => p1.ProductId.CompareTo(p2.ProductId));
            return sortedProducts;
        }
    }
}
