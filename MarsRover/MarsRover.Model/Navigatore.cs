using System.Collections.Generic;

namespace MarsRover.Model
{
    public class Navigatore
    {
        private readonly MappaMarte _mappa;
        private readonly Rover _rover;
        private readonly IList<Ostacolo> _ostacoli;
        public Navigatore(MappaMarte mappa, Rover rover, List<Ostacolo> ostacoli)
        {
            _mappa = mappa;
            _rover = rover;
            _ostacoli = ostacoli;
        }

        public MappaMarte Mappa {get; set;}
        public Rover Rover { get; set; }
        public IList<Ostacolo> Ostacoli { get; set; }
    }
}
