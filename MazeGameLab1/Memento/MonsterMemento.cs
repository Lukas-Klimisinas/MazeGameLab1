using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.Memento
{
    class MonsterMemento
    {
        private string _state;

        // Constructor
        public MonsterMemento(string state)
        {
            this._state = state;
        }

        public string getState()
        {
            return _state;
        }
    }
}
