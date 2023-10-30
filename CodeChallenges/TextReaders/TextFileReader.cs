using System.IO;

namespace TextReaders
{
    public class TextFileReader : ITextReader
    {
        public string Source { get; set; }

        public IEnumerable<string> ReadAllLines()
        {
            using (StreamReader sr = new StreamReader(Source))
            {
                while (sr.Peek() >= 0)
                {
                    var line = sr.ReadLine();
                    if (line != null)
                    {
                        yield return line;
                    }
                }
            }
        }
    }
}
