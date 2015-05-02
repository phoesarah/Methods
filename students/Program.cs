using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] {72, 54, 100, 33, 99, 100, 100, 75, 57, 80, 82, 88, 95, 95};

            int average = getaverage(scores);
            int highest = gethighest(scores);
            int lowest = getlowest(scores);
            Console.WriteLine("The class average is: " + Convert.ToString(average));
            Console.WriteLine("The highest score is: " + Convert.ToString(highest));
            Console.WriteLine("The lowest score is: " + Convert.ToString(lowest));
            Console.ReadKey(); 
        }
        static int getaverage(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                
                int n = arr[i];
                sum = n + sum;
                 
            }
            int average = sum / arr.Length;
            return average;
        }
        static int gethighest(int[] arr)
        {
            int highest = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                                 
                if (arr[i] > highest)
                {
                    highest = arr[i];
                }
             }

            return highest;
        }

        static int getlowest(int[] arr)
        {
            int lowest = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
               
                if (arr[i] < lowest)
                {
                    lowest = arr[i];
                }
            }

            return lowest;
        }
    }
}
