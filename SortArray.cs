using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// Program to sort any array, designed by Yusuf Kelo
    /// yusufkel@gmail.com
    /// +0554112774
    /// </summary>
    public class SortArray
    {
        public static int[] Sort(int[] unsortedArray)
        {
            int[] sorted = new int[unsortedArray.Length];
            int min = 0;
            int temp = 0;
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                //check if current index is 0
                if (i == 0)
                {
                    min = unsortedArray[i];
                    sorted[i] = min;
                }
                //if not 0
                else
                {
                    //loop untill i (current index) +1
                    for (int s = 0; s < i+1; s++)
                    {
                        //check if element at i in unsortedArray is smaller than element at s in sorted array
                        if (unsortedArray[i] < sorted[s])
                        {
                             min = unsortedArray[i];
                            temp = sorted[s];
                            //set current  sorted array index to min
                            sorted[s] = min;
                            //replace the element at i in unsortedArray 
                            unsortedArray[i] = temp;

                        }
                        //else add element to the sorted array
                        else
                        {
                            sorted[i] = unsortedArray[i];
                        }

                    }
         
                }

            }
            

            return sorted;

        }



    }
}
