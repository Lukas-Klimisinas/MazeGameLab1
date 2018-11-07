using MazeGameLab1.Global;
using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.Factory
{
    abstract class Factory
    {
        public abstract Monster CreateEnemy(string type, int posx, int posy, int h, int s, int dist, int dam, int dr, bool isd);
    }
}
