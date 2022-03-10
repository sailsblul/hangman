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
        List<string> guesses = new List<string>();
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
            bool miss = true;
            char[] result = lblWord.Text.ToCharArray();
            guesses.Add(txtGuess.Text);
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = guesses;
            for (int i = 0; i < word.Length; i++)
            {
                if (txtGuess.Text[0] == word[i])
                {
                    miss = false;
                    result[2 * i] = txtGuess.Text[0];
                }
            }
            if (miss)
            {
                lives -= 1;
                switch (lives)
                {
                    case 0:
                        EndGame();
                        break;
                }
            }
            else
            {
                lblWord.Text = new String(result);
                if (!lblWord.Text.Contains("_"))
                    EndGame();
            }
            txtGuess.Clear();
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {
            if (txtGuess.Text.Length == 0 || (!char.IsLetter(txtGuess.Text[0])) || guesses.Contains(txtGuess.Text))
                btnGuess.Enabled = false;
            else
                btnGuess.Enabled = true;
        }
        public void EndGame()
        {

        }
    }
}
