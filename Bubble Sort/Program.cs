using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        int i;
        int print_array(int[] array,int l);
        int bubble_sort(int[] array,int l);

        static void Main(string[] args)
        {
            Program obj = new Program();
            int [] array = new int[5] {5,4,3,2,1};
 
 foreach (int item in array) { 
                Console.Write(item + " ");
            }
 obj.bubble_sort(array,5);
 
        }
        /// <summary>
        /// ///////////////////////////////////////////////////
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="size"></param>
    void bubble_sort(int arr, int size)
{
 bool not_sorted = true;
 int j=0,tmp;
 
 while (not_sorted)
 {
 not_sorted = false;
 j++;
 for (int i = 0; i < size - j; i++)
 {
     if (arr[i] > arr[i + 1])
    {
        tmp = arr[i];
        arr[i] = arr[i + 1];
        arr[i + 1] = tmp;
     not_sorted = true;
    }//end of if
 print_array(arr,5);
 }//end of for loop
 }//end of while loop
}//end of bubble_sort
        ///////////////////////////////////////////////
        void print_array(int array[], int size)
{
 Console.WriteLine("buble sort steps: ");
 
           


}//end of print_array
 
    }
}
