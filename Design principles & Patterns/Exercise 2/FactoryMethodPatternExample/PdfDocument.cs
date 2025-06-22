using System;

namespace FactoryMethodPatternExample
{
    public class PdfDocument : IDocument
    {
        public string FileName { get; set; }

        public PdfDocument()
        {
            FileName = "Untitled.pdf";
        }

        public PdfDocument(string fileName)
        {
            FileName = fileName ?? "Untitled.pdf";
        }

        public void Open()
        {
            Console.WriteLine($"Opening PDF document: {FileName}");
        }

        public void Close()
        {
            Console.WriteLine($"Closing PDF document: {FileName}");
        }

        public void Save()
        {
            Console.WriteLine($"Saving PDF document: {FileName}");
        }

        public string GetDocumentType()
        {
            return "PDF Document";
        }

        public void SetPasswordProtection(string password)
        {
            Console.WriteLine($"Setting password protection for PDF document: {FileName}");
        }

        public void Compress()
        {
            Console.WriteLine($"Compressing PDF document: {FileName}");
        }

        public void AddDigitalSignature()
        {
            Console.WriteLine($"Adding digital signature to PDF document: {FileName}");
        }
    }
}
