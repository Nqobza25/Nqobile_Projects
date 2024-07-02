using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDelegates2
{
    internal class Program
    {
        //delegate
        delegate void PrintDelegate(string msg);



        static void Main(string[] args)
        {

            ConnectToDB(PrintToCosole);
            ConnectToDB(PrintToFile);


        }
        static void PrintToCosole(string message)
        {
            Console.WriteLine(message);
        }
        static void PrintToFile(string message)
        {
            //logic to print to file 
        }
        static void ConnectToDB(PrintDelegate logFile)
        {

            //LOGIC TO CONNNECT TO DATABASES
            logFile("Connected to DB");
        }

    }
}
