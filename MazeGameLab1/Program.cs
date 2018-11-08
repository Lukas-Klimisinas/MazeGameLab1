using System;
using MazeGameLab1.Global;
using MazeGameLab1.Factory;

namespace MazeGameLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            MonsterFactory fact = new MonsterFactory();

            Console.WriteLine("Choose Monster: Big, Blue, Fast, Red");
            string type = Console.ReadLine();

            Monster newMonster = fact.CreateEnemy(type, 10, 10, 500, 10, 140, 4, 4, false);

            newMonster.Talk();
        }
    }
}
