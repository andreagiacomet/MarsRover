using MarsRover.Model;
using System;

namespace MarsRover.Handler
{
    public class RotatorToRight : IChangePosition
    {
        public Rover ChangePosition(Rover rover, MappaMarte mappa)
        {
            var rov = rover;
            var finaldirection = rov.DirezioneRover switch
            {
                "N" => rov.DirezioneRover = "E",
                "W" => rov.DirezioneRover = "N",
                "S" => rov.DirezioneRover = "W",
                "E" => rov.DirezioneRover = "S",
                _ => throw new Exception("Comando Errato!")
            };
            rov.DirezioneRover = finaldirection;
            return rov;
        }
    }
}
