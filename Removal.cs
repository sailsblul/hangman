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
    public partial class Removal : Form
    {
        string word;
        public bool confirm;
        public Removal(string word)
        {
            InitializeComponent();
            this.word = word;
        }

        private void Removal_Load(object sender, EventArgs e)
        {
            lblAsk.Text = $"Remove {word} from the word list?";
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            confirm = true;
            Dispose();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            confirm = false;
            Dispose();
        }
    }
}
