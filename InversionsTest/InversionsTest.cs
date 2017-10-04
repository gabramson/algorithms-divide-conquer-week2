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
            Assert.AreEqual(1, numberList.Inversions());
        }
    }
}
