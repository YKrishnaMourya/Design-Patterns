namespace FactoryDesignPattern
{
    public interface IDocument {
        public void Save();
        public void Open();
        public void GetMetadata();
    }
}