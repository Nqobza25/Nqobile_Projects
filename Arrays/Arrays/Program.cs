using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //int[] numbers = new int[3];     // initializing array and seting how many values are needed empty array



            // numbers[0] = 5;    //assigning values to the array from index 1 to 3
            ///numbers[1] = 7;
            //numbers[2] = 1;



            int[] numbers2 = { 6, 7, 1, 18, 10, 12 }; //an array with initial values 
            int[] numbers3 = { 2, 4, 6, 8, 10 };
            string[] names = { "Nqobile","joe"+"rugal" };
            int max = 0;
            // calculate the sum of even numbers
            int sum = 0;


            for (int i = 0; i < numbers2.Length; i++)
            {
                //6,7,10,18,12


                if (numbers2[i] % 2 == 0)
                {
                    sum = sum + numbers2[i];
                }
                if (max > numbers2[i])
                {
                   


                }
            }
            int higest = numbers2[0];
            for (int i = 1; i < numbers2.Length; i++)
            {


                if (numbers2[i] > higest)
                {
                    higest = numbers2[i];

                }
                

            }int shorhlength = names[0].Length;
    string shortName = "none";
            for (int i = 0; i < names.Length; i++) {
                if (names[i].Length <= shorhlength){
                    shorhlength = names[i].Length;
                    shortName = names[i];
                }

            }

            Console.WriteLine($"Max:{higest}");
            Console.WriteLine($"Sum : {sum}"); //$ is made to replace +  and the {} are place hlders
            Console.WriteLine($"Names:{shorhlength}");
            Console.Read();
        }
    }
}
