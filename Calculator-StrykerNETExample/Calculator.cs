namespace Calculator_StrykerNETExample
{
    public class Calculator
    {
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        public int Subtract(int value1, int value2)
        {
            return value1 - value2;
        }

        public int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        public (int Result, int Remainder) Divide(int value1, int value2)
        {
            var result = value1 / value2;
            var remainder = value1 % value2;
            return (result, remainder);
        }
    }
}