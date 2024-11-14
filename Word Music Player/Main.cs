using Spire.Doc;
using Spire.Doc.Documents;
using Spire.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ManagedBass;
using ManagedBass.Fx;
using ManagedBass.Mix;



namespace Word_Music_Player
{
    public partial class Main : Form
    {
        myPlayerFuntions _myPlayerFuntions;
        Player _myPlayer;
        Playlist _Playlist;
        myOpenDocs _myOpenDocs;
        myTransposeChords _myTransposeChords;
        myRecentOpenDocs _myRecentOpenDocs;

        #region INICIALIZE PROGRAM
        
        public string  _RichTextBoxMain => richTextBox1.Rtf;
        private string _filePathSave;
        private string _richTextContent;
        private string _color="Red"; // Color of Cifra Chords
        public static int _spaceNumbers;

        public Main()
        {            
            InitializeComponent();
            AddMp3PlayerToMain();
            AddPlaylistToMain();
            _myPlayerFuntions = new myPlayerFuntions(); 
            _myPlayer = new Player();
            _Playlist = new Playlist();
            _myOpenDocs = new myOpenDocs();
            _myTransposeChords = new myTransposeChords();        
            //================================
            _myRecentOpenDocs = new myRecentOpenDocs();
            _myRecentOpenDocs.LoadRecentFiles();
            UpdateRecentFilesMenu();
            //==========================            
            LoadAvailableFontNames();
            LoadAvailableFontSizes();
            
        }
        #endregion

        #region ADD FORMS TO MAIN WINDOWS
        private void AddMp3PlayerToMain()
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
        private void buttonPlaylist_Click(object sender, EventArgs e)
        {
            AddPlaylistToMain();
        }

        private void buttonChordEditor_Click(object sender, EventArgs e)
        {
            panelRight.Controls.Clear();
            panelChordEdit.Visible = true;
            panelRight.Controls.Add(panelChordEdit);
        }



        #endregion

        #region FORM OPEN CLOSE 
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            _myRecentOpenDocs.SaveRecentFiles();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        #endregion

        #region OPEN SAVE FILES MENU

        private void LoadDocument()
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
                _myRecentOpenDocs.AddFilePath(_filePath);
                UpdateRecentFilesMenu();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDocument();
        }

        private void SaveDocument()
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
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        #endregion

        #region RECENT OPEN FILES DOCS
        private void recentDocsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void UpdateRecentFilesMenu()
        {
            recentDocsToolStripMenuItem.DropDownItems.Clear();

            foreach(string filePath in _myRecentOpenDocs.GetRecentFiles())
            {
                var item = new ToolStripMenuItem(filePath);
                
                recentDocsToolStripMenuItem.DropDownItems.Add(item);

            }

        }
        private void recentDocsToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string _fileFromMenu = e.ClickedItem.Text;
            labelDocName.Text = _fileFromMenu;
            richTextBox1.Text= _myOpenDocs.OpenDocument(_fileFromMenu);
        }

        #endregion

        #region CONVERT CHORDS MENU
        private void radioButtonCifra_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Please add Lyrics with chords");
            }
            else
            {
                if(radioButtonCifra.Checked)
                {
                    UndoSaveContent();
                    string line = richTextBox1.Text.Trim();
                    string output = myCifraFuntions.DoremiConvert(line);
                    richTextBox1.Text = output;
                }
                myCifraFuntions.ChangeTextColor(richTextBox1, _color);
            }
            radioButtonCifra.Checked = false;            
        }

        private void radioButtonDoremi_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                if(radioButtonDoremi.Checked)
                {
                    UndoSaveContent();
                    string line = richTextBox1.Text;
                    string output = myCifraFuntions.CifraConvert(line);
                    richTextBox1.Text = output;
                }
                myCifraFuntions.ChangeTextColor(richTextBox1, _color);
            }
            else
            {
                MessageBox.Show("Please add a song with chords");
            }

            radioButtonDoremi.Checked= false;

        }
        #endregion

        #region TRANSPOSE BUTTON
        private void buttonDown_Click_1(object sender, EventArgs e)
        {
            int _value = -1;
            string _noTabs = _myTransposeChords.RemoveTabs(richTextBox1.Text);
            
            string _text = _myTransposeChords.TransposeChords(_noTabs, _value);               
            richTextBox1.Text = _text;
            // Change Color of Chords
            myCifraFuntions.ChangeTextColor(richTextBox1 , _color);

        }

        private void buttonUp_Click_1(object sender, EventArgs e)
        {
            int _value = 1;
            string _noTabs = _myTransposeChords.RemoveTabs(richTextBox1.Text);
            string _text = _myTransposeChords.TransposeChords(_noTabs,_value);
            richTextBox1.Text = _text;
            myCifraFuntions.ChangeTextColor(richTextBox1, _color);
        }

        #endregion

        #region MENU EDIT CHORDS COLOR

        private void checkRadioButtons()
        {
            UndoSaveContent();

            if (radioButtonBlue.Checked)
            {
                _color = radioButtonBlue.Text;                
                myCifraFuntions.ChangeTextColor(richTextBox1, _color);
            }
            else if (radioButtonGreen.Checked)
            {
                _color = "LimeGreen";
                myCifraFuntions.ChangeTextColor(richTextBox1, _color);
            }
            else if (radioButtonRed.Checked)
            {
                _color = radioButtonRed.Text;
                myCifraFuntions.ChangeTextColor(richTextBox1, _color);
            }
            else if (radioButtonBlack.Checked)
            {
                _color = radioButtonBlack.Text;
                myCifraFuntions.ChangeTextColor(richTextBox1, _color);
            }
            else if (radioButtonRose.Checked)
            {
                _color = "Violet";
                myCifraFuntions.ChangeTextColor(richTextBox1 , _color);
            }
            else if(radioButtonYellow.Checked)
            {
                _color = "Gold";
                myCifraFuntions.ChangeTextColor(richTextBox1, _color);
            }
        }
        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            checkRadioButtons();
        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            checkRadioButtons();
        }


        private void radioButtonBlack_CheckedChanged(object sender, EventArgs e)
        {
            checkRadioButtons();
        }

        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            checkRadioButtons();
        }
        private void radioButtonRose_CheckedChanged(object sender, EventArgs e)
        {
            checkRadioButtons();
        }

        private void radioButtonYellow_CheckedChanged(object sender, EventArgs e)
        {
            checkRadioButtons();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int _size = Convert.ToInt32(numericUpDownSize.Value);
            myCifraFuntions.ChangeTextSize(richTextBox1, _size);
        }

        #endregion

        #region REMOVE ADD SPACES
        private void radioButtonRemoveSpaces_CheckedChanged(object sender, EventArgs e)
        {
            myCifraFuntions.RemoveSpaces(richTextBox1);
            myCifraFuntions.ChangeTextColor(richTextBox1, _color);
            radioButtonRemoveSpaces.Checked = false;
        }
        private void radioButtonAdd_Spaces_CheckedChanged(object sender, EventArgs e)
        {
            myCifraFuntions.AddSpaces(richTextBox1);
            myCifraFuntions.ChangeTextColor(richTextBox1, _color);
            radioButtonAdd_Spaces.Checked = false;
        }

        #endregion

        #region UNDO
        public void UndoSaveContent()
        {
            // Store the RichTextBox content in memory
            _richTextContent = richTextBox1.Text;
        }
                

        public void Undo()
        {
            richTextBox1.Text= _richTextContent;
            myCifraFuntions.ChangeTextColor(richTextBox1 , _color); 
        }
        #endregion

        #region CONVERT TO CHORDPRO LYRICS

        private void buttonLyricsToChordpro_Click(object sender, EventArgs e)
        {
            UndoSaveContent();

            if (richTextBox1.SelectedText == String.Empty)
            {
                MessageBox.Show("Select lyrics with chord to convert to Chorpro Format");
                radioButtonLyricsChordPro.Checked = false;
            }
            else
            {
                string inputText = richTextBox1.SelectedText;
                //string chordProText = chordproConvert.ConvertToChordPro2(inputText);
                string chordProText = myChordproConvert.ConvertLyricsWithChordsToChordPro(inputText);
                richTextBox1.SelectedText = chordProText;
                radioButtonLyricsChordPro.Checked = false;
            }

        }

        private void buttonChordproToLyrics_Click(object sender, EventArgs e)
        {
            UndoSaveContent();

            if (richTextBox1.SelectedText == String.Empty)
            {
                MessageBox.Show("Select lyrics with chord to convert to Chorpro Format");
                radioButtonLyricsChordPro.Checked = false;
            }
            else
            {
                string inputText = richTextBox1.SelectedText;
                //string chordProText = chordproConvert.ConvertToChordPro2(inputText);
                string chordProText = myChordproConvert.ConvertChordProToLyricsWithChords(inputText);
                richTextBox1.SelectedText = chordProText;
                radioButtonLyricsChordPro.Checked = false;
            }
        }

        #endregion

        #region COPY PASTE CHORDS
        private void radioButtonCopyChord_CheckedChanged(object sender, EventArgs e)
        {
            UndoSaveContent();
            if (radioButtonCopyChord.Checked)
            {
                try
                {
                    Clipboard.SetText(richTextBox1.SelectedText);
                }
                catch
                {
                    MessageBox.Show("Select lyrics with chords to copy. (remember how many lines you copy)");
                }
            }
            radioButtonCopyChord.Checked = false;
        }

        private void radioButtonPasteChord_CheckedChanged(object sender, EventArgs e)
        {
            UndoSaveContent();
            if (radioButtonPasteChord.Checked)
            {
                if (richTextBox1.SelectionLength != 0)
                {
                   richTextBox1.Text= myEditChords.copyChords(richTextBox1);
                }
                else
                {
                    MessageBox.Show("Select the lyrics to where you want to copy the chords. Remenber choose the same number of lyrics lines.");
                }
            }
                radioButtonPasteChord.Checked = false;
        }
        #endregion

        #region MENU EDIT PREFERENCES



        #endregion

        #region MENU RIGHT CLICK JOIN LYRICS
        private void joinLyrcsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoSaveContent();
            string selectedText = richTextBox1.SelectedText;            
            string newText = myCifraFuntions.JoinTextLinesInTwo(selectedText);
            richTextBox1.SelectedText = newText;
            
        }
        private void joinLyricsWithChordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoSaveContent();
            // Check if there is selected text in the RichTextBox
            if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
            {
                // Copy selected text to clipboard
                Clipboard.SetText(richTextBox1.SelectedText);

                // Use TextConverter to convert the selected text
                string convertedText = myCifraFuntions.JoinLyricsWithChords(richTextBox1.SelectedText);
                
                richTextBox1.SelectedText = convertedText;                
            }
            else
            {
                MessageBox.Show("Please select text in the RichTextBox first.");
            }
            myCifraFuntions.ChangeTextColor(richTextBox1, _color);
        }
        private void copyChordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoSaveContent();

                try
                {
                    Clipboard.SetText(richTextBox1.SelectedText);
                }
                catch
                {
                    MessageBox.Show("Select lyrics with chords to copy. (remember how many lines you copy)");
                }
            
        }
        private void pasteChordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoSaveContent();

                if (richTextBox1.SelectionLength != 0)
                {
                    richTextBox1.Text = myEditChords.copyChords(richTextBox1);
                }
                else
                {
                    MessageBox.Show("Select the lyrics to where you want to copy the chords. Remenber choose the same number of lyrics lines.");
                }
            myCifraFuntions.ChangeTextColor(richTextBox1, _color);
        }

        #endregion

        #region MENU JOIN LYRICS
        private void radioButtonJoinLyrics_CheckedChanged(object sender, EventArgs e)
        {
            UndoSaveContent();
            string selectedText = richTextBox1.SelectedText;
            string newText = myCifraFuntions.JoinTextLinesInTwo(selectedText);
            richTextBox1.SelectedText = newText;
        }

        private void radioButtonJoinLyricsChords_CheckedChanged(object sender, EventArgs e)
        {
            UndoSaveContent();
            // Check if there is selected text in the RichTextBox
            if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
            {
                // Copy selected text to clipboard
                Clipboard.SetText(richTextBox1.SelectedText);

                // Use TextConverter to convert the selected text
                string convertedText = myCifraFuntions.JoinLyricsWithChords(richTextBox1.SelectedText);

                richTextBox1.SelectedText = convertedText;
            }
            else
            {
                MessageBox.Show("Please select text in the RichTextBox first.");
            }
            myCifraFuntions.ChangeTextColor(richTextBox1, _color);
        }
        #endregion

        #region CHORDPRO CONVERT
        private void radioButtonChordproToLyrics_CheckedChanged(object sender, EventArgs e)
        {
            UndoSaveContent();

                string inputText = richTextBox1.SelectedText;
                
                string chordProText = myCifraFuntions.ConvertChordproToLyrics(inputText);
                richTextBox1.SelectedText = chordProText;
            
                radioButtonChordproToLyrics.Checked = false;
        }

        private void radioButtonLyricsToChordpro_CheckedChanged(object sender, EventArgs e)
        {
            UndoSaveContent();

            string input = richTextBox1.SelectedText;
            //string input = richTextBox1.Text;

            string result = myCifraFuntions.ConvertLyricsWithChordsToChordPro(input);

            richTextBox1.SelectedText = result;
            //richTextBox1.Text = result;
            
            radioButtonLyricsToChordpro.Checked = false;

        }
        #endregion

        #region MENU TOP FONTS SIZE LOAD SAVE NEW
        private void buttonRemoveFormat_Click(object sender, EventArgs e)
        {
            string _text = richTextBox1.Text;
            richTextBox1.Text = _text;
        }
        public void LoadAvailableFontSizes()
        {
            // Add some common font sizes
            int[] fontSizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

            foreach (int size in fontSizes)
            {
                ComboBoxTextSize.Items.Add(size);
            }
        }

        public void LoadAvailableFontNames()
        {
            string[] fontNames = { "Microsoft Sans Serif", "Helvetica", "Calibri", "Garamond", "Times New Roman", "Futura", "Arial", "Cambria", "Verdana", "Rockwell", "Franklin Gothic" };

            foreach (string fontName in fontNames)
            {
                ComboBoxFont.Items.Add(fontName);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == String.Empty)
            {
                string selectedFont = ComboBoxFont.SelectedItem.ToString();
                richTextBox1.Font = new Font(selectedFont, richTextBox1.Font.Size);
                myCifraFuntions.ChangeTextColor(richTextBox1,_color);                
            }
            else
            {
                string selectedFont = ComboBoxFont.SelectedItem.ToString();
                richTextBox1.SelectionFont = new Font(selectedFont, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
                myCifraFuntions.ChangeTextColor(richTextBox1, _color);
            }
            
        }

        private void ComboBoxTextSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == String.Empty)
            {
                int size = Convert.ToInt32(ComboBoxTextSize.SelectedItem);

                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, size);
                myCifraFuntions.ChangeTextColor(richTextBox1, _color);
            }
            else
            {
                int fontSize = Convert.ToInt32(ComboBoxTextSize.SelectedItem);
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, fontSize, richTextBox1.SelectionFont.Style);
                myCifraFuntions.ChangeTextColor(richTextBox1, _color);
            }
            
        }
        private void buttonOpenDoc_Click(object sender, EventArgs e)
        {
            LoadDocument();
        }
        private void buttonSaveDoc_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }
        private void buttonNewDoc_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        private void buttonCopyText_Click(object sender, EventArgs e)
        {
            try
            {

                if (richTextBox1 != null && !string.IsNullOrEmpty(richTextBox1.Text))
                {
                    Clipboard.SetText(richTextBox1.Rtf  , TextDataFormat.Rtf);
                    //Clipboard.SetData(DataFormats.Rtf, richTextBox1.Rtf);

                    // Copy the selected RTF content (or entire content if none selected) to the clipboard
                    //Clipboard.SetText(richTextBox1.SelectedRtf.Length > 0 ? richTextBox1.SelectedRtf : richTextBox1.Rtf, TextDataFormat.Rtf);
                                       

                }
                else
                {
                    MessageBox.Show("There is no text to copy");
                }
            
            }
            catch
            {
                return;
            }
        }
        private void buttonPaste_Click(object sender, EventArgs e)
        {
            try
            {
                if (Clipboard.ContainsText(TextDataFormat.Rtf))
                {
                    // Paste as RTF if RTF is available
                    richTextBox1.Rtf = Clipboard.GetText(TextDataFormat.Rtf);
                }
                else if (Clipboard.ContainsText(TextDataFormat.UnicodeText ))
                {
                    // Convert HTML to plain text if HTML is available
                    richTextBox1.Text = Clipboard.GetText(TextDataFormat.UnicodeText);
                }
                else if (Clipboard.ContainsText(TextDataFormat.Text))
                {
                    // Fallback to plain text if no RTF or HTML is available
                    richTextBox1.Text = Clipboard.GetText(TextDataFormat.Text);
                }
                else
                {
                    MessageBox.Show("There is no compatible text format in memory");
                }
            }
            catch { return; }
        }
        private void button_Undo_Click(object sender, EventArgs e)
        {
            Undo();
        }
        private void buttonTextLeft_Click(object sender, EventArgs e)
        {
            
            if (richTextBox1.SelectionLength > 0)
            {
                // Align selected text to the right
                richTextBox1.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            }
            else
            {
                // Align the line where the cursor is located to the left
                int lineIndex = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);
                int lineStart = richTextBox1.GetFirstCharIndexFromLine(lineIndex);
                int lineLength = richTextBox1.Lines[lineIndex].Length;

                // Select the current line
                richTextBox1.Select(lineStart, lineLength);
                richTextBox1.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Left;

                // Deselect to restore the original cursor position
                richTextBox1.Select(lineStart + lineLength, 0);
            }
        }

        private void buttonTextCenter_Click(object sender, EventArgs e)
        {
            
            if (richTextBox1.SelectionLength > 0)
            {

                // Align selected text to the right
                richTextBox1.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Center;

            }
            else
            {
                // Align the line where the cursor is located to the left
                int lineIndex = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);
                int lineStart = richTextBox1.GetFirstCharIndexFromLine(lineIndex);
                int lineLength = richTextBox1.Lines[lineIndex].Length;

                // Select the current line
                richTextBox1.Select(lineStart, lineLength);
                richTextBox1.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Center;

                // Deselect to restore the original cursor position
                richTextBox1.Select(lineStart + lineLength, 0);
            }
        }

        private void buttonTextRight_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {

                // Align selected text to the right
                richTextBox1.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Right;

            }
            else
            {
                // Align the line where the cursor is located to the left
                int lineIndex = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);
                int lineStart = richTextBox1.GetFirstCharIndexFromLine(lineIndex);
                int lineLength = richTextBox1.Lines[lineIndex].Length;

                // Select the current line
                richTextBox1.Select(lineStart, lineLength);
                richTextBox1.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Right;

                // Deselect to restore the original cursor position
                richTextBox1.Select(lineStart + lineLength, 0);
            }
        }
        private void buttonBold_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {

                // Align selected text to the right
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);

            }
            else
            {
                // Align the line where the cursor is located to the left
                int lineIndex = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);
                int lineStart = richTextBox1.GetFirstCharIndexFromLine(lineIndex);
                int lineLength = richTextBox1.Lines[lineIndex].Length;

                // Select the current line
                richTextBox1.Select(lineStart, lineLength);
                // Set the font of the selected text to bold
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);

                // Deselect to restore the original cursor position
                richTextBox1.Select(lineStart + lineLength, 0);
            }
        }


        #endregion

        #region MENUS HELP ABOUT

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help(); 
            help.ShowDialog();
        }
        #endregion

        #region  ATALHOS KEYDOWN SHORTCUTS

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {

                //_myPlayer.PlayButton();
                _myPlayer.buttonPlay_Click(null, EventArgs.Empty);
                e.Handled= true;                
            }

            if (e.KeyCode == Keys.F3) 
            {
                _myPlayer.PlayForward();                
                e.Handled = true;
            }

            if (e.KeyCode == Keys.F2)
            {
                _myPlayer.PlayBackward();
                e.Handled = true;
            }


            if (e.KeyCode == Keys.F4)
            {
                _myPlayer.buttonStop_Click(null, EventArgs.Empty);
                e.Handled = true;
            }

            if (e.Control && e.KeyCode == Keys.B)
            {
                buttonBold_Click(null, EventArgs.Empty);                
                e.Handled = true;
            }
        }


        #endregion

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void removeChordsFromSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            string output = myCifraFuntions.RemoveChordsFromSelected(richTextBox1.SelectedText);
            richTextBox1.SelectionColor = Color.Black;
            // Make text not Bold
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);

            richTextBox1.SelectedText = output;
            
        }

    }
}
