using System;
using System.IO;
using System.Collections.Generic;

namespace PixelDB
{
    public class PixelDB
    {
        Dictionary<string, string> BackingDict;
        public static void CreateFile(string path, string content)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(content);
            }
        }
    }
}
