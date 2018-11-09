using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{
    class lab2_pro5
    {
          public static void Main()
	        {
	            int[] arr = {1,2,3,4,5,3,2,1,7,5 };
	            bool[] vr = new bool[10];
	            Console.WriteLine("array element: ");
	            for (int i = 0; i < arr.Length; i++)
	            {
	                vr[i] = false;
	                Console.Write(arr[i]+" , ");
	            }
	            Console.WriteLine("\nGrouped Array");
	            for (int i = 0; i < arr.Length; i++)
	            {
	                
	                if (!vr[i])
	                {
	                    Console.Write(arr[i]+" , ");
	                    for (int j = i + 1; j < arr.Length; j++)
	                    {
	                        if (arr[i] == arr[j])
	                        {
	                            Console.Write(arr[j]+" , ");
	                            vr[j] = true;
	                        }
	                    }
	                }
	            }
	
	        }
  }
}
