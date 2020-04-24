using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SizeOfFileOrFolder
{
    public class SOFF
    {
        private static long size;

        public SOFF(string path)
        {
            size = 0;
            if (File.Exists(path))
            {
                ProcessFile(path);
            }
            else if (Directory.Exists(path))
            {
                ProcessFolder(path);
            }
            else
            {
                Console.WriteLine($"{path} is not a valid file or directory.");
            }
        }

        private void ProcessFolder(string path)
        {
            string[] fileEntries = Directory.GetFiles(path);
            foreach (var file in fileEntries)
            {
                ProcessFile(file);
            }

            string[] folders = Directory.GetDirectories(path);
            foreach (var folder in folders)
            {
                ProcessFolder(folder);
            }
        }

        private void ProcessFile(string path)
        {
            
            FileInfo fi = new FileInfo(path);
            size += fi.Length;

            Console.WriteLine($"FileName: {fi.Name}, FileSize: {size}");
             
        }

        public void Size()
        {
            Console.WriteLine($"Total size of File or Folder is: {size} bytes.");
        }
    }
}
