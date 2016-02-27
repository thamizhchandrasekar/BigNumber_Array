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
          
            int[] array = new int[10];
            int[] big=new int[10];
            int n,i,k=0;

            System.Console.WriteLine("Enter the number of items");
            n = int.Parse(System.Console.ReadLine()); ;
            System.Console.WriteLine("Enter " + n + " Numbers");
            for (i = 0; i < n; i++)
            {
                array[i] = int.Parse(System.Console.ReadLine());
            }
            System.Console.WriteLine("The given Numbers are :");
            for (i = 0; i < n; i++)
            {
                System.Console.Write("\t" + array[i]);
            }


            for ( i = 0; i < array.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < array.Length; j++)
                {

                    if (array[i] == array[j])
                        count = count + 1;
                }
                if (count == 1)
                {
                    big[k] = array[i];
                    k++;
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine(big.Max());
           
            Console.ReadKey();
        }
    }
}
