using System;

namespace MazeGameLab1.Strategy
{
    public class Chasing : MovementAlgorithm
    {
        public override void Move()
        {
            Console.WriteLine($"I'm chasing ({this.GetHashCode()})");
        }
    }
}
