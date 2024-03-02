using NUnit.Framework;

namespace Lab3_Test
{
    public class CalcTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddTest()
        {
            const double r = 5;
            const double alfa = 180;
            const double expected = 39.26990817;

            var result = Lab3.Lib.Circular_Sector.Calc(r, alfa);

            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}