using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Music_Player
{
    public partial class Playlist : Form
    {
        
        private Player _myPlayer;
        private myPlayerFuntions _myPlayerFuntions;
        

        //private myPlayerFuntions _myPlayerFuntions;
        private string _playlistDefaultPath = System.IO.Path.Combine(Application.StartupPath, "playlist.txt");

        public Playlist()
        {
            InitializeComponent();
            
            _myPlayer = new Player();
            _myPlayerFuntions = new myPlayerFuntions();
        }

        #region BUTTONS LOAD SAVE PLAYLIST
        private void buttonAddFiles_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {

                    // Get the selected folder path
                    string folderPath = folderDialog.SelectedPath;


                    // Load the supported audio files (.mp3, .wma, .wav)
                    string[] audioFiles = Directory.GetFiles(folderPath, "*.*")
                                                   .Where(file => file.EndsWith(".mp3") ||
                                                                  file.EndsWith(".wma") ||
                                                                  file.EndsWith(".wav"))
                                                   .ToArray();

                    // Add each file name to the listboxPlaylist
                    foreach (string file in audioFiles)
                    {
                        listBoxPlaylist.Items.Add(file); // Add only file name
                    }
                }
            }
        }

        public void CreatePlaylistFile()
        {
            // Check if the file exists, if not, create an empty file
            if (!System.IO.File.Exists(_playlistDefaultPath))
            {
                // Create an empty file
                using (System.IO.FileStream fs = System.IO.File.Create(_playlistDefaultPath)) ;
            }
        }

        public void LoadPlaylist()
        {
            if (File.Exists(_playlistDefaultPath))
            {
                // Clear the current items in the ListBox
                listBoxPlaylist.Items.Clear();

                using (StreamReader reader = new StreamReader(_playlistDefaultPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        listBoxPlaylist.Items.Add(line.Trim());
                    }

                }
            }
            else { MessageBox.Show("Cant load Playlist"); }

        }

        public void SavePlaylist()
        {
            CreatePlaylistFile();

            try
            {
                using (StreamWriter writer = new StreamWriter(_playlistDefaultPath))
                {
                    foreach (string file in listBoxPlaylist.Items)
                    {
                        writer.WriteLine(file.ToString());
                    }
                }
            }
            catch { MessageBox.Show("Cant save playlist"); }

        }

        public void buttonSaveList_Click(object sender, EventArgs e)
        {
            SavePlaylist();
            MessageBox.Show("Playlist saved!");
        }

        private void buttonClearList_Click(object sender, EventArgs e)
        {
            listBoxPlaylist.Items.Clear();
        }

        private void buttonRemoveListIten_Click(object sender, EventArgs e)
        {            
            // Make sure something is selected
            if (listBoxPlaylist.SelectedItems.Count > 0)
            {
                // Start from the last selected index to avoid shifting indices when removing
                for (int i = listBoxPlaylist.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    // Remove the item from the list and ListBox at the selected index
                    int index = listBoxPlaylist.SelectedIndices[i];
                    listBoxPlaylist.Items.RemoveAt(index);
                }
            }
        }
        #endregion

        #region FORM OPEN CLOSE
        private void Playlist_Load(object sender, EventArgs e)
        {
            LoadPlaylist();
        }

        public void Playlist_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        public void Playlist_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        #endregion


        #region SEND FILE TO PLAYER

        private void listBoxPlaylist_MouseClick(object sender, MouseEventArgs e)
        {                        
            try
            {
                string file = listBoxPlaylist.SelectedItem.ToString();                
                string name= Path.GetFileName(file);
                labelMusicPlaylist.Text = name;                
            }
            catch { MessageBox.Show("Select Music"); }
        }
            
        private void PlayListboxFile()
        {
            _myPlayer.ResetPlayerValues(); // Nao está a funcionar
            _myPlayerFuntions.StopMP3();                 
            _myPlayerFuntions.CreateStream(listBoxPlaylist.SelectedItem.ToString());
            _myPlayerFuntions.PlayStream();
            _myPlayer._isPlaying = true;
        }
            
        private void listBoxPlaylist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PlayListboxFile();
        }

        #endregion

        private void listBoxPlaylist_Format(object sender, ListControlConvertEventArgs e)
        {
            // Display only the filename, but the value is the full path
            e.Value = Path.GetFileName(e.ListItem.ToString());
        }

        #region  KEYDOWN SHORTCUTS
        private void listBoxPlaylist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                while (listBoxPlaylist.SelectedItems.Count > 0)
                {
                    listBoxPlaylist.Items.Remove(listBoxPlaylist.SelectedItems[0]);
                }
            }
            //Play file when ENTER
            if(e.KeyCode == Keys.Enter)
            {
                PlayListboxFile();
            }

        }

        #endregion

        private void textBoxSearchMp3_TextChanged(object sender, EventArgs e)
        {
            string query = textBoxSearchMp3.Text.Trim().ToLower();

            var filteredItems = listBoxPlaylist.Items.Cast<string>()
                .Where(item => string.IsNullOrEmpty(query) || item.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            listBoxPlaylist.Items.Clear();

            foreach (var item in filteredItems)
            {
                listBoxPlaylist.Items.Add(item);
            }
            
            // Reset initial iten from ListBox
            if (string.IsNullOrEmpty(query))
            {
                LoadPlaylist();
            }

            
        }

    }
}
