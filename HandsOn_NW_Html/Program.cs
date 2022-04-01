using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HO_FileHandling_html
{
    class Program
    {
        static void Main(string[] args)
        {
                
                File_Handle_Html fileHandling = new File_Handle_Html();
                //fileHandling.WriteFile();
                fileHandling.ReadFile();
                Console.Read();
            
        }
    }
}
