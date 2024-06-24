namespace FactoryDesignPattern {
    public class TextDocument: IDocument {
        public void Save() {
            Console.WriteLine("Saving Text Document");
        }
        public void Open() {
            Console.WriteLine("Opening Text Document");
        }
        public void GetMetadata() {
            Console.WriteLine("This is a Text Docuemnt");
        }
    }
}