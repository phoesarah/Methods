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
            int[] scores = new int[10];
            Console.WriteLine("Please enter 10 scores, press enter after each number");
            //get input
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            int average = getaverage(scores);
            int highest = gethighest(scores);
            int lowest = getlowest(scores);

            // print out the numbers that were entered
            Console.Write("You Entered: ");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write(" " + scores[i]+ ",");

            }
            Console.WriteLine();

            //print out result of functions

            Console.WriteLine("The class average is: " + Convert.ToString(average));
            Console.WriteLine("The highest score is: " + Convert.ToString(highest));
            Console.WriteLine("The lowest score is: " + Convert.ToString(lowest));
         
            Console.ReadKey(); 
        }
       
        //get average of the numbers in the array
        
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

        //Get the highest number in the array
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

        //get the lowest number in the array
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
