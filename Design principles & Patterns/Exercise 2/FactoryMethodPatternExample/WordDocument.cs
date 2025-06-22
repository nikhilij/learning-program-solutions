using System;

namespace FactoryMethodPatternExample
{
    public class WordDocument : IDocument
    {
        public string FileName { get; set; }

        public WordDocument()
        {
            FileName = "Untitled.docx";
        }

        public WordDocument(string fileName)
        {
            FileName = fileName ?? "Untitled.docx";
        }

        public void Open()
        {
            Console.WriteLine($"Opening Word document: {FileName}");
        }

        public void Close()
        {
            Console.WriteLine($"Closing Word document: {FileName}");
        }

        public void Save()
        {
            Console.WriteLine($"Saving Word document: {FileName}");
        }

        public string GetDocumentType()
        {
            return "Word Document";
        }

        public void SpellCheck()
        {
            Console.WriteLine($"Running spell check on Word document: {FileName}");
        }

        public void EnableTrackChanges()
        {
            Console.WriteLine($"Enabling track changes for Word document: {FileName}");
        }
    }
}
