using System;
namespace MazeGameLab1.AbstractFactory
{
    abstract class AttackFactory
    {
        public abstract BasicAttack CreateBasicAttack(string Type);
        public abstract SpecialAttack CreateSpecialAttack(string Type);
    }
}
