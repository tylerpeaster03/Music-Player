using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

public class FileSystem
{
    private readonly string musicFolderPath;

    public FileSystem()
    {
        musicFolderPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Music");

        //Make sure the music folder exists
        if (!Directory.Exists(musicFolderPath))
        {
            Directory.CreateDirectory(musicFolderPath);
        }
    }

    //Variables
    private List<string> fileNames = new List<string>();
    private List<string> filePaths = new List<string>();

    public void AddMusic(ListBox listMusic)
    {
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.Multiselect = true;
        ofd.Filter = "Audio Files|*.mp3;*.wav";//Only allow mp3, wav files

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            foreach (string filenameWithPath in ofd.FileNames)
            {
                string filename = Path.GetFileNameWithoutExtension(filenameWithPath);
                if (!fileNames.Contains(filename)) //Check if filename already exists in music folder to prevent duplicate songs
                {
                    string destinationPath = Path.Combine(musicFolderPath, Path.GetFileName(filenameWithPath));
                    File.Copy(filenameWithPath, destinationPath, true); //Copies the selected song to the music folder
                    listMusic.Items.Add(filename);
                    fileNames.Add(filename);
                    filePaths.Add(destinationPath); //Stores the path of the music folder
                }
            }
        }
    }

    public void LoadMusic(ListBox listMusic)
    {
        //Load existing music from music folder upon startup
        string[] musicFiles = Directory.GetFiles(musicFolderPath);
        foreach (string file in musicFiles)
        {
            string filename = Path.GetFileNameWithoutExtension(file);
            if (!fileNames.Contains(filename))
            {
                listMusic.Items.Add(filename);
                fileNames.Add(filename);
                filePaths.Add(file);
            }
        }
    }

    public List<string> GetFilePaths()
    {
        return filePaths;
    }
}
