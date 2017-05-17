using NUnit.Framework;

namespace Calculator.NUnitTest
{
    [TestFixture]
    public class CalculatorOpTest
    {
        CalculatorOp sut;
        [TestFixtureSetUp]
        public void TestSetup()
        {
            sut = new CalculatorOp();
        }
        [Test]  
        public void addonetwoisthree()
        { 
            //Act
            double  result = sut.Add(1, 2);
            //assert
            Assert.AreEqual(3, result);
        }
        [Test]
        public void substractfourfiveisminone()
        {
            //Act
            double result = sut.Substract (4, 5);
            //assert
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void mulonethreeisfour()
        {
            //Act
            double  result = sut.Mult(6, 7);
            //assert
            Assert.AreEqual(42, result);
        }
        [Test]
        public void Diviioneightnineis()
        {
            //Act
            double result = sut.Division (9,0.5);
            //assert
            Assert.AreEqual(18, result);
        }

    }

}
