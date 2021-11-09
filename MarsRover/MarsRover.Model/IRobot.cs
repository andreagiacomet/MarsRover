using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Model
{
    public interface IRobot
    {
        Posizione PosizioneRover { get; set; }
        string DirezioneRover { get; set; }
    }
}
