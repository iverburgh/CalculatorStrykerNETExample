namespace Calculator_StrykerNETExample;

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
        if (value2 == 0)
        {
            throw new DivideByZeroException();
        }
        var result = value1 / value2;
        var remainder = result % value2;
        return (result, remainder);
    }
}