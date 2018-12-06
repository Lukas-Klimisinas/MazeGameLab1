using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace MazeGameLab1.Proxy
{
    public class EndDisplay : Display
    {

        string Dispath;
   
        public EndDisplay(string path)
        {
            Dispath = path;
            
            try
            {
                //Bitmap image = new Bitmap(path,true);
                
            }
            catch (Exception ex)
            {
                
                throw new ApplicationException("image path not found", ex);
            }
        }

        


        public void ShowDisplay()
        {
            Console.WriteLine("Display "+ Dispath +" loaded");
        }
    }
}
