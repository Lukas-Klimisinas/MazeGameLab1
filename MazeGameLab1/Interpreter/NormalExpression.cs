using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.Interpreter
{
    class NormalExpression: Expression
    {

        public string value;

        public NormalExpression(string newValue)
        {
            value = newValue;
        }


        public string execute()
        {
            return value;
        }
    }
}
