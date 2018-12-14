using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.Memento
{
    class Caretaker
    {
        private MonsterMemento _memento;

        public MonsterMemento getMememto()
        {
            return _memento;
        }

        public void setMemento(MonsterMemento memento)
        {
            _memento = memento;
        }
    }
}
