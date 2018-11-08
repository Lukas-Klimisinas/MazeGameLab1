using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.Decorator
{
    public class BlueWeapon : Decorator
    {
        public BlueWeapon(ISkin skin) : base(skin)
        {
        }
        public string draw() => "blue weapon " + skin.draw();
    }
}
