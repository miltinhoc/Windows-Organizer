using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Windows_Organizer
{
    class Organizer
    {
        
        public IEnumerable<string> TemporaryFileList { get; private set; }
        public IEnumerable<string> TemporaryDirectoryList { get; private set; }

        public Organizer()
        {
            TemporaryFileList = new List<string>();
            TemporaryDirectoryList = new List<string>();
        }

        public void EnumerateFiles(string rootPath, string extension)
        {
            try
            {
                ((List<string>)TemporaryFileList).AddRange(Directory.EnumerateFiles(rootPath, $"*.{extension}"));
            }
            catch (Exception) { }
        }

        public void EnumerateDirectories(string rootPath)
        {
            try
            {
                IEnumerable<string> subDirs = Directory.EnumerateDirectories(rootPath, "*", SearchOption.AllDirectories);
                ((List<string>)TemporaryDirectoryList).AddRange(subDirs);
            }
            catch (Exception) { }
        }

        public void Organize(Rule rule)
        {
            try
            {
                ClearTempList();
                CheckDestinyDirectory(rule.TargetDirectory);

                if (rule.SearchTopOnly)
                {
                    EnumerateFiles(rule.SearchDirectory, rule.Extension);
                }
                else
                {
                    // add root path to list
                    ((List<string>)TemporaryDirectoryList).Add(rule.SearchDirectory);

                    EnumerateDirectories(rule.SearchDirectory);
                    AddFilesToQueue(rule.Extension);
                }

                MoveFiles(rule.TargetDirectory);

            }catch(Exception)
            {
                
            }
            
        }

        private void MoveFiles(string destPath)
        {
            foreach(string file in TemporaryFileList)
            {
                string fileName = file.Split(Path.DirectorySeparatorChar).Last();

                try
                {
                    Directory.Move(file, Path.Combine(destPath, fileName));
                }
                catch(Exception)
                {
                    
                }

            }
        }

        private void AddFilesToQueue(string extension)
        {
            foreach(string path in TemporaryDirectoryList)
            {
                EnumerateFiles(path, extension);
            }
        }

        public void CheckDestinyDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private void ClearTempList()
        {
            ((List<string>)TemporaryDirectoryList).Clear();
            ((List<string>)TemporaryFileList).Clear();
        }
    }
}
