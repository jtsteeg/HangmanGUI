using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGUI
{
    public partial class HangmanGUI : Form
    {

        List<Label> letterDisplay = new List<Label>();
        public HangmanGUI()
        {
            InitializeComponent();
            
            drawLines();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

         private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LivesLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void drawLines()
        {
            WordLibrary WL = new WordLibrary();
            string mysteryWord = WL.GetRandomWord();
            char[] mysteryList = mysteryWord.ToCharArray();
            int spacing = 800 / mysteryList.Length;
            for (int i = 0; i < mysteryList.Length; i++)
            {
                letterDisplay.Add(new Label());
                letterDisplay[i].Location = new Point((i * spacing) + 10, 80);
                letterDisplay[i].Text = "*";
                letterDisplay[i].Parent = MysteryWordBox;
                letterDisplay[i].BringToFront();
                letterDisplay[i].CreateControl();
            }
        }
    }
}
