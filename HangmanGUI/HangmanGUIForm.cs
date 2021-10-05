using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace HangmanGUI
{
    public partial class HangmanGUIForm : Form
    {
        string word = "";
        
        List<Label> letterDisplay = new List<Label>();
        int amount = 0;  
       
        public HangmanGUIForm()
        {
            InitializeComponent();
            
            DrawLines();
        }



        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LivesLeftLabel_Click(object sender, EventArgs e)
        {

        }

        string WordBank()
        {
            WebClient wc = new WebClient();
            string wordlist = wc.DownloadString("https://www.spelling-words-well.com/support-files/fourth-grade-spelling-words.pdf");
            string[] words = wordlist.Split("\n");
            Random ran = new Random();
            return words[ran.Next(0, words.Length - 1)];
        }

        private void DrawLines()
        {
            word = WordBank();
            char[] mysteryList = word.ToCharArray();
            int spacing = 650 / mysteryList.Length - 1;
            for (int i = 0; i < mysteryList.Length - 1; i++)
            {
                letterDisplay.Add(new Label());
                letterDisplay[i].Location = new Point((i * spacing) + 10, 80);
                letterDisplay[i].Text = "*";
                letterDisplay[i].Parent = MysteryWordBox;
                letterDisplay[i].BringToFront();
                letterDisplay[i].CreateControl();
            }

            label1.Text = "Word Lenght: " + (mysteryList.Length).ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            char letter = textBox1.Text.ToLower().ToCharArray()[0];
            if (!char.IsLetter(letter))
            {
                MessageBox.Show("You can only submit letter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (word.Contains(letter))
            {
                char[] letters = word.ToCharArray();
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == letter)
                        letterDisplay[i].Text = letter.ToString();
                }
                foreach (Label l in letterDisplay)
                    if (l.Text == "*") return;
                MessageBox.Show("You have won", "Congratulations");
                ResetGame();
            }
            else
            {
                MessageBox.Show("The letter that you guessed is not in the word", "Missed word");
                label2.Text += " " + letter.ToString() + ",";
                amount ++;
                if (amount == 8)
                {
                    MessageBox.Show("Sorry you lose, the word was" + word);
                    ResetGame();
                }
            }
        }
        void ResetGame()
        {
            WordBank();
            DrawLines();
            label2.Text = "Missed: ";
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == word)
            {
                MessageBox.Show("You have Won", "Congratulations");
                ResetGame();
            }
            else
            {
                MessageBox.Show("Thw word you guessed is wrong", "You lose!");

            }
        }
    }
}
