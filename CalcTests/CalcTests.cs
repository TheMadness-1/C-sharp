using NUnit.Framework;
using Operations;

namespace CalcTests
{
    public class CalcTests
    {

        [Test]
        public void AddTest()
        {
            Assert.AreEqual(5, MathLogic.Add(2, 3));
        }
        [Test]
        public void SubTest()
        {
            Assert.AreEqual(5, MathLogic.Sub(8, 3));
        }
        [Test]
        public void MultTest()
        {
            Assert.AreEqual(5, MathLogic.Mult(2.5f, 2));
        }
        [Test]
        public void DivTest()
        {
            Assert.AreEqual(5, MathLogic.Div(10, 2));
        }
    }
}