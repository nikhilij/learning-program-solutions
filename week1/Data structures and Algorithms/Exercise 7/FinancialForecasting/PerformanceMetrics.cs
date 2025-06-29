using System;

namespace FinancialForecasting
{
    public class PerformanceMetrics
    {
        public string AlgorithmName { get; set; } = string.Empty;
        public double Result { get; set; }
        public double ExecutionTime { get; set; }
        public int RecursiveCalls { get; set; }
        public int MemoizedCalls { get; set; }
        public long MemoryUsage { get; set; }

        public void DisplayMetrics()
        {
            Console.WriteLine($"Algorithm: {AlgorithmName}");
            Console.WriteLine($"Result: ${Result:F2}");
            Console.WriteLine($"Execution Time: {ExecutionTime:F4} ms");
            if (RecursiveCalls > 0)
                Console.WriteLine($"Recursive Calls: {RecursiveCalls}");
            if (MemoizedCalls > 0)
                Console.WriteLine($"Memoized Calls: {MemoizedCalls}");
            Console.WriteLine($"Memory Usage: {MemoryUsage:N0} bytes");
            Console.WriteLine();
        }
    }
}
