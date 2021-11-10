using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MarsRover.Reader
{
    public class FileReaderComandi : IReader
    {
        public IEnumerable<string> Read(string filename) => File.ReadAllText(filename).Split(",").ToList();
    }
}
