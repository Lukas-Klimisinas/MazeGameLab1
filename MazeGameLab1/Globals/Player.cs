using MazeGameLab1.Bridge;
using MazeGameLab1.Adapter;
using MazeGameLab1.Decorators;
using System.Globalization;

namespace MazeGameLab1.Globals
{
    public class Player : MazeUI, IPlayer, ISkin
    {
        public string UserName { get; set; }
        public int Coins { get; set; }
        public double Health { get; set; } = 100.0;
        public bool IsOnline { get; set; }
        public bool HasDoorKey { get; set; } = false;
        private IPlayer _player { get; set; }
        
        public Player(string pclass, string N, int C, bool On)
        {
            this.UserName = N;
            this.Coins = C;
            this.IsOnline = On;

            SetUpClass(pclass);
        }

        public Player(string N, int C, bool On)
        {
            this.UserName = N;
            this.Coins = C;
            this.IsOnline = On;

            SetUpClass("def");
        }

        private void SetUpClass(string pclass)
        {
            switch (pclass.ToLower(CultureInfo.CurrentCulture))
            {
                case "knight":
                    _player = new KnightAdapter(new Knight());
                    break;

                case "wizard":
                    _player = new WizardAdapter(new Wizard());
                    break;

                default:
                    _player = new KnightAdapter(new Knight());
                    break;
            }
        }

        public static void SelectMaze()
        {

        }

        public static void SelectMode()
        {

        }

        public override void Draw()
        {
            return ;
        }

        public override string ToString()
        {
            return $"Player {UserName} ({this.GetHashCode()})";
        }

        public void Attack()
        {
            if(_player != null)
                _player.Attack();
        }

        public void Defend()
        {
            if (_player != null)
                _player.Defend();
        }

        public void Escape()
        {
            if (_player != null)
                _player.Escape();
        }

        public string draw()
        {
            return "drawing player weapon";
        }
    }
}
