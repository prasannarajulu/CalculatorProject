namespace Calculator1
{
    public static class OperationFactory
    {
        public static ICalculator GetOperation(OperatorType n)
        {
            switch (n)
            {
                case OperatorType.Add:
                    return new Addition();

                case OperatorType.Subtract:
                    return new Subtraction();

                case OperatorType.Multiply:
                    return new Multiplication();

                case OperatorType.Divide:
                    return new Division();

                default:
                    return null;
            }
        }
    }
}
