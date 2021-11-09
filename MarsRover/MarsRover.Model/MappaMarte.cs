using System;

namespace MarsRover.Model
{
    public class MappaMarte
    {
        public int DimensioneMappa => 10;
        public bool [,] Mappa => new bool[DimensioneMappa, DimensioneMappa];
    }
        
}
