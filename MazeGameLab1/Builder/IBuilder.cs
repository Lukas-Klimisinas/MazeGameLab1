using MazeGameLab1.Global;
using System.Collections.Generic;

namespace MazeGameLab1.Builder
{
    public abstract class IBuilder
    {
        public abstract void BuildSize(int Size);
        public abstract void BuildPlayerCount(int PlayerCount);
        public abstract void BuildPlayers(List<Player> Players);
        public abstract void BuildMonsters(List<Monster> Monsters);
        public abstract Maze GetMaze();
    }
}
