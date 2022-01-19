using System;
using System.Collections.Generic;
using System.IO;

namespace Windows_Organizer
{
    class SmartOrganizer
    {

        public List<string> extensionsList;
        public List<string> filesList;
        public List<string> pathsList;
        public List<string> exclusionList;

        public Dictionary<string, string> list;

        public SmartOrganizer() {
            extensionsList = new List<string>();
            filesList = new List<string>();
            list = new Dictionary<string, string>();
            pathsList = new List<string>();
            exclusionList = new List<string>();
        }

        public void RunSmartOrganizer()
        {
            Environment.SpecialFolder[] p = new Environment.SpecialFolder[] { 
                Environment.SpecialFolder.Desktop, 
                Environment.SpecialFolder.MyDocuments, 
                Environment.SpecialFolder.MyPictures, 
                Environment.SpecialFolder.MyVideos,
                Environment.SpecialFolder.MyMusic
            };

            foreach (Environment.SpecialFolder f in p)
            {
                EnumerateFilesExtension(Environment.GetFolderPath(f));
                Organize(Environment.GetFolderPath(f));
            }

        }

        public void EnumerateFilesExtension(string rootPath)
        {
            try
            {
                IEnumerable<string> files = Directory.EnumerateFiles(rootPath, "*.*", SearchOption.TopDirectoryOnly);

                foreach (string f in files)
                {
                    if (!extensionsList.Contains(Path.GetExtension(f)))
                    {
                        extensionsList.Add(Path.GetExtension(f));
                    }

                    filesList.Add(f);
                }
            }
            catch (Exception) { }
        }

        public void Organize(string rootPath)
        {
            foreach(string ext in extensionsList)
            {
                string path = Path.Combine(rootPath, ext.Replace(".", ""));

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                
            }

            foreach (string f in filesList)
            {
                string path = Path.GetDirectoryName(f);

                try
                {
                    File.Move(f, Path.Combine(path, Path.GetExtension(f).Replace(".", ""), Path.GetFileName(f)));
                }
                catch (Exception)
                {

                }
                
            }
        }
    }
}
