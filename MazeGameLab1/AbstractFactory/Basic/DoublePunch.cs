using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.AbstractFactory
{
    public class DoublePunch : BasicAttack
    {
        private readonly int Dmg = 10;
        private readonly double Rng = 1.5;
        private readonly double CD = 1;
        private readonly string Nm = "Double punch";

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
