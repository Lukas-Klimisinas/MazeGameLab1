namespace MazeGameLab1.Adapter
{
    public class KnightAdapter : IPlayer
    {
        private readonly IKnight _knight;

        public KnightAdapter(IKnight knight)
        {
            _knight = knight;
        }

        public void Attack()
        {
            _knight.AttackWithSword();
        }

        public void Defend()
        {
            _knight.BigShieldDef();
        }

        public void Escape()
        {
            _knight.StunAndRun();
        }
    }
}
