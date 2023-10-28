using System;
using System.Collections.Generic;

namespace OOPsInCsharp{
    public class Subject
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
    }

    public class Teacher
    {
        public string Name { get; set; }
        public string ContactAddress { get; set; }
        public DateTime DateOfJoining { get; set; }
    }



    public class Student
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string GuardianName { get; set; }
        public string ContactNumber { get; set; }
    }


    public class CClass
    {
        public string Name { get; set; }
        public Teacher ClassTeacher { get; set; }
        public List<Student> Students { get; set; }
        public List<Subject> Subjects { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            string[] arrSubjects = { "English Literature", "English Language", "Maths", "Geography", "History", "Physics", "Chemistry", "Biology" };
            string[] arrSubjectShorts = { "ELIT", "ELANG", "MATH", "GEOG", "HIST", "PHY", "CHEM", "BIO" };

            string[] arrStudents = { "Rahul Gandhi", "Vijay Mallya", "Lady Gaga", "Arun Jaitley", "MS Dhoni", "Kim Kardashian" };
            List<Student> listStudents = new List<Student>();
            List<Subject> listSubjects = new List<Subject>();

            for (int i = 0; i < arrSubjects.Length; i++)
            {
                Subject subject = new Subject();
                subject.Name = arrSubjects[i];
                subject.ShortName = arrSubjectShorts[i];
                listSubjects.Add(subject);
            }

            for (int i = 0; i < arrStudents.Length; i++)
            {
                Student student = new Student();
                student.Name = arrStudents[i];
                student.Address = "Some address";
                student.ContactNumber = "124567";
                student.GuardianName = "My Guardian";
                listStudents.Add(student);
            }

            Teacher classTeacher = new Teacher();
            classTeacher.Name = "Mr.RadheShyam";
            classTeacher.DateOfJoining = Convert.ToDateTime("2010-09-11 00:00:00");
            classTeacher.ContactAddress = "Some address";

            CClass class1A = new CClass();
            class1A.Name = "1A";
            class1A.Students = listStudents;
            class1A.Subjects = listSubjects;
            class1A.ClassTeacher = classTeacher;



            Console.WriteLine("Class 1A Information:");
            Console.WriteLine($"Name: {class1A.Name}");
            Console.WriteLine("Subjects:");
            foreach (var subject in class1A.Subjects)
            {
                Console.WriteLine($"- Name: {subject.Name}, Short Name: {subject.ShortName}");
            }
            Console.WriteLine($"Class Teacher: {class1A.ClassTeacher.Name}");
            Console.WriteLine("Students:");
            foreach (var student in class1A.Students)
            {
                Console.WriteLine($"- Name: {student.Name}, Address: {student.Address}, Contact Number: {student.ContactNumber}, Guardian: {student.GuardianName}");
            }
        }
    }
}