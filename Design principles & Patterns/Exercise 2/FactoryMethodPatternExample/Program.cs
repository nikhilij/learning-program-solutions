using System;

namespace FactoryMethodPatternExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Testing Factory Method Pattern Implementation ===\n");

            DocumentFactory wordFactory = new WordDocumentFactory();
            DocumentFactory pdfFactory = new PdfDocumentFactory();
            DocumentFactory excelFactory = new ExcelDocumentFactory();

            Console.WriteLine("=== Creating Documents using Factory Method ===");

            Console.WriteLine("\n1. Creating Word Document:");
            IDocument wordDoc = wordFactory.CreateDocument();
            wordDoc.Save();
            wordDoc.Close();

            Console.WriteLine("\n2. Creating PDF Document:");
            IDocument pdfDoc = pdfFactory.CreateDocument();
            pdfDoc.Save();
            pdfDoc.Close();

            Console.WriteLine("\n3. Creating Excel Document:");
            IDocument excelDoc = excelFactory.CreateDocument();
            excelDoc.Save();
            excelDoc.Close();

            Console.WriteLine("\n=== Testing Template Method with Factory ===");

            Console.WriteLine("\n4. Using template method for Word document:");
            IDocument wordDoc2 = wordFactory.CreateAndSetupDocument("Report.docx");
            wordDoc2.Save();
            wordDoc2.Close();

            Console.WriteLine("\n5. Using template method for PDF document:");
            IDocument pdfDoc2 = pdfFactory.CreateAndSetupDocument("Manual.pdf");
            pdfDoc2.Save();
            pdfDoc2.Close();

            Console.WriteLine("\n=== Testing Document-Specific Features ===");            Console.WriteLine("\n6. Testing Word-specific features:");
            var wordSpecificFactory = new WordDocumentFactory();
            WordDocument wordSpecific = wordSpecificFactory.CreateWordDocument("Contract.docx");
            wordSpecific.Open();
            wordSpecific.SpellCheck();
            wordSpecific.EnableTrackChanges();
            wordSpecific.Close();

            Console.WriteLine("\n7. Testing PDF-specific features:");
            var pdfSpecificFactory = new PdfDocumentFactory();
            PdfDocument pdfSpecific = pdfSpecificFactory.CreatePdfDocument("SecureDoc.pdf");
            pdfSpecific.Open();
            pdfSpecific.SetPasswordProtection("password123");
            pdfSpecific.Compress();
            pdfSpecific.AddDigitalSignature();
            pdfSpecific.Close();

            Console.WriteLine("\n8. Testing Excel-specific features:");
            var excelSpecificFactory = new ExcelDocumentFactory();
            ExcelDocument excelSpecific = excelSpecificFactory.CreateExcelDocument("Budget.xlsx");
            excelSpecific.Open();
            excelSpecific.AddFormula("A1", "=SUM(B1:B10)");
            excelSpecific.CreateChart("Bar Chart");
            excelSpecific.CreatePivotTable();
            excelSpecific.Close();

            Console.WriteLine("\n=== Factory Information ===");
            Console.WriteLine($"Word Factory Type: {wordFactory.GetFactoryType()}");
            Console.WriteLine($"PDF Factory Type: {pdfFactory.GetFactoryType()}");
            Console.WriteLine($"Excel Factory Type: {excelFactory.GetFactoryType()}");

            Console.WriteLine("\n=== Factory Method Pattern Test Completed ===");
            Console.WriteLine("Result: Successfully demonstrated Factory Method Pattern with different document types!");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
