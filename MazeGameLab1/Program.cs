using System;
using MazeGameLab1.Globals;
using MazeGameLab1.Factory;
using MazeGameLab1.Builder;
using MazeGameLab1.Bridge;
using MazeGameLab1.Decorators;
using MazeGameLab1.Enumerable;
using System.Collections;
using System.Collections.Generic;

namespace MazeGameLab1
{
    class Program
    {
        enum MonsterTypes
        {
            Big, Blue, Fast, Red
        }
        //fak
        static void Main()
        {
            IFactory fact = new MonsterFactory();

            /*UnitMaze UMaze = new UnitMaze();

            Console.WriteLine(UMaze.Move("up"));
            Console.WriteLine(UMaze.Move("up"));
            Console.WriteLine(UMaze.Move("up"));
            Console.WriteLine(UMaze.Move("up"));
            Console.WriteLine(UMaze.Move("up"));
            Console.WriteLine(UMaze.Move("up"));
            Console.WriteLine(UMaze.Move("up"));
            Console.WriteLine(UMaze.Move("up"));
            Console.WriteLine(UMaze.Move("left"));
            Console.WriteLine(UMaze.Move("left"));
            Console.WriteLine(UMaze.Move("left"));
            Console.WriteLine(UMaze.Move("left"));
            Console.WriteLine(UMaze.Move("left"));
            Console.WriteLine(UMaze.Move("right"));
            Console.WriteLine(UMaze.Move("right"));
            Console.WriteLine(UMaze.Move("right"));
            Console.WriteLine(UMaze.Move("right"));
            Console.WriteLine(UMaze.Move("right"));
            Console.WriteLine(UMaze.Move("down"));
            Console.WriteLine(UMaze.Move("down"));
            Console.WriteLine(UMaze.Move("left"));
            Console.WriteLine(UMaze.Move("left"));
            Console.WriteLine(UMaze.Move("down"));
            Console.WriteLine(UMaze.Move("down"));*/

            //Epic turn off of loop
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

                Console.WriteLine("\n-----Iterator START-----");
                MonsterArray array = new MonsterArray();
                MonsterList list = new MonsterList();
                MonsterHash hash = new MonsterHash();

                Monster[] monstersArray = array.getMonsters();
                List<Monster> monstersList = list.getMonsters();
                HashSet<Monster> monstersHash = hash.getMonsters();

                IEnumerator i1 = array.GetIterator();
                IEnumerator i2 = list.getIterator();
                IEnumerator i3 = hash.getIterator();

                canItMoveThroughDifferentMonsters(i1);
                canItMoveThroughDifferentMonsters(i2);
                canItMoveThroughDifferentMonsters(i3);

                Console.WriteLine("-----Iterator END-----");
            }
        }
        public static void canItMoveThroughDifferentMonsters(IEnumerator i)
        {
            Console.WriteLine(i.MoveNext());
        }
    }
}
