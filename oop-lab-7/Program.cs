using System;
using MyLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Person person = new Person("John", "Doe", new DateTime(1990, 5, 15));
            person.ShowInfo();
            Console.WriteLine();

            
            Abiturient abiturient = new Abiturient("Jane", "Smith", new DateTime(2000, 10, 20), 180, 85, "High School #1");
            abiturient.ShowInfo();
            Console.WriteLine();

           
            Student student = new Student("Alice", "Johnson", new DateTime(1998, 8, 25), 2, "B-15", "Computer Science", "University XYZ");
            student.ShowInfo();
            Console.WriteLine();

            
            Teacher teacher = new Teacher("Robert", "Brown", new DateTime(1985, 3, 10), "Associate Professor", "Computer Science", "University XYZ");
            teacher.ShowInfo();
            Console.WriteLine();

           
            LibraryUser libraryUser = new LibraryUser(123456, DateTime.Now, 10.5);
            libraryUser.ShowInfo();
            Console.WriteLine();

            Console.ReadLine(); 
        }
    }
}
