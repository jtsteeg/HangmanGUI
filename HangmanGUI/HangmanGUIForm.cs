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
              
        
        int incorrectTries = 0;
        WordLibrary wordPool = new WordLibrary();
        CharacterGuess evaluater = new CharacterGuess();

        public List<Label> letterDisplay { get; set; }        
        public String mysteryWord { get; set; }

        public HangmanGUIForm()
        {
            InitializeComponent();
            letterDisplay = new List<Label>();
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

        private void DrawLines()
        {
            mysteryWord = wordPool.GetRandomWord();
            char[] mysteryList = mysteryWord.ToCharArray();
            int spacing = 650 / mysteryList.Length;
            for (int i = 0; i < mysteryList.Length; i++)
            {
                letterDisplay.Add(new Label());
                letterDisplay[i].Location = new Point((i * spacing) + 10, 80);
                letterDisplay[i].Text = "*";
                letterDisplay[i].Parent = MysteryWordBox;
                letterDisplay[i].BringToFront();
                letterDisplay[i].CreateControl();
            }

            label1.Text = "Word Length: " + mysteryWord.Length;
        }

        public void guessButton_Click(object sender, EventArgs e)
        {
            char letter = textBox1.Text.ToLower().ToCharArray()[0];
            int result = evaluater.logic(textBox1.Text, mysteryWord);


            if (result == 1)
            {
                MessageBox.Show("You can only submit a single letter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (result == 2)
            {
                char[] letters = mysteryWord.ToCharArray();
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == letter)
                        letterDisplay[i].Text = letter.ToString();
                }
                foreach (Label l in letterDisplay)
                    if (l.Text == "*") return;
                MessageBox.Show("You have won", "Congratulations");
                System.Environment.Exit(1);
            }
            else
            {
                MessageBox.Show("The letter that you guessed is not in the word", "Missed word");
                label2.Text += " " + letter.ToString() + ",";
                incorrectTries ++;
                if (incorrectTries == 8)
                {
                    MessageBox.Show("Sorry you lose, the word was: " + mysteryWord);
                    System.Environment.Exit(1);
                }
            }
        }

        //restarts game, not yet implemented
        void ResetGame()
        {
            DrawLines();
            label2.Text = "Missed: ";
            textBox1.Text = "";
        }

        private void submitWordButton_Click(object sender, EventArgs e)
        {

            if (evaluater.wordIsInvalid(textBox2.Text))
            {
                MessageBox.Show("You have to guess a real word!");
                return;
            }
            else if (textBox2.Text.ToLower() == mysteryWord.ToLower())
            {
                MessageBox.Show("You have Won", "Congratulations");
                System.Environment.Exit(1);
            }
            else
            {
                MessageBox.Show("The word you guessed is wrong", "You lose!");
                System.Environment.Exit(1);
            }
        }
    }
}
