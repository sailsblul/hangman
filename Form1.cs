using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman
{
    public partial class Hangman : Form
    {
        Random gen = new Random();
        string[] words = new string[] { "BONGO", "PENGUIN" };
        string word;
        List<char> guesses = new List<char>();
        int lives;
        public Hangman()
        {
            InitializeComponent();
        }

        private void Hangman_Load(object sender, EventArgs e)
        {
            Setup();
        }

        public void Setup()
        {
            lives = 6;
            word = words[gen.Next(words.Length)];
            lblWord.Text = "_";
            for (int i = 1; i < word.Length; i++)
                lblWord.Text += " _";
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            foreach (char letter in word)
            {

            }
        }
    }
}
