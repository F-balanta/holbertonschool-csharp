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
        public void Test_OneWord()
        {
            string word = new string("yummy");
            int total = Str.CamelCase(word);
            Assert.AreEqual(total, 1);
        }

        [Test]
        public void Test_TwoWords()
        {
            string word = new string("yummyFood");
            int total = Str.CamelCase(word);
            Assert.AreEqual(total, 2);
        }

        [Test]
        public void Test_WholeSentence()
        {
            string word = new string("theBestThingToEatIsYummyFood");
            int total = Str.CamelCase(word);
            Assert.AreEqual(total, 8);
        }

        [Test]
        public void Test_EmptyString()
        {
            string word = new string("");
            int total = Str.CamelCase(word);
            Assert.AreEqual(total, 0);
        }
    }
}