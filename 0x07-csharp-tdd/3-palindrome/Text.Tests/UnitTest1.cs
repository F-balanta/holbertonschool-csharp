using NUnit.Framework;
namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void IsPalindrome()
        {
            string str = "ococo";
            bool result = Text.Str.IsPalindrome(str);
            Assert.IsTrue(result);
        }
        [Test]
        public void StringVoid()
        {
            string str = "";
            bool value = Text.Str.IsPalindrome(str);
            Assert.IsFalse(!value);
        }
        [TestCase(" SOCOS ")]
        [TestCase("*.Kayak*.")]
        [TestCase("Deified")]
        [TestCase("Noon")]
        [TestCase("Mo     Om")]
        [TestCase("Racecar")]
        [TestCase("Dad")]
        [TestCase("Poop")]
        [TestCase("level")]
        [TestCase("A man, a plan, a canal: Panama")]
        public void MoreTest(string str)
        {
            bool value = Text.Str.IsPalindrome(str);
            Assert.IsTrue(value);
        }
        [TestCase("HOlberton")]
        [TestCase("School")]
        [TestCase("Ramara")]
        [TestCase("MoreTest")]
        [TestCase(".df-")]
        [TestCase("AEIOU")]
        [TestCase("String")]
        [TestCase("SW")]
        public void StringNoIsPalindrome(string str)
        {
            bool value = Text.Str.IsPalindrome(str);
            Assert.IsTrue(!value);
        }
    }
}