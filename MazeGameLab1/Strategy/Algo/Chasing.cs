﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.Strategy
{
    class Chasing : MovementAlgorithm
    {
        public override void Move()
        {
            Console.WriteLine($"I'm chasing ({this.GetHashCode()})");
        }
    }
}