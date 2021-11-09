using MarsRover.Model;

namespace MarsRover.Handler
{
        public interface IChangePosition
        {
            Rover ChangePosition(Rover rover, MappaMarte mappa);
        }
}
