using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Music_Player
{
    internal class myRecentOpenDocs
    {
        public List<string> _recentFilesList;
        private readonly string _workingDirectory;
        private readonly string _recentFilesPath;
        private const int maxFilePaths = 10;

        // Constructor initializes the file path and loads recent files if they exist
        public myRecentOpenDocs()
        {
            _workingDirectory = AppDomain.CurrentDomain.BaseDirectory;  // Base directory of the app
            _recentFilesPath = Path.Combine(_workingDirectory, "recentFiles.txt");  // File in the working directory
            _recentFilesList = new List<string>();
            //LoadRecentFiles();  // Automatically load recent files when the app starts
        }

        // Add file path to the list
        public void AddFilePath(string path)
        {
            if (!_recentFilesList.Contains(path))
            {
                if (_recentFilesList.Count >= maxFilePaths)
                {
                    _recentFilesList.RemoveAt(0);  // Remove the oldest entry if the list exceeds 10
                }
                _recentFilesList.Add(path);
            }
            SaveRecentFiles();
        }

        // Save list to recentFiles.txt in the working directory
        public void SaveRecentFiles()
        {
            try
            {
                File.WriteAllLines(_recentFilesPath, _recentFilesList);  // Save the list to the file
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving recent files: {ex.Message}");
            }
        }

        // Load list from recentFiles.txt in the working directory
        public void LoadRecentFiles()
        {
            try
            {
                if (File.Exists(_recentFilesPath))
                {
                    _recentFilesList = new List<string>(File.ReadAllLines(_recentFilesPath));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading recent files: {ex.Message}");
            }
        }

        // Get the list of recent files
        public List<string> GetRecentFiles()
        {
            return _recentFilesList;
        }

    }
}
