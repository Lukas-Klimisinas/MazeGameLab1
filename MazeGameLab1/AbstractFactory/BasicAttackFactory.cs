using System.Globalization;

namespace MazeGameLab1.AbstractFactory
{
    public class BasicAttackFactory : AttackFactory
    {
        public override BasicAttack CreateBasicAttack(string Type)
        {
            switch (Type.ToLower(CultureInfo.CurrentCulture))
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
