using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.AbstractFactory
{
    class FastPunch : BasicAttack
    {
        private readonly int Dmg = 3;
        private readonly double Rng = 0.8;
        private readonly double CD = 0.2;
        private readonly string Nm = "Fast punch";

        public override int DealsDamage { get { return Dmg; } }
        public override double Range { get { return Rng; } }
        public override double Cooldown { get { return CD; } }
        public override string Name { get { return Nm; } }

        public override void Attack()
        {
            Console.WriteLine($"Monster attacks using {Nm} and deals {Dmg} damage.");
        }

        public override string ToString()
        {
            return Nm;
        }
    }
}
