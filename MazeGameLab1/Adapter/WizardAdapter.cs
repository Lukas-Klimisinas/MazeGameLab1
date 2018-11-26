namespace MazeGameLab1.Adapter
{
    public class WizardAdapter : IPlayer
    {
        private readonly IWizard _wizard;

        public WizardAdapter(IWizard wizard)
        {
            _wizard = wizard;
        }

        public void Attack()
        {
            _wizard.ShootFireBall();
        }

        public void Defend()
        {
            _wizard.SummonPunchingBag();
        }

        public void Escape()
        {
            _wizard.TeleportOut();
        }
    }
}
