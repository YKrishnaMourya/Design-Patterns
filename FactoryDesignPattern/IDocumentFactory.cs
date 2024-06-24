namespace FactoryDesignPattern {
    public interface IDocumentFactory {
        public IDocument CreateDocument(string input);
    }
}