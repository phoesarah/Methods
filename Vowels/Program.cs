using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] characters = new char[] { 'a', 'b', 'd', 't', 'y', 'e', 'e', 'c', 'r', 'u', 'i', 'i', 'o', 'o', 'e', 'd', 'a' };
            int number = getNumberofVowels(characters);
            Console.WriteLine(Convert.ToString(number));
            int numberofcons = getNumberofCons(characters);
            Console.WriteLine(Convert.ToString(numberofcons));
            Console.ReadLine();

        }
        static int getNumberofVowels(char[] arr)
        {
            int number = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                
                if (arr[i] == 'a' || arr[i] == 'e' || arr[i] == 'i' || arr[i] == 'o' || arr[i] == 'u')
                {
                    number += 1;
                }
            }

            return number;
        }

        static int getNumberofCons(char[] arr)
        {
            int number = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] != 'a' && arr[i] != 'e' && arr[i] != 'i' && arr[i] != 'o' && arr[i] != 'u')
                {
                    number += 1;
                }
            }
            return number;

        }
    }
}
