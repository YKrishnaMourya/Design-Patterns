// See https://aka.ms/new-console-template for more informat
using System.Data.Common;
using FactoryDesignPattern;

namespace Client;

public class DocumentHandler
{
    public static void Main()
    {
        Console.WriteLine("Enter document type (Pdf, Word, Text):");
        string? input = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(input)) return;
        IDocumentFactory documentFactory = new DocumentFactory();
        IDocument document = documentFactory.CreateDocument(input);
        document.GetMetadata();
        document.Open();
        document.Save();
        
    }
}