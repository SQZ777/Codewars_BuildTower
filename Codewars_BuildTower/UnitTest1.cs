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
            Assert.AreEqual(string.Empty, Kata.PrintSpace(1));
        }

        [TestMethod]
        public void PrintSpace_Input_2_Should_Be_1Space()
        {
            Assert.AreEqual(" ", Kata.PrintSpace(2));
        }

        [TestMethod]
        public void Input_1_Should_Be_1star()
        {
            CollectionAssert.AreEqual(new string[] { "*" }, Kata.TowerBuilder(1));
        }

        [TestMethod]
        public void Input_2_Should_Be_1starAnd3Star()
        {
            CollectionAssert.AreEqual(new string[]{"*"," *** "},Kata.TowerBuilder(2));
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
            return string.Join("", Enumerable.Repeat(" ", n - 1));
        }

        public static string[] TowerBuilder(int n)
        {
            return new string[] { PrintSpace(n) + PrintStar(n) + PrintSpace(n) };
        }
    }
}
