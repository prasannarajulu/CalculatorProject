using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Calculator1
{
    public sealed class SingletonManager
    {
        private static volatile SingletonManager instance;
        private static object syncRoot = new object();

        private SingletonManager() { }

        public static SingletonManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new SingletonManager();
                    }
                }

                return instance;
            }
        }

        public int Calculate(string s)
        {
            //string s = "1 + 2 * 3 / 4 - 5";
            string equation = Regex.Replace(s, @"\s+", string.Empty);
            Queue<Node> q = OperationQueueBuilder.GetQueue(equation);

            int a = 0;
            int b = 0;

            //Can also be accomplished with recursive function
            for (int i = 0; q.Count > 0; i++)
            {
                if (i == 0)
                {
                    Node n = q.Dequeue();
                    a = Convert.ToInt32(n.Value);
                    continue;
                }
                else
                {
                    Node n = q.Dequeue();
                    if (n.NodeType == NodeType.Numeric)
                    {
                        a = Convert.ToInt32(n.Value);
                        continue;
                    }
                    else if (n.NodeType == NodeType.Operator)
                    {
                        Node secondParam = q.Dequeue();
                        b = Convert.ToInt32(secondParam.Value);

                        var calculator = OperationFactory.GetOperation(n.OperatorType);
                        a = calculator.Operation(a, b);
                    }
                }
            }

            return a;
        }
    }
}
