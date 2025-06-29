using System;

namespace FactoryMethodPatternExample
{
    public class ExcelDocument : IDocument
    {
        public string FileName { get; set; }

        public ExcelDocument()
        {
            FileName = "Untitled.xlsx";
        }

        public ExcelDocument(string fileName)
        {
            FileName = fileName ?? "Untitled.xlsx";
        }

        public void Open()
        {
            Console.WriteLine($"Opening Excel document: {FileName}");
        }

        public void Close()
        {
            Console.WriteLine($"Closing Excel document: {FileName}");
        }

        public void Save()
        {
            Console.WriteLine($"Saving Excel document: {FileName}");
        }

        public string GetDocumentType()
        {
            return "Excel Document";
        }

        public void AddFormula(string cell, string formula)
        {
            Console.WriteLine($"Adding formula '{formula}' to cell {cell} in Excel document: {FileName}");
        }

        public void CreateChart(string chartType)
        {
            Console.WriteLine($"Creating {chartType} chart in Excel document: {FileName}");
        }

        public void CreatePivotTable()
        {
            Console.WriteLine($"Creating pivot table in Excel document: {FileName}");
        }
    }
}
