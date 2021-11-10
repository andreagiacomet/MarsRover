using MarsRover.Model;
using System;

namespace MarsRover.Handler
{
    public class InitialRover
    {
        public Rover CreateInitialRover(int dimensioneMappa)
        {
            Random r = new Random();
            var rover = new Rover()
            {
                PosizioneRover = new Posizione()
                { Longitudine = r.Next(0, dimensioneMappa - 1), Latitudine = r.Next(0, dimensioneMappa - 1) },
                DirezioneRover = "N"
            };
            return rover;
        }

    }
}
