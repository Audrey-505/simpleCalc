using SimpleCalculatorApp;

namespace SimpleCalculatorAppTests;


    public class SimpleCalculatorTests
    {
        [Theory]
        [InlineData(5, 3, 8)]
        [InlineData(5, -3, 2)]
        [InlineData(-5, 3, -2)]
        public void Add_ShouldReturnCorrectResult(int a, int b, int expected)
        {
            // Act
            int result = SimpleCalculator.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(5, -3, 8)]
        [InlineData(-5, 3, -8)]
        public void Subtract_ShouldReturnCorrectResult(int a, int b, int expected)
        {
            // Act
            int result = SimpleCalculator.Subtract(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 3, 15)]
        [InlineData(5, -3, -15)]
        [InlineData(-5, 3, -15)]
        public void Multiply_ShouldReturnCorrectResult(int a, int b, int expected)
        {
            // Act
            int result = SimpleCalculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(5, -2, -2)]
        [InlineData(-5, 2, -2)]
        public void Divide_ShouldReturnCorrectResult(int a, int b, int expected)
        {
            // Act
            int result = SimpleCalculator.Divide(a, b);

            // Assert
            Assert.Equal(expected, result);
        }
    }
