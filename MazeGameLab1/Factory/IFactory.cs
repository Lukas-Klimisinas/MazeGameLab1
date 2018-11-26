using MazeGameLab1.Global;

namespace MazeGameLab1.Factory
{
    public abstract class IFactory
    {
        public abstract Monster CreateEnemy(string type, int posx, int posy, int h, int s, int dist, int dam, int dr, bool isd);
    }
}
