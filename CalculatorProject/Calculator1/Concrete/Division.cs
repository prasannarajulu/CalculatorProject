using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    public class Division : ICalculator
    {
        public int Operation(int a, int b)
        {
            if (b == 0)
                throw new ArgumentException("Cannot divide by zero");
            return a / b;
        }
    }
}
