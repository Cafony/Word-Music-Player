using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Music_Player
{
    public partial class TransposeForm : Form
    {
        myTransposeChords _myTransposeChords;
        Main _main;
        private static int _semitons;
        public TransposeForm()
        {
            InitializeComponent();
            _myTransposeChords = new myTransposeChords();
            _main = new Main();
        }

        private void TransposeFuntion()
        {
            string _inputText = _main.richTextBox1.Text;

            string _outputText = _myTransposeChords.TransposeChords(_inputText, _semitons);

            richTextBox1.Text = _outputText;

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            richTextBox1.Rtf = _main._RichTextBoxMain;
            _semitons =1;
            labelTransposeValue.Text = _semitons.ToString();
            //TransposeFuntion();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            _semitons =-1;
            labelTransposeValue.Text = _semitons.ToString();
            TransposeFuntion();
        }
    }
}
