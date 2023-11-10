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
            //�������� ������� GetSumOfDigits �� ������������
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
            // �������� �������, ������� ������� ���������� ������
            List<int> happyNumbers = Fun.FindHappyNumbers();
            Assert.IsNotNull(happyNumbers);
            Assert.IsTrue(happyNumbers.Count > 0);
        }
    }
}