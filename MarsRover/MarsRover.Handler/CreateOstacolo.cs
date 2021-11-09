using MarsRover.Model;
using System;
using System.Collections.Generic;

namespace MarsRover.Handler
{
    public class CreateOstacolo
    {
        public IList<Ostacolo> CreateOstacoli(MappaMarte mappa,int numOstacoli)
        {
            var lista = new List<Ostacolo>();
            while (lista.Count < numOstacoli)
            {
                Random r = new Random();
                int r1 = r.Next(0, mappa.DimensioneMappa - 1);
                int r2 = r.Next(0, mappa.DimensioneMappa - 1);
                var ostacolo = new Ostacolo() { PosizioneOstacolo = new Posizione() { Longitudine = r1, Latitudine = r2 } };
                lista.Add(ostacolo);
            }
            return lista;
        }
    }
}
