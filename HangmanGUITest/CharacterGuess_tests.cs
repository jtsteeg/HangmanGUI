using HangmanGUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//include classes to test here

namespace HangmanGUITest
{
    [TestClass]
    public class CharacterGuess_tests
    {
        [TestMethod]
        public void Logic_validInput_returns2()
        {
            var guessInput = 'c';
            var wordBeingGuessed = "cat";
            var expected = 2;

            var sut = new CharacterGuess();

            int result = sut.logic(guessInput, wordBeingGuessed);

            Assert.AreEqual(expected, result);

        }

    }
}