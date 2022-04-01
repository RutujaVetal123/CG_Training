using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn1_140322
{
    class Program
    {
        static void Main(string[] args)
        {

            //-------------------- Hands on Question 1 --------------------//
            //int []array;
            //int num;
            //Console.Write("Find maximum and minimum element in an array :\n");
            //num = Convert.ToInt32(Console.ReadLine());

            //array = new int[num];

            //Console.Write("Input {0} elements in the array :\n", num);
            //for (int i=0;i<num;i++)
            //{
            //    array[i] =Convert.ToInt32(Console.ReadLine());
            //}

            //HO1Q1 que1 = new HO1Q1();
            //que1.MinMaxFuntn(array, num);

            //-------------------- Hands on Question 2 --------------------//  ctrl+k+c
            //string str;

            //Console.Write("Find maximum occurring character in a string :\n");
            //Console.Write("Input the string : ");
            //str = Console.ReadLine();

            //HO1Q2 que2 = new HO1Q2();
            //que2.FindMaxFreq(str);


            //-------------------- Hands on Question 3 --------------------//  (check before commenting {} brackets for main functiom)

            string str1 = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine("Original string: " + str1);
            Console.WriteLine("Position of the word 'fox' in the said string: " + test(str1, "fox"));
            Console.WriteLine("Position of the word 'The' in the said string: " + test(str1, "The"));
            Console.WriteLine("Position of the word 'lazy' in the said string: " + test(str1, "lazy"));
        }    
            public static int test(string text, string word)
            {
                return Array.IndexOf(text.Split(' '), word) + 1;
            }

    
    }
}
