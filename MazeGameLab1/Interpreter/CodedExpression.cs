using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.Interpreter
{
    class CodedExpression : Expression
    {
        Expression normal;

        public CodedExpression(Expression norm)
        {
            normal = norm;
        }

        public string execute()
        {
            byte xorConstant = 0x53;
            byte[] data = Encoding.UTF8.GetBytes(normal.execute());

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (byte)(data[i] ^ xorConstant);
            }
            string output = Convert.ToBase64String(data);

            return output;
        }
    }
}


