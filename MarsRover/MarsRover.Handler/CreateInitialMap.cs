using MarsRover.Model;

namespace MarsRover.Handler
{
    public class CreateInitialMap
    {
        public MappaMarte CreateMap(int dimensioneMappa)
        {
            var map = new MappaMarte() { DimensioneMappa = dimensioneMappa };
            map.Mappa = new bool[dimensioneMappa, dimensioneMappa];
            for (int i = 0; i < dimensioneMappa; i++)
            {
                for (int j = 0; j < dimensioneMappa; j++)
                {
                    map.Mappa[i, j] = false;
                }
            }
            return map;
        }
    }
}
