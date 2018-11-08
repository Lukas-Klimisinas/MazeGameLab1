using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.Global
{
    class RedEnemy : Monster
    {
        public RedEnemy(int posx, int posy, int h, int s, int dist, int dam, int dr, bool isd)
            : base(posx, posy, h, s, dist, dam, dr, isd)
        {

        }
    }
}
