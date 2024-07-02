using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassActivity
{
    internal class Student
    {
       
        public Student(int age, string firstName, string lastName)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
   
}
   
