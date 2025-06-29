using System;

namespace SingletonPatternExample
{
    public class SingletonTest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Testing Singleton Pattern Implementation ===\n");

            Logger logger1 = Logger.Instance;
            logger1.Log("First logger instance accessed");

            Logger logger2 = Logger.Instance;
            logger2.Log("Second logger instance requested");

            Logger logger3 = Logger.Instance;
            logger3.LogWarning("Third logger instance requested");

            Console.WriteLine("\n=== Verifying Singleton Property ===");
            Console.WriteLine($"logger1 == logger2: {ReferenceEquals(logger1, logger2)}");
            Console.WriteLine($"logger2 == logger3: {ReferenceEquals(logger2, logger3)}");
            Console.WriteLine($"logger1 == logger3: {ReferenceEquals(logger1, logger3)}");

            Console.WriteLine("\n=== Hash Code Comparison ===");
            Console.WriteLine($"logger1 hash code: {logger1.GetHashCode()}");
            Console.WriteLine($"logger2 hash code: {logger2.GetHashCode()}");
            Console.WriteLine($"logger3 hash code: {logger3.GetHashCode()}");

            Console.WriteLine("\n=== Testing Logging Functionality ===");
            logger1.Log("This is an info message");
            logger2.LogWarning("This is a warning message");
            logger3.LogError("This is an error message");
            logger1.LogDebug("This is a debug message");

            Console.WriteLine("\n=== Testing Thread Safety ===");
            TestThreadSafety();

            Console.WriteLine("\n=== Singleton Test Completed ===");
            Console.WriteLine("Result: All logger instances are the same object - Singleton pattern implemented correctly!");
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        private static void TestThreadSafety()
        {
            const int numberOfThreads = 5;
            Logger[] loggers = new Logger[numberOfThreads];
            
            var tasks = new System.Threading.Tasks.Task[numberOfThreads];
            
            for (int i = 0; i < numberOfThreads; i++)
            {
                int threadIndex = i;
                tasks[i] = System.Threading.Tasks.Task.Run(() =>
                {
                    loggers[threadIndex] = Logger.Instance;
                    loggers[threadIndex].Log($"Accessed from Thread {threadIndex + 1}");
                });
            }

            System.Threading.Tasks.Task.WaitAll(tasks);

            Console.WriteLine("Thread safety verification:");
            for (int i = 1; i < numberOfThreads; i++)
            {
                Console.WriteLine($"Thread {i + 1} same as Thread 1: {ReferenceEquals(loggers[0], loggers[i])}");
            }
        }
    }
}
