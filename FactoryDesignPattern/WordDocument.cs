namespace FactoryDesignPattern {
    public class WordDocument: IDocument {
        public void Save() {
            Console.WriteLine("Saving WORD Document");
        }
        public void Open() {
            Console.WriteLine("Opening WORD Document");
        }
        public void GetMetadata() {
            Console.WriteLine("This is a WORD Docuemnt");
        }
    }
}