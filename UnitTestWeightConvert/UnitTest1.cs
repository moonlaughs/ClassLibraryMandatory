using ClassLibraryMandatory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestWeightConvert
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            WeightConverter obj = new WeightConverter();

            double expected = 0.1410958478;
            double actual = obj.GramToOunces(4);
            double delta = 0.0000058478;

            Assert.AreEqual(expected, actual, delta);

            double expected2 = 198.44664;
            double actual2 = obj.OuncesToGram(7);
            double delta2 = 0.0006;

            Assert.AreEqual(expected2, actual2, delta2);
        }
    }
}
