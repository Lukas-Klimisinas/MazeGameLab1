namespace MazeGameLab1.AbstractFactory
{
    abstract class BasicAttack
    {
        public abstract int DealsDamage { get; }
        public abstract double Range { get; }
        public abstract double Cooldown { get; }
        public abstract string Name { get; }
        public abstract void Attack();
        public abstract override string ToString();
    }
}
