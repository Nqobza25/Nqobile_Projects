
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string studentNames = "Kabelo;Thlape;20;Thabang;Sithole;23;Caroline;Smith;22";



        }
        //create a logic to store students from studentNames variable into the list
        public Student Student1(string studentNames, Student student)
        {

            List<string> students = new List<string>()
       {
                studentNames.Split(',')[0],
                studentNames.Split(',')[1],
                studentNames.Split(',')[2],
            studentNames.Insert(0, "Kabelo;Thlape;20;"),
            studentNames.Insert(1, "Thabang;Sithole;23;"),
            studentNames.Insert(2, "Caroline;Smith;22;") };
          foreach (Student Students in Student)
            {
                Console.WriteLine(students);
            }
        } 
            
           
        }
    }

