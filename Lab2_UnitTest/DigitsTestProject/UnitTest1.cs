using Lab2_UnitTest;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace DigitsTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetSumOfDigits()
        {
            //провер€ю функцию GetSumOfDigits на корректность
            int result0 = Fun.GetSumOfDigits(123);
            Assert.AreEqual(6, result0);
            int result1 = Fun.GetSumOfDigits(1010);
            Assert.AreEqual(2, result1);
            int result2 = Fun.GetSumOfDigits(4444);
            Assert.AreEqual(16, result2);
        }
        [TestMethod]
        public void TestFindHappyNumbers()
        {
            // ѕровер€ю функцию, котора€ находит счастливые номера
            List<int> happyNumbers = Fun.FindHappyNumbers();
            Assert.IsNotNull(happyNumbers);
            Assert.IsTrue(happyNumbers.Count > 0);
        }
    }
}