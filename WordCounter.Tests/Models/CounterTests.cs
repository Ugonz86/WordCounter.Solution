using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WordCounter.Models
{
    [TestClass]
    public class RepeatCounterTests
    {
        [TestMethod]
        public void ValidInputFullWord_True()
        {
            bool output = RepeatCounter.ValidInput("brain");
            Assert.AreEqual(true, output);
        }

        [TestMethod]
        public void SpaceInWord_False()
        {
            bool output = RepeatCounter.ValidInput("br ain");
            Assert.AreEqual(false, output);
        }

        [TestMethod]
        public void SpecialCharacters_False()
        {
            bool output = RepeatCounter.ValidInput("br@in");
            Assert.AreEqual(false, output);
        }

        [TestMethod]
        public void NoSpecialCharactersOrPunctuation_3()
        {
            RepeatCounter newCounter = new RepeatCounter("brain", "The brain is like a muscle I like to call super brain and it goes to the brain gym.");
            int output = newCounter.characterCount();
            Assert.AreEqual(3, output);
        }

        [TestMethod]
        public void PunctuationInSentence_3()
        {
            RepeatCounter newCounter = new RepeatCounter("brain", "The brain, like a muscle, needs a brain workout, good brain care and rest!");
            int output = newCounter.characterCount();
            Assert.AreEqual(3, output);
        }

         [TestMethod]
        public void NumberInWord_False()
        {
            bool output = RepeatCounter.ValidInput("br4in");
            Assert.AreEqual(false, output);
        }

        [TestMethod]
        public void EmptyInput_False()
        {
            bool output = RepeatCounter.ValidInput(" ");
            Assert.AreEqual(false, output);
        }

        [TestMethod]
        public void FullWordsOnly_0()
        {
            RepeatCounter newCounter = new RepeatCounter("brain", "brainstorm");
            int output = newCounter.characterCount();
            Assert.AreEqual(0, output);
        }
    }
}