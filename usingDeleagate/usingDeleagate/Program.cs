using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingDeleagate
{
    internal class Program
    {
        delegate bool  FillitrDelegate(int x);
        static void Main(string[] args)
        {

           

            List<int> number=new List<int>{ 3,76,35,-13,-34,44,66};
            FillitrDelegate even = IsEven;
            Disply(number, even ,"Even");
            Disply(number, IsOdd,"Odd");
            Disply(number, IsEven,"Even");
            Disply(number, isPositive,"Positive" );
            Disply(number, isMulipleOfThree, "Multiple of three");
            Console.WriteLine("++++++++++++++++++++++++");
        
        }
        static bool isPositive(int x)
        { return x >= 0; }
        static bool IsEven(int x)
        {
             
            
            
                return x % 2 == 0;





        }
        static bool IsOdd(int x)
        {



            return x % 2 != 0;





        }
        static bool isMulipleOfThree(int x)
        {

            return x % 3 == 0;
        }
        static void Disply(List<int> ar,FillitrDelegate Filter,string title)
        {
            Console.WriteLine($"====={title}=====)");
            foreach (int item in ar)
            {
                if(IsEven(item))
                {
                    Console.WriteLine(item);


                }



            }




        }
      
      
     
    }
}
