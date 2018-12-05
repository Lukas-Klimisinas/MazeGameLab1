using MazeGameLab1.Globals;
using System;
using System.Collections.Generic;
using System.Text;
namespace MazeGameLab1.Enumerable
{
    class MonsterList
    {
        private List<Monster> list = new List<Monster>();

        public MonsterList()
        {
            list.Add(new Monster(8, 8, 8, 8, 8, 8, 8, true));
            list.Add(new Monster(9, 9, 9, 9, 9, 9, 9, true));
        }
        public void addMonster(Monster m)
        {
            list.Add(m);
        }
        public void removeMonster(Monster m)
        {
            list.Remove(m);
        }
        public List<Monster> getMonsters()
        {
            return list;
        }
        public IEnumerator<Monster> getIterator()
        {
            return list.GetEnumerator();
        }
    }
}
