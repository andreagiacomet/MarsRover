using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Reader
{
    public interface IReader
    {
        IEnumerable<string> Read(string filename);
    }
}
