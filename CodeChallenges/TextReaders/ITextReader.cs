namespace TextReaders
{
    public interface ITextReader
    {
        IEnumerable<string> ReadAllLines();
    }
}