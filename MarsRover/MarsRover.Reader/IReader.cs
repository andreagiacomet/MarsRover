using System.Collections.Generic;

namespace MarsRover.Reader
{
    public interface IReader
    {
        IEnumerable<string> Read(string filename);
    }
}
