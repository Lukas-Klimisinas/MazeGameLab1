using System;

namespace MazeGameLab1.AbstractFactory
{
    class Punch : BasicAttack
    {
        private readonly int Dmg = 5;
        private readonly double Rng = 1;
        private readonly double CD = 0.5;
        private readonly string Nm = "Punch";

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
