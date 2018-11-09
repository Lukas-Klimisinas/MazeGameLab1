using System;

namespace MazeGameLab1.Adapter
{
    class Knight : IKnight
    {
        public void AttackWithSword()
        {
            Console.WriteLine("Attacking with my big sword");
        }

        public void BigShieldDef()
        {
            Console.WriteLine("Hiding behind big shield");
        }

        public void StunAndRun()
        {
            Console.WriteLine("Stunning everyone and running away like a boss.");
        }
    }
}
