using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{


    class lab2_pro17
    {
        public static void Main()
        {
            String[] arr = new String[5];
            String temp;
            Console.WriteLine("Enter 5 names");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i][0] > arr[j][0])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
