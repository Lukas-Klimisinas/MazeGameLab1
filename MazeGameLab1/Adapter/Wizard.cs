using System;

namespace MazeGameLab1.Adapter
{
    public class Wizard : IWizard
    {
        public void ShootFireBall()
        {
            Console.WriteLine("Shooting fireballs and burning witches");
        }

        public void SummonPunchingBag()
        {
            Console.WriteLine("Attack this one instead");
        }

        public void TeleportOut()
        {
            Console.WriteLine("Cya");
        }
    }
}
