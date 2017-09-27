using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsorted = { 2, 9, 5, 4, 8, 1, 6,7,3 };
            int[] sorted = SelectionSort(unsorted);

            Console.ReadLine();

        }

        static int[] SelectionSort(int[] myList)
        {
	
	        int end = myList.Length;
            for (int i = 0; i < myList.Length; i++)
	        {
		        int largestvalue = 0;
                int largestvalueIndex = 0;
		        for(int j=0;j<end;j++)
		        {
			        if(largestvalue < myList[j])
				        {
				            largestvalue = myList[j];
				            largestvalueIndex  = j;
				        }
		        }
	
		        int temp = myList[end-1];
		        myList[end-1] = largestvalue;
		        myList[largestvalueIndex] = temp;
	
		        end= end-1;
	
	        }

            return myList;
	
        }
    }
}
