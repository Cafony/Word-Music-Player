using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Music_Player
{
    public partial class Main : Form
    {
        Playlist _Playlist;
        myOpenDocs _myOpenDocs;
        myTransposeChords _myTransposeChords;
        public string  _RichTextBoxMain => richTextBox1.Rtf;
        private string _filePathSave;

        public Main()
        {
            InitializeComponent();
            AddPlayerToMain();
            AddPlaylistToMain();
            _Playlist = new Playlist();
            _myOpenDocs = new myOpenDocs();
            _myTransposeChords = new myTransposeChords();
            
        }

        #region ADD FORMS TO MAIN WINDOWS
        private void AddPlayerToMain()
        {
            Player player = new Player();
            player.TopLevel = false;
            player.Dock = DockStyle.Fill;
            panelDown.Controls.Add(player);
            player.Show();
        }

        private void AddPlaylistToMain()
        {
            panelRight.Controls.Clear();
            Playlist playlist = new Playlist();
            playlist.TopLevel = false;
            playlist.Dock = DockStyle.Fill;
            panelRight.Controls.Add(playlist);
            playlist.Show();
        }

        private void AddChordEditorToMain()
        {


        }


        #endregion

        private void buttonPlaylist_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonChordEditor_Click(object sender, EventArgs e)
        {
            AddChordEditorToMain();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        #region OPEN SAVE FILES MENU
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "OpenDocument (*.odt)|*.odt|Word (*.docx)|*.docx|Word (*.doc)|*.doc|Richtext (*.rtf)|*.rtf|Text File (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string _filePath = openFileDialog.FileName;

                try
                {
                    string _myText = _myOpenDocs.OpenDocument(_filePath);
                    richTextBox1.Text = _myText;

                }
                catch
                {
                    MessageBox.Show("Error: ");
                }
            }
        }

        #endregion

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word (*.docx)|*.docx|OpenDocument (*.odt)|*.odt|Word (*.doc)|*.doc|Richtext (*.rtf)|*.rtf|Text (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _filePathSave = saveFileDialog.FileName;
                string format = System.IO.Path.GetExtension(_filePathSave).ToLower().Replace(".", ""); // Get file extension without the dot

                try
                {

                    //myOpenDocs openDoc = new myOpenDocs();     
                    _myOpenDocs.SaveDocument(_filePathSave, richTextBox1, format);  // Call SaveDocument with file path, richTextBox, and format
                    //_myOpenDocs.SaveOdt(_filePathSave, richTextBox1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void transposeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelTranspose.Visible==false)
            {
            panelTranspose.Visible = true;
            }
            else
            {
                panelTranspose.Visible = false;
            }
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           }

        #region BUTTON TRANSPOSE UP DOWN

        private void buttonUp_Click(object sender, EventArgs e)
        {
            int _value = 1;
            string _noTabs = _myTransposeChords.RemoveTabs(richTextBox1.Text);
            string _text = _myTransposeChords.TransposeChords(_noTabs,_value);
            richTextBox1.Text = _text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int _value = -1;
            string _noTabs = _myTransposeChords.RemoveTabs(richTextBox1.Text);
            string _text = _myTransposeChords.TransposeChords(_noTabs, _value);            
            richTextBox1.Text = _text;
        }
        #endregion

        private void playlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPlaylistToMain();
        }
    }
}
