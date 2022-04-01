using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HO_File_Handling_NW_24032022
{
    class Program
    {
        static void Main(string[] args)
        {

            NW_File_Handling fileHandling = new NW_File_Handling();
            //fileHandling.WriteFile();
            fileHandling.ReadFile();
            Console.Write("\n");

            Console.WriteLine("\nDialed");
            Dialed dialed = new Dialed();
            dialed.Read_Dialed();
            Console.Write("\n");

            Console.WriteLine("\nMissed");
            Missed missed = new Missed();
            missed.Read_Missed();
            Console.Write("\n");

            Console.WriteLine("\nSuccess");
            Success success = new Success();
            success.Read_Success();
            Console.Write("\n");

            Console.WriteLine("\nFailed");
            Failed failed = new Failed();
            failed.Read_Failed();
            Console.Write("\n");

        }
    }
}
