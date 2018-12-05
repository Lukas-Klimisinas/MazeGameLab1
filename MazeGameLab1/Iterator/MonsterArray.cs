using MazeGameLab1.Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGameLab1.Enumerable
{
    class MonsterArray
    {
        private Monster[] monsters;
        int index = 0;
        int arraySize = 2;

        public MonsterArray()
        {
            monsters = new Monster[arraySize];
            monsters[index++] = new Monster(5, 5, 5, 5, 5, 5, 5, true);
            monsters[index++] = new Monster(6, 6, 6, 6, 6, 6, 6, true);
        }
        public void addMonster(Monster newMonster)
        {
            monsters[index++] = newMonster;
        }
        public int Size()
        {
            return index;
        }
        public Monster getMonster(int i)
        {
            return monsters[i];
        }
        public Monster[] getMonsters()
        {
            return monsters;
        }
        public IEnumerator<Monster> GetIterator()
        {
            List<Monster> list = new List<Monster>(monsters);
            return list.GetEnumerator();
        }
    }
}
