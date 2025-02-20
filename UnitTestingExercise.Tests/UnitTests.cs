using System;
using UnitTestingExercise;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        // Step 3: Add a test for the Add method
        [Theory]
        [InlineData(2, 3, 5, 10)] // Add test data
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
        [InlineData(10, 3, 7)] // Add test data (minuend: 10, subtrahend: 3, expected result: 7)
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Subtract(minuend, subtrahend);

            // Assert
            Assert.Equal(expected, actual); // Assert that the actual result matches the expected result
        }

        // Step 7: Add a test for the Multiply method
        [Theory]
        [InlineData(2, 3, 6)]   // Multiply 2 * 3, expected result: 6
        [InlineData(4, 5, 20)]  // Multiply 4 * 5, expected result: 20
        [InlineData(0, 5, 0)]   // Multiply 0 * 5, expected result: 0
        [InlineData(-2, 3, -6)] // Multiply -2 * 3, expected result: -6
        [InlineData(7, 7, 49)]  // Multiply 7 * 7, expected result: 49
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
