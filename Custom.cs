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
    public partial class frmCustom : Form
    {
        public string word = "";
        public frmCustom()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (char i in txtWord.Text)
            {
                if (Char.IsLetter(i))
                    word += i;
            }
            Dispose();
        }
    }
}
