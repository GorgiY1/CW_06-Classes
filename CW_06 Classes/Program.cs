using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_06_Classes
{
    class Class1
    {

    }
    class Student
    {
        public const string University = "ITStep";

        public readonly string Country = "Ukraine";

        private string _lastName = "Doe";
        private string _firstName = "John";

        private static string _city;

        static Student()
        {
            //_lastName = "Doe";
            _city = "Odesa";
        }
        public Student(Student student)
        {
            _lastName = student._lastName;
            _firstName = student._firstName;
        }

        public Student(string country)
        {
            Country = country;
        }

        public Student(string lastName, string _firstName, string country):this(country)
        {
            _lastName = lastName;
            this._firstName = _firstName;
            
        }

        public static void SetCity(string city)
        {
            //_lastName = "Doe";
            _city = city;
        }
        internal string GetCity()
        {
            return _city;
        }
        internal string GetCity1()
        {
            _lastName = "Smet";
            return _city;
        }

        public void Method(Class1 class1)
        {
            //class1.Method(this);
        }
        public void Print()
        {
            Console.WriteLine($"{_lastName}{_firstName}{Country}{University}");
        }
        //Student();
        private void Add(int x, int y) { }
        private void Add(float x, int y) { }
        private void Add(float x, uint y) { }
    }

    class Program
    {
        static void Main(string[] args)
        {                                                         
            Student student = null;                               
                                                                  
            student = new Student("Ukraine");                     
                                                                  
            Student.SetCity("Kharkov");                           
                                                                  
            Console.WriteLine(student.GetCity());                 
                                                                  
            Student student1 = new Student("Poland");             
                                                                  
            Console.WriteLine(student1.GetCity());                
                                                                  
            Console.WriteLine(Student.University);

            Student student2 = new Student(student1);

            student2.Print();

            Student student3 = student2;


            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
