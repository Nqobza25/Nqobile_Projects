
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value1,value2,value3=3,result=0;

            Console.WriteLine("Enter the first value");
            value1 = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Enter the second value");
            value2 = Convert.ToInt32(Console.ReadLine());

            if(value1 == value2)
            {
               result = (value1 + value2) * value3;
                Console.WriteLine("The sum of the values is:"+result);
                SumCheck(value1, value2, result);
            }
            else if(value1 != value2) 
            {
                result= value1 + value2;
                Console.WriteLine("The sum of values is:"+result);
                SumCheck(value1, value2, result);
            }

           

            
            Console.ReadLine();
            
        }
        public static bool SumCheck(int value1, int value2, int result)
        {
            if (value1 == 30 || value2 == 30 ||result == 30) { result = value1 + value2;
                Console.WriteLine(true);
            }
               
            else if (value1 != 30 && value2 != 30 && result != 30) {
                Console.WriteLine(false); }
            return true;
        }
    }
}
