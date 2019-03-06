using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019Feb
{
    internal class MathExtensions
    {
        internal int MathOperation(int operation, int n1, int n2)
        {
            int result = 0;

            switch (operation)
            {
                case 1:
                    result = n1 + n2;
                    break;
                case 2:
                    result = n1 - n2;
                    break;
                case 3:
                    result = n1 * n2;
                    break;
                case 4:
                    result = n1 / n2;
                    break;
            }

            return result;
        }
    }
}
