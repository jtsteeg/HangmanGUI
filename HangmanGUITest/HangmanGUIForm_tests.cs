using HangmanGUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//include classes to test here

namespace HangmanGUITest
{
    [TestClass]
    public class HangmanGUIForm_tests
    {
        [TestMethod]
        public void DrawLines_Run_DisplayedMatchesLength()
        {
            var sut = new HangmanGUIForm();


            var mysteryWordLength = sut.mysteryWord.Length;
            var displayedCharacters = sut.letterDisplay.Count;


            Assert.AreEqual(mysteryWordLength, displayedCharacters);
        }

        [TestMethod]
        public void DrawLines_Run_DisplayedMatchesLength()
        {
    
        }
    }
}
