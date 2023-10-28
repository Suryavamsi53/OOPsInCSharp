using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsInCsharp
{
    internal class Interface

    {
        // Define an interface for storing details of people
        public interface IPerson
        {
            string Name { get; set; }
            int Age { get; set; }
            string Address { get; set; }
        }

        // Create a class for students that implements the IPerson interface
        public class Student : IPerson
        {
            // Properties required by the IPerson interface
            public string Name { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }

            // Additional properties for the Student class
            public int StudentID { get; set; }
            public string Grade { get; set; }

            // Constructor to initialize properties
            public Student(string name, int age, string address, int studentID, string grade)
            {
                Name = name;
                Age = age;
                Address = address;
                StudentID = studentID;
                Grade = grade;
            }

            // Method to display student details
            public void DisplayStudentDetails()
            {
                Console.WriteLine("Student Details:");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
                Console.WriteLine($"Address: {Address}");
                Console.WriteLine($"Student ID: {StudentID}");
                Console.WriteLine($"Grade: {Grade}");
            }
        }

        // Create a class for teachers that implements the IPerson interface
        public class Teacher : IPerson
        {
            // Properties required by the IPerson interface
            public string Name { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }

            // Additional properties for the Teacher class
            public string EmployeeID { get; set; }
            public string Subject { get; set; }

            // Constructor to initialize properties
            public Teacher(string name, int age, string address, string employeeID, string subject)
            {
                Name = name;
                Age = age;
                Address = address;
                EmployeeID = employeeID;
                Subject = subject;
            }

            // Method to display teacher details
            public void DisplayTeacherDetails()
            {
                Console.WriteLine("Teacher Details:");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
                Console.WriteLine($"Address: {Address}");
                Console.WriteLine($"Employee ID: {EmployeeID}");
                Console.WriteLine($"Subject: {Subject}");
            }
        }

        // Create a class for office staff that implements the IPerson interface
        public class OfficeStaff : IPerson
        {
            // Properties required by the IPerson interface
            public string Name { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }

            // Additional properties for the OfficeStaff class
            public string StaffID { get; set; }
            public string Department { get; set; }

            // Constructor to initialize properties
            public OfficeStaff(string name, int age, string address, string staffID, string department)
            {
                Name = name;
                Age = age;
                Address = address;
                StaffID = staffID;
                Department = department;
            }

            // Method to display office staff details
            public void DisplayOfficeStaffDetails()
            {
                Console.WriteLine("Office Staff Details:");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
                Console.WriteLine($"Address: {Address}");
                Console.WriteLine($"Staff ID: {StaffID}");
                Console.WriteLine($"Department: {Department}");
            }
        }

        class Interfaces
        {
            static void Main(string[] args)
            {
                runApp();
            }

            public static void runApp()
            {
                // Create instances of different people entities
                Student student = new Student("Alice", 18, "123 Main St", 1001, "A");
                Teacher teacher = new Teacher("Mr. Smith", 35, "456 Elm St", "T1001", "Math");
                OfficeStaff staff = new OfficeStaff("John", 28, "789 Oak St", "S2001", "Administration");

                // Display details of each entity
                student.DisplayStudentDetails();
                Console.WriteLine();
                teacher.DisplayTeacherDetails();
                Console.WriteLine();
                staff.DisplayOfficeStaffDetails();
            }
        }
    }
}