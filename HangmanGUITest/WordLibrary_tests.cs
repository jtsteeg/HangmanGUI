using HangmanGUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//include classes to test here

namespace HangmanGUITest
{
    [TestClass]
    public class WordLibrary_tests
    {
        [TestMethod]
        public void GetRandomWord_Run_ReturnsString()
        {

            var sut = new WordLibrary();

            var actual = sut.GetRandomWord();

            Assert.IsInstanceOfType(actual, typeof(string));
            
        }

        [TestMethod]
        public void GetWordList_Run_ReturnsListOfString()
        {

            var sut = new WordLibrary();

            var actual = sut.wordSet;

            foreach (var item in actual)
            {
                Assert.IsInstanceOfType(item, typeof(string));
            }

        }
    }
}
