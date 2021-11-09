using MarsRover.Model;
using System;

namespace MarsRover.Handler
{
    public class Mover
    {
        private readonly RotatorToLeft _toLeft;
        private readonly RotatorToRight _toRight;
        private readonly MoveForward _forward;
        private readonly MoveBackward _backward;
        public Mover(RotatorToLeft toLeft, RotatorToRight toRight, MoveForward forward, MoveBackward backward)
        {
            _toLeft = toLeft;
            _toRight = toRight;
            _forward = forward;
            _backward = backward;
        }
        public Rover Move(string comando, Rover rover, MappaMarte mappa) => comando switch
        {
            "L" => _toLeft.ChangePosition(rover, mappa),
            "R" => _toRight.ChangePosition(rover, mappa),
            "F" => _forward.ChangePosition(rover, mappa),
            "B" => _backward.ChangePosition(rover, mappa),
            _ => throw new Exception("Comando Errato!")
        };
    }
}
