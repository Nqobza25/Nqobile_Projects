using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region anonymousObject  
            int r = 7;

            int y = r + 5;

            //var x =  "k" ;

            //anonymous type
            var x = 5;
            x = 4;

            Console.WriteLine(x);

            //anonymous type
            var stObject = new
            {
                StNumber = "ST10166349",
                FirstName = "Nqobile",
                LastName = " Sibiya",
                Adress = new
                {
                    StreetNo = "021",
                    StreetName = "Penelope",
                    Code = "1971"
                }






            };
            //stObject.FirstName = "Nqobile";
            Console.WriteLine( stObject.StNumber + ""+ stObject.FirstName +"\n"     );
            #endregion
           


            /*   variable = from subsetvariable in collection
                       where condition/test subsetvariable 
                       select subsetvariable;
             ==subsetvariable can be any name
            ==collection can be any collection
             */
            //var
            //variable = from subsetvariable in collection
            //           where subsetvariable.property == "value"
            //           select subsetvariable;
            int[] numbers = new int[] {13, 5, 7, 2, 9, 3 };
            List<int> lsnumber = new List<int>() { 13, 5, 7, 2, 9,3,22,24,56 };

            var greaterThan5 = from num in numbers
                               where num > 5
                               orderby num descending
                               select num;
            //var greaterThan5 = numbers.Where(num => num > 5);
            ///*using Linq , get all the even numbers from the list*/

            //foreach (int num in greaterThan5)
            //{
            //    Console.WriteLine(num);
            //}
            
            var evenNumbers = from num1 in lsnumber
                              where num1 % 2 ==0
                              select num1;


            foreach (int num1 in evenNumbers)
            {

                Console.WriteLine(num1);
            }

            Console.Read();

        }
    }
}
