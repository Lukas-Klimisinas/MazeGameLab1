using MazeGameLab1.Globals;
using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.Enumerable
{
    class MonsterHash
    {
        private int key = 1;
        private HashSet<Monster> hash = new HashSet<Monster>();

        public MonsterHash()
        {
            hash.Add(new Monster(5, 5, 5, 5, 5, 5, 5, true));
            hash.Add(new Monster(6, 6, 6, 6, 6, 6, 6, true));
        }
        public void addMonster(Monster m)
        {
            hash.Add(m);
        }
        public void removeMonster(Monster m)
        {
            hash.Remove(m);
        }
        public HashSet<Monster> getMonsters()
        {
            return hash;
        }
        public IEnumerator<Monster> getIterator()
        {
            return hash.GetEnumerator();
        }
    }
}
