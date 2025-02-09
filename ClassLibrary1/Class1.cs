using System;

namespace MyLibrary
{
    public class Student : Person
    {
        public int Course { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }
        public string University { get; set; }

        public Student() { }

        public Student(string firstName, string lastName, DateTime dateOfBirth, int course, string group, string faculty, string university)
            : base(firstName, lastName, dateOfBirth)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            University = university;
        }

        public Student(Student other)
            : base(other)
        {
            Course = other.Course;
            Group = other.Group;
            Faculty = other.Faculty;
            University = other.University;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Course: {Course}");
            Console.WriteLine($"Group: {Group}");
            Console.WriteLine($"Faculty: {Faculty}");
            Console.WriteLine($"University: {University}");
        }
    }

    public class Teacher : Person
    {
        public string Position { get; set; }
        public string Department { get; set; }
        public string University { get; set; }

        public Teacher() { }

        public Teacher(string firstName, string lastName, DateTime dateOfBirth, string position, string department, string university)
            : base(firstName, lastName, dateOfBirth)
        {
            Position = position;
            Department = department;
            University = university;
        }

        public Teacher(Teacher other)
            : base(other)
        {
            Position = other.Position;
            Department = other.Department;
            University = other.University;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"University: {University}");
        }
    }

    public class LibraryUser
    {
        public int CardNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public double MonthlyFee { get; set; }

        public LibraryUser() { }

        public LibraryUser(int cardNumber, DateTime issueDate, double monthlyFee)
        {
            CardNumber = cardNumber;
            IssueDate = issueDate;
            MonthlyFee = monthlyFee;
        }

        public LibraryUser(LibraryUser other)
        {
            CardNumber = other.CardNumber;
            IssueDate = other.IssueDate;
            MonthlyFee = other.MonthlyFee;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Card Number: {CardNumber}");
            Console.WriteLine($"Issue Date: {IssueDate}");
            Console.WriteLine($"Monthly Fee: {MonthlyFee}");
        }
    }
}
