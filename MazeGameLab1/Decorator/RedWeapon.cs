using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.Decorator
{
    public class RedWeapon : Decorator
    {
        public RedWeapon(ISkin skin) : base(skin)
        {
        }
        public string draw() => "red weapon " + skin.draw();
    }
}
