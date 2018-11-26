using System;

namespace MazeGameLab1.Strategy
{
    public class Slow : MovementAlgorithm
    {
        public override void Move()
        {
            Console.WriteLine($"I'm moving really slow ({this.GetHashCode()})");
        }
    }
}
