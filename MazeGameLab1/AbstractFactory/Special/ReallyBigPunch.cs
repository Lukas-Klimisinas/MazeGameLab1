using System;

namespace MazeGameLab1.AbstractFactory
{
    public class ReallyBigPunch : SpecialAttack
    {
        private readonly int Dmg = 20;
        private readonly double Rng = 3;
        private readonly double CD = 3;
        private readonly string Nm = "Really big punch";

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
