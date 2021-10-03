using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGUI
{
    class WordLibrary
    {
        public List<string> wordSet { get; set; }
        public WordLibrary()
        {
            wordSet = new List<string>() { "horse", "chicken", "llama", "cow", "duck", };
        }

        public string GetRandomWord()
        {
            var random = new Random();
            var i = random.Next(0, wordSet.Count - 1);
            return wordSet[i];
        }
    }
}
