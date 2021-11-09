using MarsRover.Model;
using System;
using System.Collections.Generic;

namespace MarsRover.Handler
{
    public class PopulatorInitialMap
    {
        public MappaMarte PopulateMap(IList<Ostacolo> listaOstacoli, MappaMarte mappa, Rover rover)
        {
            var mappaPopolata = mappa;
            foreach (var elem in listaOstacoli)
            {
                mappaPopolata.Mappa[elem.PosizioneOstacolo.Longitudine, elem.PosizioneOstacolo.Latitudine] = true;
            }
            if (mappaPopolata.Mappa[rover.PosizioneRover.Longitudine, rover.PosizioneRover.Latitudine] == false)
                mappaPopolata.Mappa[rover.PosizioneRover.Longitudine, rover.PosizioneRover.Latitudine] = true;
            else
                Console.WriteLine($"Punto di partenza del rover non possibile!");
            return mappaPopolata;
        }

    }
}
