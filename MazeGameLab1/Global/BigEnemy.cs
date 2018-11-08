using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.Global
{
    class BigEnemy : Monster
    {
        public BigEnemy(int posx, int posy, int h, int s, int dist, int dam, int dr, bool isd)
            : base(posx, posy, h, s, dist, dam, dr, isd)
        {

        }
    }
}
