using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.Strategy
{
    class RandDef : MovementAlgorithm
    {
        public override void Move()
        {
            Console.WriteLine($"I'm moving random ({this.GetHashCode()})");
        }
    }
}
