namespace MarsRover.Model
{
    public interface IRobot
    {
        Posizione PosizioneRover { get; set; }
        string DirezioneRover { get; set; }
    }
}
