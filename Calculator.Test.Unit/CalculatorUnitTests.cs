using System.Dynamic;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class Tests
    {

        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        [Test]
        public void Add_a_plus_b()
        {
            //arrange
            //sat i Setup
            //var _uut = new Calculator(); 
            //act
            var result = _uut.Add(11, 32);
            //assert
            Assert.AreEqual(43, result);
        }


        //test flere resultater a + b
        [TestCase(11, 11, 22)]
        [TestCase(41, 35, 76)]
        [TestCase(4, 17, 21)]
        [TestCase(10, 50, 60)]
        [TestCase(12, 112, 124)]
        [TestCase(19, 44, 63)]
        public void Add_a_plus_b(double a, double b, double result)
        {
            var act = _uut.Add(a, b);
            Assert.That(act, Is.EqualTo(result));
        }

        //test flere resultater a - b
        [TestCase(11, 42, -31)]
        [TestCase(5, 5, 0)]
        [TestCase(67, 50, 17)]
        public void Subtract_a_minus_b(double a, double b, double result)
        {
            var act = _uut.Subtract(a, b);
            Assert.That(act, Is.EqualTo(result));
        }

        [TestCase(4,4,16)]
        [TestCase(13, 11, 143)]
        [TestCase(9,7,63)]
        public void Multiply_a_and_b(double a, double b, double result)
        {
            var act = _uut.Multiply(a, b);
            Assert.That(act, Is.EqualTo(result));
        }

        [TestCase(2, 2, 4)]
        [TestCase(9, 2, 81)]
        [TestCase(1, 2, 1)]
        public void Power_a_and_b(double x, double exp, double result)
        {
            var act = _uut.Power(x, exp);
            Assert.That(act, Is.EqualTo(result));
        }

    }
}