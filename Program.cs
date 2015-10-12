using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
       
            int []sorted=SortArray.Sort(new int[] { 99,67,88,1,3,2,22,18,34,25,16,8,3,4,66,44,52,2,1,2,0});
            for (int i = 0; i < sorted.Length; i++)
            {
                Console.WriteLine(sorted[i]);
            }
            Console.Read();

        }
    }
}
