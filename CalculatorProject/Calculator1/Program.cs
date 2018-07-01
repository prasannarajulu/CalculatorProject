using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter equation to calculate");
            try
            {
                Console.WriteLine("Answer:" + SingletonManager.Instance.Calculate(Console.ReadLine()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
