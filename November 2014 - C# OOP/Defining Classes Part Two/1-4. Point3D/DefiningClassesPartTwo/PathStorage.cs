using System;
using System.IO;

namespace PointStuff
{
    class PathStorage
    {
        public static void SavePath(Path path, string file)
        {
            File.WriteAllText(file, path.ToString());
        }

        public static string LoadPath(string file)
        {
            return File.ReadAllText(file);
        }
    }
}
