using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.Proxy
{
    class EndDisplayProxy : Display
    {
        Display display;

        string dispath;
        Display parentProxy;

        public EndDisplayProxy(string path)
        {
            dispath = path;
        }

        public EndDisplayProxy(Display anotherProxy)
        {
            parentProxy = anotherProxy;
        }

        public void ShowDisplay()
        {
            if (parentProxy == null)
            {
                if (display==null)
                {
                    display = new EndDisplay(dispath);
                } 
                display.ShowDisplay();
            }
            else
            {
                parentProxy.ShowDisplay();
            }
            
        }

    }
}
