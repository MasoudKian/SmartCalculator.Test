using SmartCalculator.Test;

namespace SmartCalculator.Tests;

public class CalculatorTests
{
    private readonly Calculator _calc = new();

    [Fact]
    public void Add_TwoNumbers_ReturnsSum()
    {
        var result = _calc.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Subtract_TwoNumbers_ReturnsDifference()
    {
        var result = _calc.Subtract(5, 3);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Multiply_TwoNumbers_ReturnsProduct()
    {
        var result = _calc.Multiply(4, 3);
        Assert.Equal(12, result);
    }

    [Fact]
    public void Divide_TwoNumbers_ReturnsQuotient()
    {
        var result = _calc.Divide(10, 2);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Divide(10, 0));
    }

    [Theory]
    [InlineData(2, 3, 8)]
    [InlineData(4, 0.5, 2)]
    public void Power_BaseAndExponent_ReturnsResult(double b, double e, double expected)
    {
        var result = _calc.Power(b, e);
        Assert.Equal(expected, result, 5);
    }
}
