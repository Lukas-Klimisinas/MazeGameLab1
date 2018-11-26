using System;

namespace MazeGameLab1.Strategy
{
    public class Fast : MovementAlgorithm
    {
        public override void Move()
        {
            Console.WriteLine($"I'm moving really fast ({this.GetHashCode()})");
        }
    }
}
