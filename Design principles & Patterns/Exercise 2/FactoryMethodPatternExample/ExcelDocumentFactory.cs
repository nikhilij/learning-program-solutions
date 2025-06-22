using System;

namespace FactoryMethodPatternExample
{
    public class ExcelDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new ExcelDocument();
        }

        public override IDocument CreateDocument(string fileName)
        {
            return new ExcelDocument(fileName);
        }        public override string GetFactoryType()
        {
            return "Excel Document Factory";
        }

        public ExcelDocument CreateExcelDocument(string fileName)
        {
            return new ExcelDocument(fileName);
        }
    }
}
