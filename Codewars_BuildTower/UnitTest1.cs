using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_BuildTower
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PrintStar_Input_1_Should_Be_1Star()
        {
            Assert.AreEqual("*", Kata.PrintStar(1));
        }

        [TestMethod]
        public void PrintStar_Input_2_Should_Be_3Star()
        {
            Assert.AreEqual("***", Kata.PrintStar(2));
        }

        [TestMethod]
        public void PrintSpace_Input_1_Should_Be_StringEmpty()
        {
            Assert.AreEqual(string.Empty,Kata.PrintSpace(1));
        }
    }

    public class Kata
    {
        public static string PrintStar(int n)
        {
            return string.Join("", Enumerable.Repeat("*", 2 * n - 1));
        }

        public static string PrintSpace(int n)
        {
            return string.Empty;
        }
    }
}
