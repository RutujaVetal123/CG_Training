using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HO_File_Handling_24032022
{
    class Program
    {
        static void Main(string[] args)
        {
            HO_File_Handling fileHandling = new HO_File_Handling();
            //fileHandling.WriteFile();
            fileHandling.ReadFile();
            Console.Read();
        }
    }
}
