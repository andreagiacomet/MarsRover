using MarsRover.Model;
using MarsRover.Reader;
using MarsRover.Writer;
using System.Collections.Generic;

namespace MarsRover.Handler
{
    public class Manager
    {
        private readonly CreateOstacolo _createOstacolo;
        private readonly Mover _mover;
        private readonly PopulatorMap _populatorMap;
        private readonly IWriter _writer;
        private readonly IReader _reader;
        private readonly InitialRover _initialRover;
        private readonly CreateInitialMap _initialMap;
        private IList<Ostacolo> _ostacoli;
        private MappaMarte _mappaPopolata;
        private Rover _rover;

        public Manager(CreateOstacolo createOstacolo, InitialRover initialRover,CreateInitialMap initialMap, Mover mover, PopulatorMap populatorMap, IWriter writer, IReader reader)
        {
            _createOstacolo = createOstacolo;
            _initialRover = initialRover;
            _initialMap = initialMap;
            _mover = mover;
            _populatorMap = populatorMap;
            _writer = writer;
            _reader = reader;
        }

        public void Execute(string filepath)
        {
            var comandi = _reader.Read(filepath);
            foreach (var elem in comandi)
            {
                _rover = _mover.Move(elem, _rover, _mappaPopolata);
            }

            var result = new Navigatore()
            {
                Mappa = _mappaPopolata,
                Ostacoli = _ostacoli,
                Rover = _rover

            };
            _writer.Write(result);

        }

        public void Setup(int dimensioneMappa)
        {
            _ostacoli = _createOstacolo.CreateOstacoli(dimensioneMappa);
            _rover = _initialRover.CreateInitialRover(dimensioneMappa);
            _mappaPopolata = _populatorMap.PopulateMap(_ostacoli, _initialMap.CreateMap(dimensioneMappa), _rover);

            var result = new Navigatore()
            {
                Mappa = _mappaPopolata,
                Ostacoli = _ostacoli,
                Rover = _rover

            };
            _writer.Write(result);
        }
    }
}
