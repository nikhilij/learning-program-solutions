using System;

namespace FactoryMethodPatternExample
{
    public class WordDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new WordDocument();
        }

        public override IDocument CreateDocument(string fileName)
        {
            return new WordDocument(fileName);
        }        public override string GetFactoryType()
        {
            return "Word Document Factory";
        }

        public WordDocument CreateWordDocument(string fileName)
        {
            return new WordDocument(fileName);
        }
    }
}
