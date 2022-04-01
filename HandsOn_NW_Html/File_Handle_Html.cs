using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HO_FileHandling_html
{
    class File_Handle_Html
    {
        public void ReadFile()
        {
            FileStream fileStream = new FileStream(@"D:\Capgemini\Training_Novidta\Hands on\HO_FileHandling_html\mydata.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            int count = 0;
            string Word = "<input";
            while (reader.Peek() > 0)
            {
                string line = reader.ReadLine();
                if (line.Contains(Word))
                {
                    Console.WriteLine(line);
                    count++;
                }
            }
            Console.WriteLine("Number of <input = " + count);
            reader.Close();
            fileStream.Close();
        }
    }
}
