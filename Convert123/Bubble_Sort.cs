using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert123
{
    
        public class Bubble_Sort
        {
            public static void Main(string[] args)
            {
                int[] arr = { 6, 3, 0, 1, 2 };
                int temp;
                Console.WriteLine("Mang truoc khi sap xep");
                foreach (int a in arr)
                {
                    Console.WriteLine(a + " ");
                }
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    for (int j = 0; j <= arr.Length - 2; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            temp = arr[j + 1];
                            arr[j + 1] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
                Console.WriteLine("\n DS mang sap xep BubbleSort");
                foreach (int a in arr)
                    Console.WriteLine(a + " ");

                Console.Write("\n");


            }
        }
    }


