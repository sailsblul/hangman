using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace hangman
{
    public partial class Hangman : Form
    {
        Random gen = new Random();
        string[] words = File.ReadAllLines(@"wordlist.txt");
        string word;
        List<string> guesses = new List<string>();
        int misses;
        public Hangman()
        {
            InitializeComponent();
        }

        private void Hangman_Load(object sender, EventArgs e)
        {
            Setup(words[gen.Next(words.Length)].ToUpper());
        }

        public void Setup(string input)
        {
            grpAgain.Visible = false;
            lblEnd.Visible = false;
            txtGuess.Enabled = true;
            guesses.Clear();
            lstGuessed.SelectionMode = SelectionMode.One;
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = guesses;
            lstGuessed.SelectionMode = SelectionMode.None;
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = guesses;
            imgHang.Image = Properties.Resources.hang;
            misses = 0;
            word = input;
            lblWord.Text = "_";
            for (int i = 1; i < word.Length; i++)
                lblWord.Text += " _";
            //lblWord.Font = 
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            bool miss = true;
            char[] result = lblWord.Text.ToCharArray();
            guesses.Add(txtGuess.Text);
            //there's this weird thing i found where if a listbox's SelectionMode is set to None updating it just... doesn't work?
            //idk if it's a bug or if there's a reason for it but it forced me to add two pointless lines of code *sigh*
            lstGuessed.SelectionMode = SelectionMode.One;
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = guesses;
            lstGuessed.SelectionMode = SelectionMode.None;
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
                misses += 1;
                switch (misses)
                {
                    case 1:
                        imgHang.Image = Properties.Resources.hang1;
                        break;
                    case 2:
                        imgHang.Image = Properties.Resources.hang2;
                        break;
                    case 3:
                        imgHang.Image = Properties.Resources.hang3;
                        break;
                    case 4:
                        imgHang.Image = Properties.Resources.hang4;
                        break;
                    case 5:
                        imgHang.Image = Properties.Resources.hang5;
                        break;
                    case 6:
                        imgHang.Image = Properties.Resources.hang6;
                        EndGame(false);
                        break;
                }
            }
            else
            {
                lblWord.Text = new String(result);
                if (!lblWord.Text.Contains("_"))
                    EndGame(true);
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
        public void EndGame(bool won)
        {
            txtGuess.Clear();
            txtGuess.Enabled = false;
            lblEnd.Visible = true;
            grpAgain.Visible = true;
            if (won)
                lblEnd.Text = "You win!";
            else
            {
                lblEnd.Text = $"You lose! \nThe word was {word}";
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Setup(words[gen.Next(words.Length)].ToUpper());
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            string newWord;
            frmCustom custom = new frmCustom();
            custom.ShowDialog();
            newWord = custom.word;
            Setup(newWord);
        }
    }
}
