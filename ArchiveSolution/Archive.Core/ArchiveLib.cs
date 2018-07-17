using System.IO;
using Archive.Common;

namespace Archive.Core
{
    public class ArchiveLib
    {
        public void WriteFile(string text)
        {
            using (StreamWriter writer =
                new StreamWriter("C:\\important.txt"))
            {
                writer.WriteLine(FormatterFactory.FormatString(text));
            }
        }
    }
}
