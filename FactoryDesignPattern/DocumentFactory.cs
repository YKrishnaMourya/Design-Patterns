namespace FactoryDesignPattern
{
    public class DocumentFactory : IDocumentFactory
    {
        public IDocument CreateDocument(string input)
        {
            if (Enum.TryParse(input, true, out DocumentType docType))
            {
                switch (docType)
                {
                    case DocumentType.Pdf:
                        return new PdfDocument();
                    case DocumentType.Word:
                        return new WordDocument();
                    case DocumentType.Text:
                        return new TextDocument();
                    default:
                        throw new ArgumentException($"Unsupported document type: {docType}");

                }
            }
            throw new ArgumentException("Invalid document type");
        }
    }
}