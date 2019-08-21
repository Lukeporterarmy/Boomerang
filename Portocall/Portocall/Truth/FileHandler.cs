using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Portocall.Truth
{
    class FileHandler
    {
        public string path;
        public FileHandler(string file)
        {
            path = Path.Combine(Directory.GetCurrentDirectory(), $"..\\..\\..\\Truth/{file}");
            FileCreate();
        }

        public void DeleteFile()
        {
            File.Delete(path);
        }
        void FileCreate()
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (var file = File.Create(path))
            {
                file.Close();
            }
        }

        public void FileWrite(string code)
        {
            var file = File.Create(path);
            file.Close();
            using(var sw = new StreamWriter(path))
            {
                sw.Write(code);
            }
        }

        public void FileWrite(char[] code)
        {
            string build = "";
            foreach(char character in code)
            {
                build += character;
            }

            using (var sw = new StreamWriter(path))
            {
                sw.Write(build);
            }
        }

        public string GetContents()
        {
            return File.ReadAllText(path);
        }
    }
}
