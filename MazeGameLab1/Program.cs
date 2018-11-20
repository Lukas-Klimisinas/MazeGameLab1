using System;
using MazeGameLab1.Global;
using MazeGameLab1.Factory;
using MazeGameLab1.Builder;
using MazeGameLab1.Bridge;
using MazeGameLab1.Decorator;

namespace MazeGameLab1
{
    class Program
    {
        enum MonsterTypes
        {
            Big, Blue, Fast, Red
        }
        //fak
        static void Main(string[] args)
        {
            IFactory fact = new MonsterFactory();

            while (true)
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine($"Choose Monster: {MonsterTypes.Big} {MonsterTypes.Blue} {MonsterTypes.Fast} {MonsterTypes.Red}");
                string type = Console.ReadLine();

                if (Enum.IsDefined(typeof(MonsterTypes), type))
                {

                    Monster newMonster = fact.CreateEnemy(type, 10, 10, 500, 10, 140, 4, 4, false);

                    newMonster.AddBasicAttack("punch");
                    newMonster.AddBasicAttack("fast punch");
                    newMonster.AddBasicAttack("double punch");
                    newMonster.AddSpecialAttack("big punch");
                    newMonster.AddSpecialAttack("really big punch");

                    newMonster.Talk();

                    Console.WriteLine();

                    newMonster.Move();

                    newMonster.ChangeAlgorithm("fast");
                    newMonster.Move();

                    newMonster.ChangeAlgorithm("chasing");
                    newMonster.Move();

                    newMonster.ChangeAlgorithm("slow");
                    newMonster.Move();

                    newMonster.ChangeAlgorithm("random");
                    newMonster.Move();
                }

                Console.WriteLine("\n -----Builder----- \n");

                Director Director = new Director();

                IBuilder MazeBuilder = new MazeBuilder();

                Director.Construct(MazeBuilder);
                Maze Maze = MazeBuilder.GetMaze();
                Maze.Talk();

                Console.WriteLine("-----Builder END-----");

                Console.WriteLine("\n-----Bridge START-----");
                Console.WriteLine("\nCreating player");

                Player p = new Player("wizard", "Harry", 1, false)
                {
                    ui = new LightUI()
                };

                Console.WriteLine("\n -----Decorator start----- \n");

                ISkin blue = new BlueWeapon(p);
                blue = new BlueWeapon(blue);
                Console.WriteLine(blue.draw());

                Console.WriteLine("\n -----Decorator END----- \n");
                Console.WriteLine(p.ToString() + $" ({p.GetHashCode()})" + "\n" + p.ui.ToString() + $" ({p.ui.GetHashCode()})");

                Console.WriteLine("Changing UI");
                p.ui = new DarkUI();
                Console.WriteLine(p.ToString() + $" ({p.GetHashCode()})" + "\n" + p.ui.ToString() + $" ({p.ui.GetHashCode()})");

                Console.WriteLine();
                Console.WriteLine("-----Bridge END-----");

                Console.WriteLine("\n-----Adapter START-----");
                Console.WriteLine(p.ToString());
                p.Attack();
                p.Defend();
                p.Escape();
                Console.WriteLine("\nNew knight player");
                Player Kn = new Player("knight", "Arc", 100, true);
                Console.WriteLine(Kn.ToString());
                Kn.Attack();
                Kn.Defend();
                Kn.Escape();
                Console.WriteLine("-----Adapter END-----");
            }
        }
    }
}
