using MarsRover.Model;
using System;

namespace MarsRover.Handler
{
    public class MoveForward : IChangePosition
    {
        public Rover ChangePosition(Rover rover, MappaMarte mappa)
        {
            var rov = rover;
            var finalposition = rov.DirezioneRover switch
            {
                "N" => NorthManager(rov, mappa),
                "W" => WestManager(rov, mappa),
                "S" => SouthManager(rov, mappa),
                "E" => EastManager(rov, mappa),
                _ => throw new Exception("Comando Errato!")
            };
            rov.PosizioneRover = finalposition;
            return rov;
        }

        private Posizione NorthManager(Rover rover, MappaMarte mappa)
        {
            if (rover.PosizioneRover.Latitudine == 0)
                if (mappa.Mappa[rover.PosizioneRover.Longitudine, mappa.DimensioneMappa - 1] == true)
                    return new Posizione() { Longitudine = rover.PosizioneRover.Longitudine, Latitudine = rover.PosizioneRover.Latitudine };
                else return new Posizione() { Latitudine = mappa.DimensioneMappa - 1, Longitudine = rover.PosizioneRover.Longitudine };
            else if (mappa.Mappa[rover.PosizioneRover.Longitudine, rover.PosizioneRover.Latitudine - 1] == true)
                return new Posizione() { Longitudine = rover.PosizioneRover.Longitudine, Latitudine = rover.PosizioneRover.Latitudine };
            else
                return new Posizione() { Longitudine = rover.PosizioneRover.Longitudine, Latitudine = rover.PosizioneRover.Latitudine - 1 };
        }

        private Posizione SouthManager(Rover rover, MappaMarte mappa)
        {
            if (rover.PosizioneRover.Latitudine == mappa.DimensioneMappa - 1)
                if (mappa.Mappa[rover.PosizioneRover.Longitudine, 0] == true)
                    return new Posizione() { Longitudine = rover.PosizioneRover.Longitudine, Latitudine = rover.PosizioneRover.Latitudine };
                else return new Posizione() { Latitudine = 0, Longitudine = rover.PosizioneRover.Longitudine };
            else if (mappa.Mappa[rover.PosizioneRover.Longitudine, rover.PosizioneRover.Latitudine + 1] == true)
                return new Posizione() { Longitudine = rover.PosizioneRover.Longitudine, Latitudine = rover.PosizioneRover.Latitudine };
            else
                return new Posizione() { Longitudine = rover.PosizioneRover.Longitudine, Latitudine = rover.PosizioneRover.Latitudine + 1 };
        }

        private Posizione EastManager(Rover rover, MappaMarte mappa)
        {
            if (rover.PosizioneRover.Longitudine == mappa.DimensioneMappa - 1)
                if (mappa.Mappa[0, rover.PosizioneRover.Latitudine] == true)
                    return new Posizione() { Longitudine = rover.PosizioneRover.Longitudine, Latitudine = rover.PosizioneRover.Latitudine };
                else return new Posizione() { Longitudine = 0, Latitudine = rover.PosizioneRover.Latitudine };
            else if (mappa.Mappa[rover.PosizioneRover.Longitudine + 1, rover.PosizioneRover.Latitudine] == true)
                return new Posizione() { Longitudine = rover.PosizioneRover.Longitudine, Latitudine = rover.PosizioneRover.Latitudine };
            else
                return new Posizione() { Longitudine = rover.PosizioneRover.Longitudine + 1, Latitudine = rover.PosizioneRover.Latitudine };
        }

        private Posizione WestManager(Rover rover, MappaMarte mappa)
        {
            if (rover.PosizioneRover.Longitudine == 0)
                if (mappa.Mappa[mappa.DimensioneMappa - 1, rover.PosizioneRover.Latitudine] == true)
                    return new Posizione() { Longitudine = rover.PosizioneRover.Longitudine, Latitudine = rover.PosizioneRover.Latitudine };
                else return new Posizione() { Longitudine = mappa.DimensioneMappa - 1, Latitudine = rover.PosizioneRover.Latitudine };
            else if (mappa.Mappa[rover.PosizioneRover.Longitudine - 1, rover.PosizioneRover.Latitudine] == true)
                return new Posizione() { Longitudine = rover.PosizioneRover.Longitudine, Latitudine = rover.PosizioneRover.Latitudine };
            else
                return new Posizione() { Longitudine = rover.PosizioneRover.Longitudine - 1, Latitudine = rover.PosizioneRover.Latitudine };
        }
    }
}
