using System;
using Xunit;
using Math;

namespace xUnit
{

    public class SmokeTest2
    {
       
        int firstNumber = Int32.Parse(Data.firstNumber1);
        int secondNumber = Int32.Parse(Data.secondNumber1);

        Calculator calc = new Calculator();

       
        [Fact]
        public void TestCheckSum1()
        {
            Assert.Equal(((long)firstNumber + (long)secondNumber), calc.Sum(firstNumber, secondNumber));
        }

        [Fact]
        public void TestCheckSum2()
        {
            Assert.Equal(((long)secondNumber + (long)firstNumber), calc.Sum(secondNumber, firstNumber));
        }


        [Fact]
        public void TestCheckSubtraction1()
        {
            Assert.Equal(((long)firstNumber - (long)secondNumber), calc.Subtraction(firstNumber, secondNumber));
        }

        [Fact]
        public void TestCheckSubtraction2()
        {
            Assert.Equal(((long)secondNumber - (long)firstNumber), calc.Subtraction(secondNumber, firstNumber));
        }

        [Fact]
        public void TestCheckMultiplication1()
        {
            Assert.Equal(((long)firstNumber * (long)secondNumber), calc.Multiplication(firstNumber, secondNumber));
        }


        [Fact]
        public void TestCheckMultiplication2()
        {
            Assert.Equal(((long)secondNumber * (long)firstNumber), calc.Multiplication(secondNumber, firstNumber));
        }

        [Fact]
        public void TestCheckDivision1()
        {
            Assert.Equal(((double)firstNumber / (double)secondNumber), calc.Division(firstNumber, secondNumber));
        }

        [Fact]
        public void TestCheckDivision2()
        {
            Assert.Equal(((double)secondNumber / (double)firstNumber), calc.Division(secondNumber, firstNumber));
        }
    }
}

