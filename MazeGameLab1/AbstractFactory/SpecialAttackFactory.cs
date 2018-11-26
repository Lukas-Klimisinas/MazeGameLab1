namespace MazeGameLab1.AbstractFactory
{
    public class SpecialAttackFactory : AttackFactory
    {
        public override BasicAttack CreateBasicAttack(string Type)
        {
            return null;
        }

        public override SpecialAttack CreateSpecialAttack(string Type)
        {
            switch (Type.ToLower())
            {
                case "big punch":
                    return new BigPunch();

                case "really big punch":
                    return new ReallyBigPunch();

                default:
                    return null;
            }
        }
    }
}
