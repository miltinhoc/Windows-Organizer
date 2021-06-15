using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Windows_Organizer
{
    class Organizer
    {
        
        public IEnumerable<string> temporaryFileList { get; private set; }
        public IEnumerable<string> temporaryDirectoryList { get; private set; }

        public Organizer()
        {
            temporaryFileList = new List<string>();
            temporaryDirectoryList = new List<string>();
        }

        public void EnumerateFiles(string rootPath, string extension)
        {
            try
            {
                ((List<string>)temporaryFileList).AddRange(Directory.EnumerateFiles(rootPath, $"*.{extension}"));
            }
            catch (Exception) { }
        }

        public void EnumerateDirectories(string rootPath)
        {
            try
            {
                IEnumerable<string> subDirs = Directory.EnumerateDirectories(rootPath, "*", SearchOption.AllDirectories);
                ((List<string>)temporaryDirectoryList).AddRange(subDirs);
            }
            catch (Exception) { }
        }

        public void Organize(Rule rule)
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
                ((List<string>)temporaryDirectoryList).Add(rule.SearchDirectory);

                EnumerateDirectories(rule.SearchDirectory);
                AddFilesToQueue(rule.Extension);
            }
            
            MoveFiles(rule.TargetDirectory);
        }

        private void MoveFiles(string destPath)
        {
            foreach(string file in temporaryFileList)
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
            foreach(string path in temporaryDirectoryList)
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
            ((List<string>)temporaryDirectoryList).Clear();
            ((List<string>)temporaryFileList).Clear();
        }
    }
}
