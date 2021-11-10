using MarsRover.Model;
using System;
using System.Collections.Generic;

namespace MarsRover.Handler
{
    public class CreateOstacolo
    {
        public IList<Ostacolo> CreateOstacoli(int dimensioneMappa)
        {
            var lista = new List<Ostacolo>();
            while (lista.Count < NumOstacoli(dimensioneMappa))
            {
                Random r = new Random();
                var ostacolo = new Ostacolo()
                {
                    PosizioneOstacolo = new Posizione()
                    { Longitudine = r.Next(0, dimensioneMappa - 1), Latitudine = r.Next(0, dimensioneMappa - 1) }
                };
                lista.Add(ostacolo);
            }
            return lista;
        }

        private static int NumOstacoli(int d) => d * d / (d + d);
    }
}
