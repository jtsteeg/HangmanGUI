using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGUI
{
    public class CharacterGuess
    {
        char letter = ' '; 
        public int logic(string input, string mysteryWord)
        {
            if(input.Length > 1 || input.Length < 1)
            {
                return 1;
            }
            letter = input.ToLower().ToCharArray()[0];

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
