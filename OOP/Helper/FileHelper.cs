using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOP.Helper
{
    public class FileHelper
    {
        public static string Read(string path)
        {
            string text = File.ReadAllText(path);
            return text;
        }
    }
}
