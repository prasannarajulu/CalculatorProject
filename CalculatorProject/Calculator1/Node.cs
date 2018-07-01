using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    public class Node
    {
        public string Value { get; set; }
        public NodeType NodeType { get; set; }
        public OperatorType OperatorType
        {
            get
            {
                if (NodeType == NodeType.Operator)
                {
                    switch (Value)
                    {
                        case "+":
                            return OperatorType.Add;
                        case "-":
                            return OperatorType.Subtract;
                        case "*":
                            return OperatorType.Multiply;
                        case "/":
                            return OperatorType.Divide;
                        default:
                            return OperatorType.NotSupported;
                    }
                }
                return OperatorType.NotAnOperator;
            }
        }
    }
}
