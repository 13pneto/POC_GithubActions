using AutoFixture.Xunit2;
using FluentAssertions;
using POC_GitHubActions;

namespace UnitTests;

public class CalculatorTests
{
    [Theory, AutoData]
    public void Add(int val1, int val2)
    {
        //Arrange
        var expected = val1 + val2;
        
        //Action
        var result = Calculator.Add(val1, val2);

        //Assert
        result.Should().Be(expected);
    } 
    
    [Theory, AutoData]
    public void Subtract(int val1, int val2)
    {
        //Arrange
        var expected = val1 - val2;
        
        //Action
        var result = Calculator.Subtract(val1, val2);

        //Assert
        result.Should().Be(expected);
    }
    
    [Theory, AutoData]
    public void Multiply(int val1, int val2)
    {
        //Arrange
        var expected = val1 * val2;
        
        //Action
        var result = Calculator.Multiply(val1, val2);

        //Assert
        result.Should().Be(expected);
    }
    
    [Theory]
    [InlineData(10,2, 5)]
    [InlineData(25,5, 5)]
    [InlineData(50,25, 2)]
    [InlineData(9.9,3, 3.3)]
    public void Divide(double val1, double val2, double expected)
    {
        //Action
        var result = Calculator.Divide(val1, val2);

        //Assert
        result.ToString("F").Should().Be(expected.ToString("F"));
    }
    
        
    [Theory, AutoData]
    public void Square(int val1)
    {
        //Arrange
        var expected = val1 * val1;
        
        //Action
        var result = Calculator.Square(val1);

        //Assert
        result.Should().Be(expected);
    }
        
    [Theory, AutoData]
    public void Cube(int val1)
    {
        //Arrange
        var expected = val1 * val1 * val1;
        
        //Action
        var result = Calculator.Cube(val1);

        //Assert
        result.Should().Be(expected);
    }
}