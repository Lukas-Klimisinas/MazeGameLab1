using System;

namespace MazeGameLab1.Strategy
{
    public class RandDef : MovementAlgorithm
    {
        public override void Move()
        {
            Console.WriteLine($"I'm moving random ({this.GetHashCode()})");
        }
    }
}
