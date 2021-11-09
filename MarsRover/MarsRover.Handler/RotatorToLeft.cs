using MarsRover.Model;
using System;

namespace MarsRover.Handler
{
    public class RotatorToLeft : IChangePosition
    {
        public Rover ChangePosition(Rover rover, MappaMarte mappa)
        {
            var rov = rover;
            var finaldirection = rov.DirezioneRover switch
            {
                "N" => rov.DirezioneRover = "W",
                "W" => rov.DirezioneRover = "S",
                "S" => rov.DirezioneRover = "E",
                "E" => rov.DirezioneRover = "N",
                _ => throw new Exception("Comando Errato!")
            };
            rov.DirezioneRover = finaldirection;
            return rov;
        }
    }
}
