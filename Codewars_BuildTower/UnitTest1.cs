using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_BuildTower
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PrintStar_Input_1_Should_Be_1Star()
        {
            Assert.AreEqual(new string[] { "*" }, Kata.PrintStar(1));
    }
}

public class Kata
{
    public static string[] PrintStar(int n)
    {
        throw new System.NotImplementedException();
    }
}
}
