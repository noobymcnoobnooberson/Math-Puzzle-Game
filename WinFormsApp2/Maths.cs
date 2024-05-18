using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Puzzle_Game
{
    internal class Maths
    {
        int Sum(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
        int Sub(int x, int y)
        {
            int sub = x - y;
            return sub;
        }
        int Mul(int x, int y)
        {
            int mul = x * y;
            return mul;
        }
        int Div(int x, int y)
        {
            int div = x % y;
            return div;
        }
    }
}
