using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator1
{
    public static class OperationQueueBuilder
    {
        private static Queue<Node> nodeQueue;       
        
        public static Queue<Node> GetQueue(string equationRaw)
        {
            string equation = Regex.Replace(equationRaw, @"\s+", string.Empty);
            if (!Validator.ValidateEquation(equation))
                throw new Exception("Not a valid Equation!");

            Queue<string> numberQueue = new Queue<string>();
            Queue<char> operatorQueue = new Queue<char>();

            List<string> numbers = equation.Split(new Char[] {
                Convert.ToChar(OperatorType.Add),
                Convert.ToChar(OperatorType.Subtract),
                Convert.ToChar(OperatorType.Multiply),
                Convert.ToChar(OperatorType.Divide),
            }).ToList();

            foreach(var num in numbers)
            {
                numberQueue.Enqueue(num);
            }

            List<char> operators = Regex.Replace(equation, @"[\d]", string.Empty).ToCharArray().ToList();
            nodeQueue = new Queue<Node>();

            foreach(var c in operators)
            {
                operatorQueue.Enqueue(c);
            }

            for(int i=0; i< equation.Length; i++)
            {
                if (i >= 0 && i % 2 == 0 && numberQueue.Count > 0)
                    nodeQueue.Enqueue(new Node { Value = numberQueue.Dequeue(), NodeType = NodeType.Numeric });
                else
                    if(operatorQueue.Count > 0)
                        nodeQueue.Enqueue(new Node { Value = Convert.ToString(operatorQueue.Dequeue()), NodeType = NodeType.Operator });

            }

            return nodeQueue;
        }
    }
}
