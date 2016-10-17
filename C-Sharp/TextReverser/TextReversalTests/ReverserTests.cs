using Microsoft.VisualStudio.TestTools.UnitTesting;
using static TextReversal.Reverser;

namespace TextReversalTests
{
    [TestClass]
    public class ReverserTests
    {
        [TestMethod]
        public void TestZeroLengthString()
        {
            var input = string.Empty;

            var output = Reverse(input);

            Assert.AreEqual(string.Empty, output);
        }

        [TestMethod]
        public void TestReversalIsReflexive()
        {
            var input = "apple";

            var output = Reverse(Reverse(input));

            Assert.AreEqual(input, output);
        }

        [TestMethod]
        public void TestReverses()
        {
            var input = "apple";

            var output = Reverse(input);

            Assert.AreEqual("elppa", output);
        }
    }
}
