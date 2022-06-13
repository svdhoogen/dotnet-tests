using FluentAssertions;
using Xunit;

namespace TestCalculator.UnitTests;

public class CalculationsTest
{
    [Fact]
    public void Sum_InputIs1And2_Is3()
    {
        // Arrange
        var calculations = CreateDefaultCalculations();
        var a = 1;
        var b = 2;

        // Act
        var c = calculations.Sum(a, b);

        // Assert
        c.Should().Be(3);
    }
    
    [Theory]
    [InlineData(0, 2, 0)]
    [InlineData(15, 3, 45)]
    public void Multiply_TwoNumbers_ReturnsMultipliedNumbers(int a, int b, int expected)
    {
        // Arrange
        var calculations = CreateDefaultCalculations();

        // Act
        var c = calculations.Multiply(a, b);

        // Assert
        c.Should().Be(expected);
    }

    private static Calculations CreateDefaultCalculations() => new();
}