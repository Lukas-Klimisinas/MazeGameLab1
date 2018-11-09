using System;
using MazeGameLab1.Bridge;
using MazeGameLab1.Decorator;

namespace MazeGameLab1.Global
{
    class Player : UI, ISkin
    {
        private string UserName { get; set; }
        private int Coins { get; set; }
        private bool IsOnline { get; set; }
        
        public Player(string N, int C, bool On)
        {
            this.UserName = N;
            this.Coins = C;
            this.IsOnline = On;
        }

        public void SelectMaze()
        {

        }

        public void SelectMode()
        {

        }

        public override void Draw()
        {
            return ;
        }

        public override string ToString()
        {
            return $"Player {UserName}";
        }

        public string draw()
        {
            return "drawing player weapon";
        }
    }
}
