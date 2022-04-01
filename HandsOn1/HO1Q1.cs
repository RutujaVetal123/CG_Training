using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn1_140322
{
    class HO1Q1
    {
        public void MinMaxFuntn(int []array,int num1)
        {
            
            int max1 = array[0];
            int min1 = array[0];

            for (int i = 1; i < num1; i++)
            {
                if (array[i] > max1)
                {
                    max1 = array[i];
                }


                if (array[i] < min1)
                {
                    min1 = array[i];
                }
            }
            Console.Write("Maximum element is : {0}\n", max1);
            Console.Write("Minimum element is : {0}\n\n", min1);
        }
    }
}
