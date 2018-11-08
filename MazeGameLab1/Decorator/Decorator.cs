using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.Decorator
{
    public abstract class Decorator : ISkin
    {
        protected ISkin skin = null;

        public string draw() => "super view " + skin.draw();
        public Decorator(ISkin skin) => this.skin = skin;
    }

}
