using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.Mediator
{
    interface IMediator
    {
        void AddMonster(Monster monster);
        void Broadcast(Monster monster);
    }
}
