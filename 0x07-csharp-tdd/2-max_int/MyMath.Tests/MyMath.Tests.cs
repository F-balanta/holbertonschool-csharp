using NUnit.Framework;
using System.Collections.Generic;
namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MaxIntegerPositive()
        {
            int[] array = new int[] { 12, 5, 4, 78, 2 };
            List<int> list = new List<int>(array);
            int Result = Operations.Max(list);
            list.Sort();
            int num2 = list[list.Count - 1];
            Assert.AreEqual(num2, Result);

        }
        [Test]
        public void MaxNegativeNumber()
        {
            int[] array = new int[] { -25, 50, 400, -8, -52 };
            List<int> list = new List<int>(array);
            int Result = Operations.Max(list);
            list.Sort();
            int num2 = list[list.Count - 1];
            Assert.AreEqual(num2, Result);
        }
        [Test]
        public void EmptyList()
        {
            List<int> list = new List<int>();
            int number = MyMath.Operations.Max(list);
            Assert.AreEqual(number, 0);
        }
    }
}