using MarsRover.Model;
using System;
using System.Text;

namespace MarsRover.Writer
{
    public class ConsoleWriter : IWriter
    {
        public void Write(Navigatore navigatore)
        {
            for (int i = 0; i < navigatore.Mappa.DimensioneMappa; i++)
            {
                for (int j = 0; j < navigatore.Mappa.DimensioneMappa; j++)
                {
                    if (i == navigatore.Rover.PosizioneRover.Longitudine && j == navigatore.Rover.PosizioneRover.Latitudine)
                        Console.Write(Encoding.GetEncoding("iso-8859-1").GetString(new byte[] { 174 }));
                    else if (navigatore.Mappa.Mappa[i, j] == true)
                        Console.Write(Encoding.GetEncoding("iso-8859-1").GetString(new byte[] { 35 }));
                    else
                        Console.Write("-");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Il Rover si trova in Posizione [{navigatore.Rover.PosizioneRover.Longitudine},{navigatore.Rover.PosizioneRover.Latitudine}] con direzione {navigatore.Rover.DirezioneRover}");
        }
    }
}
