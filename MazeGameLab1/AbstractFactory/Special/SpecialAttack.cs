using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.AbstractFactory
{
    public abstract class SpecialAttack
    {
        public abstract int DealsDamage { get; }
        public abstract double Range { get; }
        public abstract double Cooldown { get; }
        public abstract string Name { get; }
        public abstract void Attack();
        public abstract override string ToString();
    }
}
