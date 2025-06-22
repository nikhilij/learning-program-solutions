using System;

namespace FinancialForecasting
{
    public class FinancialScenario
    {
        public string Name { get; set; } = string.Empty;
        public double InitialValue { get; set; }
        public double GrowthRate { get; set; }
        public int Periods { get; set; }
        public double[] PastValues { get; set; } = Array.Empty<double>();
        public double[] VariableGrowthRates { get; set; } = Array.Empty<double>();

        public void DisplayScenario()
        {
            Console.WriteLine($"Scenario: {Name}");
            Console.WriteLine($"Initial Value: ${InitialValue:F2}");
            
            if (GrowthRate != 0)
                Console.WriteLine($"Growth Rate: {GrowthRate:P2}");
            
            Console.WriteLine($"Forecast Periods: {Periods}");
            
            if (PastValues.Length > 0)
            {
                Console.WriteLine($"Historical Data: [{string.Join(", ", Array.ConvertAll(PastValues, x => $"${x:F0}"))}]");
            }
            
            if (VariableGrowthRates.Length > 0)
            {
                Console.WriteLine($"Variable Growth Rates: [{string.Join(", ", Array.ConvertAll(VariableGrowthRates, x => $"{x:P1}"))}]");
            }
            
            Console.WriteLine();
        }
    }
}
