using Labb3.XUnit;
using Xunit;

namespace CalculatorTest
{
    public class CalculatorTest
    {
        [Fact]
        public void Addition_5_plus_6_should_be_11()
        {
            Calculator test = new Calculator
            {
                _FirstNumber = 5,
                _SecondNumber = 6
            };

            var actual = test.Addition(test);
            var expected = 11;

            Assert.Equal(actual._Result, expected);
        }


        [Theory]
        [InlineData(5, 1.5, 6.5)]
        [InlineData(6, -4, 2)]
        [InlineData(10, 6, 16)]
        [InlineData(16, 10, 26)]
        [InlineData(27, 10, 37)]
        public void Addition_Test(decimal firstnumber, decimal secondnumber, decimal result)
        {
            Calculator calculator = new Calculator
            {
                _FirstNumber = firstnumber,
                _SecondNumber = secondnumber,
            };

            var actual = calculator.Addition(calculator);
     


            Assert.Equal(actual._Result, result);
        }


        
        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(1.8, 0.6, 1.2)]
        [InlineData(10, -7, 17)]
        [InlineData(10.2 ,8, 2.2)]
        [InlineData(1.0, 9, -8)]
        public void Substraktion(decimal firstnumber, decimal secondnumber, decimal result)
        {
            Calculator calculator = new Calculator
            {
                _FirstNumber = firstnumber,
                _SecondNumber = secondnumber,
            };

           
            var actual = calculator.Substraktion(calculator);

            Assert.Equal(result, actual._Result);
        }

        [Theory]
        [InlineData(10, 3.2 , 3.125)]
        [InlineData(10, 2.5, 4)]
        [InlineData(12.4, 4, 3.1)]
        [InlineData(12, -6, -2)]
        [InlineData(-12, 0, 0)]
        public void Division_Test(decimal firstnumber, decimal secondnumber, decimal result)
        {
            Calculator calculator = new Calculator
            {
                _FirstNumber = firstnumber,
                _SecondNumber = secondnumber,
            };

            var actual = calculator.Division(calculator);

            Assert.Equal(result, actual._Result);
        }

        [Theory]
        [InlineData(12, 5, 60)]
        [InlineData(10, 2.5, 25)]
        [InlineData(12.4, 4, 49.6)]
        [InlineData(12, -6, -72)]
        [InlineData(-12, 6, -72)]
        public void Multiplikation_Test(decimal firstnumber, decimal secondnumber, decimal result)
        {
            Calculator calculator = new Calculator
            {
                _FirstNumber = firstnumber,
                _SecondNumber = secondnumber,
            };

            var actual = calculator.Multiplikation(calculator);

            Assert.Equal(result, actual._Result);
        }

        [Fact]
        public void Check_If_Result_Calculations_String_Is_Equal_To_Expected_String()
        {
            Calculator calculator = new Calculator
            {
                _FirstNumber = 1,
                _SecondNumber = 1,
                _MatematikSign="+",
                _Result = 2
            };

            string test = calculator.Result(calculator);
            string expected = "1 + 1 = 2";

            Assert.Equal(expected, test);      
        }
    }
}