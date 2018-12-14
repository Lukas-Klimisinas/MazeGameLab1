using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.Mediator
{
    class MonsterMediator : IMediator
    {
        List<Monster> MonsterList = new List<Monster>();
        public void AddMonster(Monster monster)
        {
            MonsterList.Add(monster);
        }

        public void Broadcast(Monster monster)
        {
            MonsterList.Remove(monster);

            foreach (Monster m in MonsterList)
            {
                m.ChangeState();
            }
        }
    }

}
