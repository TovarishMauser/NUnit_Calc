using NUnit.Framework;
using System;

namespace Calculator1NUnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        Calculator.Calculator calc = new Calculator.Calculator();

        [Test]
        public void Additional_MustBeCorrect()
        {
            Assert.AreEqual(3, calc.Additional(1, 2));
        }
        [Test]
        public void Subtraction_MustBeCorrect()
        {
            Assert.AreEqual(-1, calc.Subtraction(1, 2));
        }
        [Test]
        public void Multiplication_MustBeInRange()
        {
            Assert.AreEqual(4, calc.Miltiplication(2, 2));

        }
        [Test]
        public void Division_MustBeCorrect()
        {
            Assert.AreEqual(3, calc.Division(6, 2));
        }
        [Test]
        public void Division_DivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Division(0, 0));
        }
    }
}