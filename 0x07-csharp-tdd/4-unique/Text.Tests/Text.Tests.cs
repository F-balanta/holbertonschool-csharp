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
        public void Test_WordRepeat()
        {
            string word = new string("catcat");
            int index = Str.UniqueChar(word);
            Assert.AreEqual(index, -1);
        }

        [Test]
        public void Test_EmptyString()
        {
            string word = new string("");
            int index = Str.UniqueChar(word);
            Assert.AreEqual(index, -1);
        }
        [Test]
        public void Test_NoRepeats()
        {
            string word = new string("abcdef");
            int index = Str.UniqueChar(word);
            Assert.AreEqual(index, 0);
        }
        [Test]
        public void Test_AllRepeats()
        {
            string word = new string("aabbcc");
            int index = Str.UniqueChar(word);
            Assert.AreEqual(index, -1);
        }
        [Test]
        public void Test_DifferentWordsNoRepeat()
        {
            string word = new string("cathat");
            int index = Str.UniqueChar(word);
            Assert.AreEqual(index, 0);
        }
    }
}