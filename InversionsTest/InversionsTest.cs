using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inversions;

namespace InversionsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInversions()
        {
            NumberList numberList = new NumberList();
            numberList.Add(2);
            numberList.Add(1);
            numberList.Add(3);
            numberList.Add(2);
            Assert.AreEqual(2, numberList.Inversions());
        }
    }
}
