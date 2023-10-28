using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsInCsharp
{
    internal class InheritanceDemo
    {

  
        public class CClass
        {
            public string ClassName { get; set; }
            public List<Teacher> Teachers { get; set; }

            public CClass(string className)
            {
                ClassName = className;
                Teachers = new List<Teacher>();
            }
        }

        public class Teacher
        {
            public string Name { get; set; }
            public string EmployeeID { get; set; }

            public Teacher(string name, string employeeID)
            {
                Name = name;
                EmployeeID = employeeID;
            }
        }

        public class ClassTeacher : Teacher
        {
            public string ClassRoom { get; set; }

            public ClassTeacher(string name, string employeeID, string classRoom) : base(name, employeeID)
            {
                ClassRoom = classRoom;
            }
        }

        public class SubjectTeacher : Teacher
        {
            public string Subject { get; set; }

            public SubjectTeacher(string name, string employeeID, string subject) : base(name, employeeID)
            {
                Subject = subject;
            }
        }

        class Inheritance
        {
            static void Main(string[] args)
            {
                runApp();
            }

            public static void runApp()
            {
                ClassTeacher classTeacher = new ClassTeacher("Mr. Smith", "CT123", "1A");
                SubjectTeacher subjectTeacher = new SubjectTeacher("Mrs. Johnson", "ST456", "Math");
                CClass class1A = new CClass("1A");

                class1A.Teachers.Add(classTeacher);
                class1A.Teachers.Add(subjectTeacher);

                Console.WriteLine($"Class: {class1A.ClassName}");
                Console.WriteLine("Teachers:");
                foreach (Teacher teacher in class1A.Teachers)
                {
                    Console.WriteLine($"Name: {teacher.Name}, Employee ID: {teacher.EmployeeID}");
                    if (teacher is ClassTeacher classTeacherInstance)
                    {
                        Console.WriteLine($"Class Teacher: Class {classTeacherInstance.ClassRoom}");
                    }
                    else if (teacher is SubjectTeacher subjectTeacherInstance)
                    {
                        Console.WriteLine($"Subject Teacher: Subject {subjectTeacherInstance.Subject}");
                    }
                }
            }
        }
    }

}
