using Calculator;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void AddTwoValidNumber()
    {
        //ARRANGE
        IntegerCalculator calculator = new();
        int firstAddedValue = 123;
        int firstExpectedValue = firstAddedValue;

        int secondAddedValue = 321;
        int secondExpectedValue = firstAddedValue + secondAddedValue;
        
        //ACT
        calculator.Add(firstAddedValue);
        
        //ASSESS
        Assert.Equal(firstExpectedValue, calculator.Result);
        
        //ACT AGAIN
        calculator.Add(secondAddedValue);
        
        //ASSESS AGAIN
        Assert.Equal(secondExpectedValue, calculator.Result);
    }

    [Fact]
    public void AddWithOverflowExpectArgumentException()
    {
        IntegerCalculator calculator = new IntegerCalculator();
        calculator.Add(int.MaxValue);

        var ex = Assert.Throws<ArgumentException>(() => calculator.Add(1));
        Assert.Equal("The result would overflow", ex.Message);
    }
    
    [Fact]
    public void MultiplyWithOverflowExpectArgumentException()
    {
        IntegerCalculator calculator = new IntegerCalculator();
        calculator.Add(int.MaxValue);

        var ex = Assert.Throws<ArgumentException>(() => calculator.Multiply(2));
        Assert.Equal("The result would overflow", ex.Message);
    }
    
    [Fact]
    public void MultiplyWithNegativeOverflowExpectArgumentException()
    {
        IntegerCalculator calculator = new IntegerCalculator();
        calculator.Add(int.MinValue);

        var ex = Assert.Throws<ArgumentException>(() => calculator.Multiply(-2));
        Assert.Equal("The result would overflow", ex.Message);
    }
    
    //TODO: Tests for Divide and modulus
}