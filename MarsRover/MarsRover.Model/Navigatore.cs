using System.Collections.Generic;

namespace MarsRover.Model
{
    public class Navigatore
    {
        public MappaMarte Mappa {get; set;}
        public Rover Rover { get; set; }
        public IList<Ostacolo> Ostacoli { get; set; }
    }
}
