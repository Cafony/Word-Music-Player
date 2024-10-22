using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Word_Music_Player
{
    internal class myPlaylist_Delete
    {
        public List<string> FileList { get; private set; }
        private string _playlistDefaultPath = System.IO.Path.Combine(Application.StartupPath, "playlist.txt");
        

        public myPlaylist_Delete()
        {
            FileList = new List<string>();            
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

        public void AddFilesFromFolder2(string folderPath, ListBox listBox)
        {
                    // Clear the ListBox before adding new items
                    listBox.Items.Clear();                                 

                    // Get all MP3 files in the selected folder
                    string[] mp3Files = Directory.GetFiles(folderPath, "*.mp3");

                    // Add each MP3 file to the ListBox
                    foreach (string mp3File in mp3Files)
                    {
                        // Optionally, add only the file name instead of the full path
                        listBox.Items.Add(Path.GetFileName(mp3File));
                    }     
        }



        public void SaveListToTxt(ListBox listBox)
        {
            try
            {
                // Open the file for writing
                using (StreamWriter writer = new StreamWriter(_playlistDefaultPath))
                {
                    // Loop through each item in the _playList and write it to the file
                    foreach (string item in listBox.Items)
                    {
                        writer.WriteLine(item);
                    }
                }

                // Optionally, you can display a message or handle success here
                Console.WriteLine("Playlist saved successfully!");
            }
            catch (Exception ex)
            {
                // Handle any errors during the save process
                Console.WriteLine("Error saving playlist: " + ex.Message);
            }

        }

        public void SaveFileList(ListBox listBox1)
        {
            // Create file if doenst exist
            CreatePlaylistFile();
            // Open a StreamWriter to write to the specified file to playlist.txt file
            using (StreamWriter writer = new StreamWriter(_playlistDefaultPath))
            {
                // Loop through each item in the ListBox
                foreach (var item in listBox1.Items)
                {
                    // Write each item to a new line in the file
                    FileList.Add(item.ToString());
                    writer.WriteLine(item.ToString());
                }
            }
        }

        public void LoadPlaylist(ListBox listBox1)
        {

            // Open the file and read all lines
            string[] lines = System.IO.File.ReadAllLines(_playlistDefaultPath);

            // Add each line to the ListBox
            foreach (string line in lines)
            {
                listBox1.Items.Add(line);
            }


            
        }


        public void RemovePlaylistItem(ListBox listBox1)
        {
            //FileList.Remove(item);
            // Make sure something is selected
            if (listBox1.SelectedItems.Count > 0)
            {
                // Start from the last selected index to avoid shifting indices when removing
                for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    // Remove the item from the list and ListBox at the selected index
                    int index = listBox1.SelectedIndices[i];
                    listBox1.Items.RemoveAt(index);
                }
            }
        }

        public void DeletePlaylistFile()
        {
            FileList.Clear();
        }

        public string SearchFileByName(string fileName)
        {
            var file = FileList.FirstOrDefault(f => Path.GetFileName(f).Equals(fileName, StringComparison.OrdinalIgnoreCase));
            return file;
        }


    }
}
