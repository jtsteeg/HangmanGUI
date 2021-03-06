using HangmanGUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//include classes to test here

namespace HangmanGUITest
{
    [TestClass]
    public class CharacterGuess_tests
    {
        [TestMethod]
        public void Logic_validCorrectInput_returns2()
        {
            var guessInput = "c";
            var wordBeingGuessed = "cat";
            var expected = 2;

            var sut = new CharacterGuess();

            int result = sut.logic(guessInput, wordBeingGuessed);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Logic_validIncorrectInput_returns3()
        {
            var guessInput = "x";
            var wordBeingGuessed = "cat";
            var expected = 3;

            var sut = new CharacterGuess();

            int result = sut.logic(guessInput, wordBeingGuessed);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Logic_invalidInput_returns1()
        {
            var guessInput = "2";
            var wordBeingGuessed = "cat";
            var expected = 1;

            var sut = new CharacterGuess();

            int result = sut.logic(guessInput, wordBeingGuessed);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Logic_noInput_returns1()
        {
            var guessInput = "";
            var wordBeingGuessed = "cat";
            var expected = 1;

            var sut = new CharacterGuess();

            int result = sut.logic(guessInput, wordBeingGuessed);

            Assert.AreEqual(expected, result);

        }


        [TestMethod]
        public void Logic_multipleInputs_returns1()
        {
            var guessInput = "cat";
            var wordBeingGuessed = "cat";
            var expected = 1;

            var sut = new CharacterGuess();

            int result = sut.logic(guessInput, wordBeingGuessed);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Logic_validCorrectInputInCaps_returns2()
        {
            var guessInput = "C";
            var wordBeingGuessed = "cat";
            var expected = 2;

            var sut = new CharacterGuess();

            int result = sut.logic(guessInput, wordBeingGuessed);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void WordIsInvalid_InputContainsNumber_returnsTrue()
        {
            var guessInput = "cat1";

            var expected = true;

            var sut = new CharacterGuess();

            var result = sut.wordIsInvalid(guessInput);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WordIsInvalid_InputContainsNonLetterCharacter_returnsTrue()
        {
            var guessInput = "ca!t";

            var expected = true;

            var sut = new CharacterGuess();

            var result = sut.wordIsInvalid(guessInput);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WordIsInvalid_InputEmpty_returnsTrue()
        {
            var guessInput = "";

            var expected = true;

            var sut = new CharacterGuess();

            var result = sut.wordIsInvalid(guessInput);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WordIsInvalid_ValidInput_returnsFalse()
        {
            var guessInput = "cat";

            var expected = false;

            var sut = new CharacterGuess();

            var result = sut.wordIsInvalid(guessInput);

            Assert.AreEqual(expected, result);
        }
    }
}