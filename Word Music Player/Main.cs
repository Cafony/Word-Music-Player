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
    public partial class Main : Form
    {
        myPlaylist_Delete _myPlaylist;
        public Main()
        {
            InitializeComponent();
            AddPlayerToMain();
            AddPlaylistToMain();
            _myPlaylist = new myPlaylist_Delete();
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
            panelRight.Controls.Clear();
            ChordEditor chordEditor = new ChordEditor();
            chordEditor.TopLevel = false;
            chordEditor.Dock = DockStyle.Fill;
            panelRight.Controls.Add(chordEditor);
            chordEditor.Show();
        }


        #endregion

        private void buttonPlaylist_Click(object sender, EventArgs e)
        {
            AddPlaylistToMain();
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
    }
}
