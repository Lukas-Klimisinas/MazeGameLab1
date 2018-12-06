using System.Collections.Generic;
using MazeGameLab1.Globals;

namespace MazeGameLab1.Builder
{
    public class MazeBuilder : IBuilder
    {
        private Maze NewMaze = new Maze();

        public override void BuildMonsters(List<Monster> Monsters)
        {
            NewMaze.SetMonsters(Monsters);
        }

        public override void BuildPlayerCount(int PlayerCount)
        {
            NewMaze.SetPlayerCount(PlayerCount);
        }

        public override void BuildPlayers(List<Player> Players)
        {
            NewMaze.SetPlayers(Players);
        }

        public override void BuildSize(int Size)
        {
            NewMaze.SetSize(Size);
        }

        public override Maze GetMaze()
        {
            return NewMaze;
        }
    }
}
