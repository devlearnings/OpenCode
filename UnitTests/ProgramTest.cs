using ConsoleMachineTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ProgramTest
    {
        private readonly char[] _delimeter = { ',', '\n' };

        [TestMethod]
        public void TestSum_Sum_NoValues_ReturnZero()
        {
            var expectedResult = 0;
            var actualResult = Program.Sum(_delimeter,string.Empty);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestSum_Sum_PassVaue1_ReturnResult1()
        {
            var expectedResult = 1;
            var actualResult = Program.Sum(_delimeter,"1");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestSum_Sum_PassVaue2And3_ReturnResult5()
        {
            var expectedResult = 5;
            var actualResult = Program.Sum(_delimeter,"2,3");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestSum_Sum_PassMultipleVaue2345_ReturnResult14()
        {
            var expectedResult = 14;
            var actualResult = Program.Sum(_delimeter,"2,3,4,5");
            Assert.AreEqual(expectedResult, actualResult);
        }

        public void TestSum_GetInputValue_PassMulipleDelimeter_ReturnResult14()
        {
            var expectedResult = "2,3,4";
            var actualResult = Program.GetInputValue("2\n3,4");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestSum_GetDelimeter_PassDynamicDelimeter()
        {
            char[] expectedResult = {';'};
            var actualResult = Program.GetDelimeter("\\;\\3;4;5 ");
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }

        [TestMethod]
        public void TestSum_GetInputValue_AllPositive()
        {
            var expectedResult = "2;3;4";
            var actualResult = Program.GetInputValue("\\;\\2;3;4");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestSum_GetInputValue_ContainsNegative()
        {
            var expectedResult = "Error: Negative numbers (-3,-5) not allowed.";
            var actualResult = Program.GetInputValue("\\;\\2;-3;4;-5");
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }

        [TestMethod]
        public void TestSum_Sum_PassGreaterThan1000()
        {
            var expectedResult = 11;
            var actualResult = Program.Sum(_delimeter, "2,3000,4,5");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMultiply_Pass2And4And3_Return6()
        {
            var expectedResult = 24;
            var actualResult = Program.Multiply(_delimeter, "2,4,3");
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
