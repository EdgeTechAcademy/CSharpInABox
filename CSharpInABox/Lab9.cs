using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpInABox
{
    class Lab9
    {
        static void Main(string[] args)
        {
            // this will create a file you can write to
            // Instantiate a FileStream that will open a file named by the user
            FileStream stream = new FileStream("../../../" + "output", FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(stream);
            string fileName = Utils.GetInput("File to read: ");
            string search = Utils.GetInput("Search string: ");
            var lines = ReadFile(fileName);
            foreach (var line in lines)
            {
                if (line.Contains(search))
                {
                    textOut.WriteLine(line);
                }
            }
            textOut.Close();
        }
        static List<string> ReadFile(string fileName)
        {
            string line;
            List<string> lines = new List<string>();

            //Instantiate a FileStream that will open a file named by the user
            FileStream stream = new FileStream("../../../" + fileName, FileMode.Open, FileAccess.Read);
            StreamReader textFile = new StreamReader(stream);

            // read loop
            while ((line = textFile.ReadLine()) != null)
            {
                lines.Add(line);
            }
            textFile.Close();
            return lines;
        } //end ReadFile()
    }
}
