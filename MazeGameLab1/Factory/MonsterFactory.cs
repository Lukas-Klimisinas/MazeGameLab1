using System;
using System.Globalization;
using MazeGameLab1.Globals;

namespace MazeGameLab1.Factory
{
    public class MonsterFactory : IFactory
    {
        public override Monster CreateEnemy(string type, int posx, int posy, int h, int s, int dist, int dam, int dr, bool isd)
        {
            switch (type.ToLower(CultureInfo.CurrentCulture))
            {
                case "big":
                    return new BigEnemy(posx, posy, h, s, dist, dam, dr, isd);
                case "blue":
                    return new BlueEnemy(posx, posy, h, s, dist, dam, dr, isd);
                case "fast":
                    return new FastEnemy(posx, posy, h, s, dist, dam, dr, isd);
                case "red":
                    return new RedEnemy(posx, posy, h, s, dist, dam, dr, isd);
                default:
                    Console.WriteLine("Unknwon Enemy Type");
                    return null;

            }
        }
    }
}
