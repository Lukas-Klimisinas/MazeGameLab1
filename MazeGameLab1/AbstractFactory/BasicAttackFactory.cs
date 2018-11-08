using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.AbstractFactory
{
    class BasicAttackFactory : AttackFactory
    {
        public override BasicAttack CreateBasicAttack(string Type)
        {
            switch (Type.ToLower())
            {
                case "punch":
                    return new Punch();

                case "double punch":
                    return new DoublePunch();

                case "fast punch":
                    return new FastPunch();

                default:
                    return null;
            }
        }

        public override SpecialAttack CreateSpecialAttack(string Type)
        {
            return null;
        }
    }
}
