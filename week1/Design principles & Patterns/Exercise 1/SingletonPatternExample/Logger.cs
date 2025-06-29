using System;

namespace SingletonPatternExample
{
    public sealed class Logger
    {
        private static Logger? _instance;
        private static readonly object _lock = new object();

        private Logger()
        {
            Console.WriteLine("Logger instance created.");
        }

        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Logger();
                        }
                    }
                }
                return _instance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now:yyyy-MM-dd HH:mm:ss}: {message}");
        }

        public void LogError(string error)
        {
            Console.WriteLine($"[ERROR] {DateTime.Now:yyyy-MM-dd HH:mm:ss}: {error}");
        }

        public void LogWarning(string warning)
        {
            Console.WriteLine($"[WARNING] {DateTime.Now:yyyy-MM-dd HH:mm:ss}: {warning}");
        }

        public void LogDebug(string debug)
        {
            Console.WriteLine($"[DEBUG] {DateTime.Now:yyyy-MM-dd HH:mm:ss}: {debug}");
        }
    }
}
