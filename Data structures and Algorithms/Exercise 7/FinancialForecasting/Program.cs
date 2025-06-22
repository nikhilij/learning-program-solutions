using System;

namespace FinancialForecasting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Financial Forecasting Tool ===\n");

            Console.WriteLine("=== Understanding Recursive Algorithms ===");
            Console.WriteLine("Recursion Concept:");
            Console.WriteLine("- A method that calls itself with modified parameters");
            Console.WriteLine("- Breaks complex problems into smaller, similar subproblems");
            Console.WriteLine("- Requires a base case to prevent infinite recursion");
            Console.WriteLine("- Particularly useful for problems with recursive nature like compound growth");
            Console.WriteLine();
            Console.WriteLine("How Recursion Simplifies Financial Forecasting:");
            Console.WriteLine("- Future Value = Present Value × (1 + Growth Rate)");
            Console.WriteLine("- Each period builds upon the previous period's result");
            Console.WriteLine("- Natural recursive relationship: FV(n) = FV(n-1) × (1 + r)");
            Console.WriteLine("\n" + new string('=', 60) + "\n");

            DemonstrateBasicRecursion();
            DemonstratePerformanceComparison();
            DemonstrateOptimization();
            DemonstrateRealWorldScenarios();
            AnalyzeTimeComplexity();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void DemonstrateBasicRecursion()
        {
            Console.WriteLine("=== Basic Recursive Future Value Calculation ===");
            
            var scenario = new FinancialScenario
            {
                Name = "Investment Growth",
                InitialValue = 10000,
                GrowthRate = 0.08,
                Periods = 5
            };
            
            scenario.DisplayScenario();
            
            double result = FinancialForecaster.CalculateFutureValueRecursive(
                scenario.InitialValue, scenario.GrowthRate, scenario.Periods);
            
            Console.WriteLine($"Future Value after {scenario.Periods} periods: ${result:F2}");
            Console.WriteLine();
        }

        private static void DemonstratePerformanceComparison()
        {
            Console.WriteLine("=== Algorithm Performance Comparison ===");
            
            double presentValue = 50000;
            double growthRate = 0.12;
            int periods = 10;
            
            Console.WriteLine($"Calculating future value: ${presentValue:F0} at {growthRate:P0} for {periods} periods\n");
            
            var recursiveMetrics = FinancialForecaster.MeasurePerformance(
                () => FinancialForecaster.CalculateFutureValueRecursive(presentValue, growthRate, periods),
                "Recursive Algorithm");
            recursiveMetrics.DisplayMetrics();
            
            var iterativeMetrics = FinancialForecaster.MeasurePerformance(
                () => FinancialForecaster.CalculateFutureValueIterative(presentValue, growthRate, periods),
                "Iterative Algorithm");
            iterativeMetrics.DisplayMetrics();
            
            var formulaMetrics = FinancialForecaster.MeasurePerformance(
                () => FinancialForecaster.CalculateFutureValueFormula(presentValue, growthRate, periods),
                "Mathematical Formula");
            formulaMetrics.DisplayMetrics();
            
            Console.WriteLine($"All methods produce the same result: ${recursiveMetrics.Result:F2}\n");
        }

        private static void DemonstrateOptimization()
        {
            Console.WriteLine("=== Optimization: Memoization Example ===");
            
            double presentValue = 25000;
            double growthRate = 0.10;
            int periods = 15;
            
            Console.WriteLine($"Calculating with larger dataset: ${presentValue:F0} at {growthRate:P0} for {periods} periods\n");
            
            var recursiveMetrics = FinancialForecaster.MeasurePerformance(
                () => FinancialForecaster.CalculateFutureValueRecursive(presentValue, growthRate, periods),
                "Standard Recursive");
            recursiveMetrics.DisplayMetrics();
            
            var memoizedMetrics = FinancialForecaster.MeasurePerformance(
                () => FinancialForecaster.CalculateFutureValueMemoized(presentValue, growthRate, periods),
                "Memoized Recursive");
            memoizedMetrics.DisplayMetrics();
            
            Console.WriteLine("Memoization Benefits:");
            Console.WriteLine("- Stores previously calculated results");
            Console.WriteLine("- Eliminates redundant calculations");
            Console.WriteLine("- Trades memory for speed");
            Console.WriteLine("- Particularly effective for overlapping subproblems\n");
        }

        private static void DemonstrateRealWorldScenarios()
        {
            Console.WriteLine("=== Real-World Financial Scenarios ===");
            
            Console.WriteLine("Scenario 1: Portfolio Growth Based on Historical Data");
            var historicalData = new double[] { 100000, 108000, 115000, 125000, 135000 };
            var portfolioScenario = new FinancialScenario
            {
                Name = "Portfolio Forecast",
                PastValues = historicalData,
                Periods = 3
            };
            portfolioScenario.DisplayScenario();
            
            double portfolioForecast = FinancialForecaster.CalculateCompoundGrowthRecursive(
                historicalData, portfolioScenario.Periods);
            Console.WriteLine($"Projected Portfolio Value: ${portfolioForecast:F2}\n");
            
            Console.WriteLine("Scenario 2: Variable Growth Rates");
            var variableGrowthRates = new double[] { 0.12, 0.08, 0.15, 0.06, 0.10 };
            var variableScenario = new FinancialScenario
            {
                Name = "Variable Growth Investment",
                InitialValue = 75000,
                VariableGrowthRates = variableGrowthRates
            };
            variableScenario.DisplayScenario();
            
            double variableForecast = FinancialForecaster.CalculateVariableGrowthRecursive(
                variableScenario.InitialValue, variableGrowthRates, 0);
            Console.WriteLine($"Final Value with Variable Growth: ${variableForecast:F2}\n");
        }

        private static void AnalyzeTimeComplexity()
        {
            Console.WriteLine("=== Time Complexity Analysis ===");
            Console.WriteLine("Recursive Algorithm Complexity:");
            Console.WriteLine("- Time Complexity: O(n) where n is the number of periods");
            Console.WriteLine("- Space Complexity: O(n) due to call stack");
            Console.WriteLine("- Each recursive call processes one period");
            Console.WriteLine();
            
            Console.WriteLine("Optimization Strategies:");
            Console.WriteLine("1. Memoization:");
            Console.WriteLine("   - Eliminates redundant calculations");
            Console.WriteLine("   - Time: O(n), Space: O(n) for cache");
            Console.WriteLine();
            Console.WriteLine("2. Iterative Approach:");
            Console.WriteLine("   - Time: O(n), Space: O(1)");
            Console.WriteLine("   - No function call overhead");
            Console.WriteLine();
            Console.WriteLine("3. Mathematical Formula:");
            Console.WriteLine("   - Time: O(1), Space: O(1)");
            Console.WriteLine("   - Direct calculation using Math.Pow()");
            Console.WriteLine("   - Most efficient for simple compound growth");
            Console.WriteLine();
            
            Console.WriteLine("When to Use Recursive Approach:");
            Console.WriteLine("✓ Complex growth patterns (variable rates)");
            Console.WriteLine("✓ Decision trees in financial modeling");
            Console.WriteLine("✓ Monte Carlo simulations");
            Console.WriteLine("✓ When problem has natural recursive structure");
            Console.WriteLine();
            
            Console.WriteLine("When to Avoid Recursion:");
            Console.WriteLine("✗ Simple linear calculations");
            Console.WriteLine("✗ Very large datasets (stack overflow risk)");
            Console.WriteLine("✗ Performance-critical applications");
            Console.WriteLine("✗ When iterative solution is simpler");
        }
    }
}
