using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 2, 3, 7)]
        [InlineData(2, 4, 6, 12)]
        [InlineData(-2, 2, 2, 2)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(8, 7, 15, 30)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object

            var calculator = new Calculator();


            //Act


            var actual = calculator.Add(num1,num2,num3);
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 0)]
        [InlineData(12, 4, 8)]
        [InlineData(2,6, -4)]
        [InlineData(0, 0, 0)]
        //Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange

            var calculator = new Calculator();

            //Act

            var actual = calculator.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(2, 1, 2)]
        [InlineData(-4, 2, -8)]
        [InlineData(0, 0, 0)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange

            var calculator = new Calculator();

            //Act

            var actual = calculator.Multiply(num1, num2);

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(2, 1, 2)]
        [InlineData(-4, 2, -2)]
        [InlineData(0, 0, 0)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            var actual = calculator.Divide(num1, num2);
            //Assert

            Assert.Equal(expected, actual);
        }

    }
}
