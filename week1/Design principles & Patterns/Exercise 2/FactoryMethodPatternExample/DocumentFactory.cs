using System;

namespace FactoryMethodPatternExample
{
    public abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument();
        public abstract IDocument CreateDocument(string fileName);

        public IDocument CreateAndSetupDocument(string? fileName = null)
        {
            IDocument document = string.IsNullOrEmpty(fileName) ? CreateDocument() : CreateDocument(fileName);
            Console.WriteLine($"Created {document.GetDocumentType()} using Factory Method Pattern");
            document.Open();
            return document;
        }

        public abstract string GetFactoryType();
    }
}
