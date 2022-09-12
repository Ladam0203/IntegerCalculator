namespace Calculator;

public class IntegerCalculator
{
    public int Result { get; private set; }

    public void Reset()
    {
        Result = 0;
    }

    public void Add(int x)
    {
        try
        {
            Result = checked(Result + x);
        }
        catch (OverflowException)
        {
            throw new ArgumentException("The result would overflow");
        }
    }

    public void Subtract(int x)
    {
        try
        {
            Result = checked(Result - x);
        }
        catch (OverflowException)
        {
            throw new ArgumentException("The result would overflow");
        }
    }

    public void Multiply(int x)
    {
        try
        {
            Result = checked(Result * x);
        }
        catch (OverflowException)
        {
            throw new ArgumentException("The result would overflow");
        }
    }

    public void Divide(int x)
    {
        if (x == 0)
        {
            throw new ArgumentException("Division by zero is not allowed");
        }
        
        Result /= x;
    }

    public void Modulus(int x)
    {
        Result %= x;
    }
}