using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGUI
{
    public class CharacterGuess
    {
        public char guessChar { get; set; }
        //public string mysteryWord { get; set; }

        public CharacterGuess()
        {
 
        }

        public int logic(char letter, string mysteryWord)
        {

            if (!char.IsLetter(letter))
            {
                return 1;
            }
            else if (mysteryWord.Contains(letter))
            {
                return 2;
            }
            else
            {
                return 3;              
            }
        }

    }
}
