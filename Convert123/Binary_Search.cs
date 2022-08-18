using System;
namespace Convert123
{
    public class Binary_Search
    {
        public static void Main(string[] args)
        {
            int[] ary = { 1, 2, 5, 7, 9, 11, 22 };
            int low = 0,high = 9,mid;
            int timthay = 0;
            Console.WriteLine("NHap gia tri nguyen: ");
            int giatri = Console.ReadLine();
            while(low <=high)
            {
                mid = (low + high) / 2;
                if (ary[mid] == giatri)
                {
                    Console.WriteLine("\nGia tri" + giatri + "duoc tim thay o vi tri" + mid + "cua mang");
                    timthay = 1;
                    break;
                }
                else if (ary[mid] > giatri)
                {
                    high = mid - 1;
                }
                else 
                    low = mid+1;
            }
            if (timthay == 0)
                Console.WriteLine("\nGia tri" + giatri + "khong duoc tim thay trong mang");
            return 0;
        }
    }
}