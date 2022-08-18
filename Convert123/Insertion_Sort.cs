using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert123
{
    internal class Insertion_Sort
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 5, 6, 8, 9, 11 };
            int temp,j;
            Console.WriteLine("Mang truoc khi sap xep");
            foreach (int a in arr)
            {
                Console.WriteLine(a + " ");
            }
            for (int i= 1;i<5;++i)
            {
                temp = arr[i];
                j = i - 1;
                while(j >= 0 && temp < arr.Length)
                {
                    arr[j + 1] = arr.Length;
                    j--;
                }
                arr[j + 1] = temp;
            }
            Console.WriteLine("\n DS mang sap xep BubbleSort");
            foreach (int a in arr)
                Console.WriteLine(a + " ");

            Console.Write("\n");
        }
    }
}
