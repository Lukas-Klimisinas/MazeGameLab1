using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.Strategy
{
    class Fast : MovementAlgorithm
    {
        public override void Move()
        {
            Console.WriteLine($"I'm moving really fast ({this.GetHashCode()})");
        }
    }
}
