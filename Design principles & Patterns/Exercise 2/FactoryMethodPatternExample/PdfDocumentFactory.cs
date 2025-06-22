using System;

namespace FactoryMethodPatternExample
{
    public class PdfDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new PdfDocument();
        }

        public override IDocument CreateDocument(string fileName)
        {
            return new PdfDocument(fileName);
        }        public override string GetFactoryType()
        {
            return "PDF Document Factory";
        }

        public PdfDocument CreatePdfDocument(string fileName)
        {
            return new PdfDocument(fileName);
        }
    }
}
