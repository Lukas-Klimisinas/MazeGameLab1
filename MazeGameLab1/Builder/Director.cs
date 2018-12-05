using MazeGameLab1.Globals;
using System.Collections.Generic;

namespace MazeGameLab1.Builder
{
    public class Director
    {
        private IBuilder _builder;

        public void Construct(IBuilder Builder)
        {
            this._builder = Builder;

            this._builder.BuildSize(500);
            this._builder.BuildPlayerCount(4);

            Player player1 = new Player("Bob", 5, false);
            Player player2 = new Player("Bob1", 5, false);
            Player player3 = new Player("Bob2", 5, false);
            Player player4 = new Player("Bob3", 5, false);

            List<Player> Players = new List<Player>
            {
                player1,
                player2,
                player3,
                player4
            };

            this._builder.BuildPlayers(Players);

            List<Monster> Monsters = new List<Monster>();

            Monster Monster1 = new BigEnemy(10, 15, 500, 10, 40, 7, 5, false);
            Monster Monster2 = new FastEnemy(40, 70, 40, 60, 60, 4, 6, false);
            Monsters.Add(Monster1);
            Monsters.Add(Monster2);

            Builder.BuildMonsters(Monsters);
            
        }
    }
}
