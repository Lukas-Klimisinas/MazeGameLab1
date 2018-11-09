using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.Strategy
{
    class Slow : MovementAlgorithm
    {
        public override void Move()
        {
            Console.WriteLine($"I'm moving really slow ({this.GetHashCode()})");
        }
    }
}
