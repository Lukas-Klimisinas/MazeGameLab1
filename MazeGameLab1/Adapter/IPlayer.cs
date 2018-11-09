using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.Adapter
{
    interface IPlayer
    {
        void Attack();
        void Defend();
        void Escape();
    }
}
