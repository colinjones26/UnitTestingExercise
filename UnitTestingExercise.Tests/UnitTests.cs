using System;
using UnitTestingExercise;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        // Step 3: Add a test for the Add method
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(1, 1, 1, 3)]
        [InlineData(0, 0, 0 , 0)]
        [InlineData(-1,-1,-1,-3)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            // Arrange
            // Create a Calculator object
            Calculator calculator = new Calculator();

            // Act
            // Call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            int actual = calculator.Add(num1, num2, num3);

            // Assert
            // Assert that the actual result matches the expected result
            Assert.Equal(expected, actual);
        }

        // Step 5: Add a test for the Subtract method
        [Theory]
        [InlineData(10, 3, 7)]
        [InlineData(4, 3, 1)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, -5, 0)]
        public void SubtractTest(int num1, int num2, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Subtract(num1, num2);

            // Assert
            Assert.Equal(expected, actual); // Assert that the actual result matches the expected result
        }

        // Step 7: Add a test for the Multiply method
        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(4, 5, 20)]
        [InlineData(0, 5, 0)]
        [InlineData(-2, 3, -6)]
        [InlineData(7, 7, 49)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Multiply(num1, num2);

            // Assert
            Assert.Equal(expected, actual); // Assert that the actual result matches the expected result
        }

        // Step 9: Add a test for the Divide method
        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(20, 4, 5)]
        [InlineData(9, 3, 3)]
        [InlineData(15, 5, 3)]
        [InlineData(100, 10, 10)]
        public void DivideTest(int num1, int num2, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Divide(num1, num2);

            // Assert
            Assert.Equal(expected, actual); // Assert that the actual result matches the expected result
        }
    }
}
