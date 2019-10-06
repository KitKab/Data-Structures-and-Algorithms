using System;

namespace Ass4_8_KthSmallestElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 10, 4, 3, 20, 15 };
            int k = 3;
            
            int temp = 0;
       
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]>arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }

                }

            }
            Console.Write("The output is :" + arr[k-1]);
            Console.ReadLine();
        }
    }
}
