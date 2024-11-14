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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void buttonChordMenu_Click(object sender, EventArgs e)
        {
            Help_ChordEditor help_ChordEditor = new Help_ChordEditor();
            help_ChordEditor.Dock = DockStyle.Fill;
            panelHelp.Controls.Clear();
            panelHelp.Controls.Add(help_ChordEditor);
            help_ChordEditor.Show();

        }

        private void buttonHelpChordConvert_Click(object sender, EventArgs e)
        {
            Help_ChordConvert help_ChordConvert = new Help_ChordConvert();
            help_ChordConvert.Dock = DockStyle.Fill;
            panelHelp.Controls.Clear();
            panelHelp.Controls.Add(help_ChordConvert);
            help_ChordConvert.Show();
        }

        private void buttonHelpShortcuts_Click(object sender, EventArgs e)
        {
            Help_Shortcuts help_Shortcuts = new Help_Shortcuts();
            help_Shortcuts.Dock = DockStyle.Fill;
            panelHelp.Controls.Clear();
            panelHelp.Controls.Add(help_Shortcuts);
            help_Shortcuts.Show();
        }

        private void buttonHelpCopyChords_Click(object sender, EventArgs e)
        {
            Help_CopyChords help_CopyChords = new Help_CopyChords();
            help_CopyChords.Dock = DockStyle.Fill;  
            panelHelp.Controls.Clear();
            panelHelp.Controls.Add(help_CopyChords);
            help_CopyChords.Show();
        }

        private void buttonHelpJoinLyrics_Click(object sender, EventArgs e)
        {
            Help_JoinLyrics help_JoinLyrics = new Help_JoinLyrics();
            help_JoinLyrics.Dock = DockStyle.Fill;
            panelHelp.Controls.Clear();
            panelHelp.Controls.Add(help_JoinLyrics);
            help_JoinLyrics.Show();
        }

        private void buttonHelpRemoveChords_Click(object sender, EventArgs e)
        {
            Help_RemoveChords help_RemoveChords = new Help_RemoveChords();
            help_RemoveChords.Dock = DockStyle.Fill;
            panelHelp.Controls.Clear();
            panelHelp.Controls.Add(help_RemoveChords);
            help_RemoveChords.Show();
        }

        private void buttonHelpChordproConvert_Click(object sender, EventArgs e)
        {
            Help_ChordproConvert help_ChordproConvert = new Help_ChordproConvert();
            help_ChordproConvert.Dock = DockStyle.Fill;
            panelHelp.Controls.Clear();
            panelHelp.Controls.Add(help_ChordproConvert);
            help_ChordproConvert.Show();
        }
    }
}
