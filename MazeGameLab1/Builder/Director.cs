using MazeGameLab1.Global;
using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.Builder
{
    class Director
    {
        public void Construct(IBuilder Builder)
        {
            Builder.BuildSize(500);
            Builder.BuildPlayerCount(4);

            Player player1 = new Player();
            Player player2 = new Player();
            Player player3 = new Player();
            Player player4 = new Player();

            List<Player> Players = new List<Player>();
            Players.Add(player1);
            Players.Add(player2);
            Players.Add(player3);
            Players.Add(player4);

            Builder.BuildPlayers(Players);

            List<Monster> Monsters = new List<Monster>();

            Monster Monster1 = new BigEnemy(10, 15, 500, 10, 40, 7, 5, false);
            Monster Monster2 = new FastEnemy(40, 70, 40, 60, 60, 4, 6, false);
            Monsters.Add(Monster1);
            Monsters.Add(Monster2);

            Builder.BuildMonsters(Monsters);
            
        }
    }
}
