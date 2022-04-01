using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn1_140322
{
    class HO1Q2
    {
        public void FindMaxFreq(string str)
        {
            int[] charFreq = new int[255];
            int i = 0, max, l;
            int ascii;
            l = str.Length;

            for (i = 0; i < 255; i++)  //Set frequency of all characters to 0
            {
                charFreq[i] = 0;
            }
            i = 0;
            while (i < l)
            {
                ascii = (int)str[i];
                charFreq[ascii] += 1;

                i++;
            }
            // Console.Write("{0}  ",(char)65);
            max = 0;
            for (i = 0; i < 255; i++)
            {
                if (i != 32)
                {
                    if (charFreq[i] > charFreq[max])
                        max = i;
                }
            }
            Console.Write("The Highest frequency of character '{0}' is appearing for number of times : {1} \n\n", (char)max, charFreq[max]);
        
        }
    }
}
