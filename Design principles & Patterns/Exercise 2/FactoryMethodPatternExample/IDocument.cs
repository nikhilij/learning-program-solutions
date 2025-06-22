using System;

namespace FactoryMethodPatternExample
{
    public interface IDocument
    {
        void Open();
        void Close();
        void Save();
        string GetDocumentType();
        string FileName { get; set; }
    }
}
