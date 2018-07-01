using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    public class Subtraction : ICalculator
    {
        public int Operation(int a, int b)
        {
            return a - b;
        }
    }
}
