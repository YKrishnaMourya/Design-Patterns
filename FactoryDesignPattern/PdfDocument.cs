namespace FactoryDesignPattern {
    public class PdfDocument: IDocument {
        public void Save() {
            Console.WriteLine("Saving PDF Document");
        }
        public void Open() {
            Console.WriteLine("Opening PDF Document");
        }
        public void GetMetadata() {
            Console.WriteLine("This is a PDF Docuemnt");
        }
    }
}