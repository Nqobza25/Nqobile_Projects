using System;
using StudenLibray1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestingStudentLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student st = new Student("ST123","Micheal","Smith",21);
            Student.AddStudent(new Student("ST123", "Serena", "Smith", 48));
            Student.AddStudent(new Student("ST124", "Rodger", "Smith", 50));
            Student.AddStudent(new Student("ST15", "Micheal", "Smith",30));
            Student.AddStudent(new Student("ST126", "Jessica", "Jones", 11));
            Student.AddStudent(new Student("ST127", "Micheal", "Specter",35));
            Student.AddStudent(new Student("ST128", "Kevin", "De bruyne", 28));
            Student.AddStudent(new Student("ST129", "Novak", "Djokovic", 29));
            foreach (Student st in Student.AllStudents())
            {
                Console.WriteLine(st.ToString());
            }
            Console.Read();
            Console.Beep();
        }
       
    }
}
