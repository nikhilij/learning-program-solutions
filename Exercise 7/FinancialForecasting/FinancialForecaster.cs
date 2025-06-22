using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace FinancialForecasting
{
    public static class FinancialForecaster
    {
        private static Dictionary<string, double> _memoCache = new Dictionary<string, double>();
        private static int _recursiveCallCount = 0;
        private static int _memoizedCallCount = 0;

        public static double CalculateFutureValueRecursive(double presentValue, double growthRate, int periods)
        {
            _recursiveCallCount++;
            
            if (periods == 0)
            {
                return presentValue;
            }
            
            return CalculateFutureValueRecursive(presentValue * (1 + growthRate), growthRate, periods - 1);
        }

        public static double CalculateFutureValueMemoized(double presentValue, double growthRate, int periods)
        {
            _memoizedCallCount++;
            
            string key = $"{presentValue}_{growthRate}_{periods}";
            
            if (_memoCache.ContainsKey(key))
            {
                return _memoCache[key];
            }
            
            if (periods == 0)
            {
                _memoCache[key] = presentValue;
                return presentValue;
            }
            
            double result = CalculateFutureValueMemoized(presentValue * (1 + growthRate), growthRate, periods - 1);
            _memoCache[key] = result;
            return result;
        }

        public static double CalculateFutureValueIterative(double presentValue, double growthRate, int periods)
        {
            double result = presentValue;
            for (int i = 0; i < periods; i++)
            {
                result *= (1 + growthRate);
            }
            return result;
        }

        public static double CalculateFutureValueFormula(double presentValue, double growthRate, int periods)
        {
            return presentValue * Math.Pow(1 + growthRate, periods);
        }

        public static double CalculateCompoundGrowthRecursive(double[] pastValues, int periods)
        {
            if (pastValues.Length < 2)
                throw new ArgumentException("Need at least 2 data points for growth calculation");

            double averageGrowthRate = CalculateAverageGrowthRate(pastValues);
            double latestValue = pastValues[pastValues.Length - 1];
            
            return CalculateFutureValueRecursive(latestValue, averageGrowthRate, periods);
        }

        public static double CalculateVariableGrowthRecursive(double presentValue, double[] growthRates, int periodIndex)
        {
            if (periodIndex >= growthRates.Length)
            {
                return presentValue;
            }
            
            double newValue = presentValue * (1 + growthRates[periodIndex]);
            return CalculateVariableGrowthRecursive(newValue, growthRates, periodIndex + 1);
        }

        private static double CalculateAverageGrowthRate(double[] values)
        {
            double totalGrowthRate = 0;
            int growthPeriods = 0;
            
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i - 1] != 0)
                {
                    double growthRate = (values[i] - values[i - 1]) / values[i - 1];
                    totalGrowthRate += growthRate;
                    growthPeriods++;
                }
            }
            
            return growthPeriods > 0 ? totalGrowthRate / growthPeriods : 0;
        }

        public static PerformanceMetrics MeasurePerformance(Func<double> algorithm, string algorithmName)
        {
            ResetCounters();
            
            var stopwatch = Stopwatch.StartNew();
            double result = algorithm();
            stopwatch.Stop();
            
            return new PerformanceMetrics
            {
                AlgorithmName = algorithmName,
                Result = result,
                ExecutionTime = stopwatch.Elapsed.TotalMilliseconds,
                RecursiveCalls = _recursiveCallCount,
                MemoizedCalls = _memoizedCallCount,
                MemoryUsage = GC.GetTotalMemory(false)
            };
        }

        public static void ResetCounters()
        {
            _recursiveCallCount = 0;
            _memoizedCallCount = 0;
            _memoCache.Clear();
        }
    }
}
