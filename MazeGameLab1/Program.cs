﻿using System;
using MazeGameLab1.Global;
using MazeGameLab1.Factory;
using MazeGameLab1.Bridge;

namespace MazeGameLab1
{
    class Program
    {
        enum MonsterTypes
        {
            Big, Blue, Fast, Red
        }

        static void Main(string[] args)
        {
            MonsterFactory fact = new MonsterFactory();

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
                }

                Console.WriteLine("\nCreating player");

                Player p = new Player("Jhon", 1, false)
                {
                    ui = new LightUI()
                };

                Console.WriteLine(p.ToString() + $" ({p.GetHashCode()})" + "\n" + p.ui.ToString() + $" ({p.ui.GetHashCode()})");

                Console.WriteLine("Changing UI");
                p.ui = new DarkUI();
                Console.WriteLine(p.ToString() + $" ({p.GetHashCode()})" + "\n" + p.ui.ToString() + $" ({p.ui.GetHashCode()})");

                Console.WriteLine();
            }
        }
    }
}
