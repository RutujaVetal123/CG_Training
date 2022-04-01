using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HO_File_Handling_24032022
{
    class HO_File_Handling
    {
        public void WriteFile()
        {
            FileStream fileStream = new FileStream(@"D:\Capgemini\Training_Novidta\Hands on\HO_File_Handling_24032022\test.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine("");
            writer.WriteLine("");
            writer.Close();
            fileStream.Close();
        }
        public void ReadFile()
        {
            FileStream fileStream = new FileStream(@"D:\Capgemini\Training_Novidta\Hands on\HO_File_Handling_24032022\test.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            Console.WriteLine("StudentId\tStudentName\tMark");
            while (reader.Peek() > 0)
            {
                //string line = reader.ReadLine();

                /*if (line.EndsWith("0"))
                {
                }*/
                var studid = reader.ReadLine();
                string[] studIdStr = studid.Split(':');
                string id = studIdStr[1];

                var studname = reader.ReadLine();
                string[] studNameStr = studname.Split(':');
                string name = studNameStr[1];

                var markStr = reader.ReadLine(); //mark:40
                string[] strs = markStr.Split(':');
                int mark = Convert.ToInt32(strs[1]);

                if (mark > 49)

                {
                    Console.WriteLine(id + "\t\t" + name + "\t\t" + mark);

                }
                reader.ReadLine();
                /*var d = Directory.GetDirectories(@"C:\Capg_Training\Sql\Sql_Training_Capg\");
                for (int i = 0; i < d.Length; i++)
                {
                    string[] files = Directory.GetFiles(d[i]);
                    for (int j = 0; j < files.Length; j++)
                    {
                        Console.WriteLine("Folder: " + d[i] + " Filename: " + files[j]);
                    }*/

            }
        }
    }
}
