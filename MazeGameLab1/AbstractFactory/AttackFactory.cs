namespace MazeGameLab1.AbstractFactory
{
    public abstract class AttackFactory
    {
        public abstract BasicAttack CreateBasicAttack(string Type);
        public abstract SpecialAttack CreateSpecialAttack(string Type);
    }
}
