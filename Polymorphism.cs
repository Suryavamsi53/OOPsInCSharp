using System;
using System.Collections.Generic;

namespace OOPsInCsharp
{
    // Base class for the grade card
    public class BasicGradeCard
    {
        // Properties to store student details
        public string StudentName { get; set; }
        public int RollNumber { get; set; }
        public string Grade { get; set; }

        // Constructor to initialize the properties
        public BasicGradeCard(string studentName, int rollNumber, string grade)
        {
            StudentName = studentName;
            RollNumber = rollNumber;
            Grade = grade;
        }

        // Virtual method to display the grade card
        public virtual void DisplayGradeCard()
        {
            Console.WriteLine("Basic Grade Card:");
            Console.WriteLine($"Student Name: {StudentName}");
            Console.WriteLine($"Roll Number: {RollNumber}");
            Console.WriteLine($"Grade: {Grade}");
        }
    }

    // Derived class for elementary school grade cards
    public class ElementarySchoolGradeCard : BasicGradeCard
    {
        // Additional property for the section
        public string Section { get; set; }

        // Constructor to initialize properties of the base class and the section
        public ElementarySchoolGradeCard(string studentName, int rollNumber, string grade, string section)
            : base(studentName, rollNumber, grade)
        {
            Section = section;
        }

        // Override method to display elementary school grade card
        public override void DisplayGradeCard()
        {
            Console.WriteLine("Elementary School Grade Card:");
            Console.WriteLine($"Student Name: {StudentName}");
            Console.WriteLine($"Roll Number: {RollNumber}");
            Console.WriteLine($"Section: {Section}");
            Console.WriteLine($"Grade: {Grade}");
        }
    }

    // Derived class for middle school grade cards
    public class MiddleSchoolGradeCard : BasicGradeCard
    {
        // Additional property for the house
        public string House { get; set; }

        // Constructor to initialize properties of the base class and the house
        public MiddleSchoolGradeCard(string studentName, int rollNumber, string grade, string house)
            : base(studentName, rollNumber, grade)
        {
            House = house;
        }

        // Override method to display middle school grade card
        public override void DisplayGradeCard()
        {
            Console.WriteLine("Middle School Grade Card:");
            Console.WriteLine($"Student Name: {StudentName}");
            Console.WriteLine($"Roll Number: {RollNumber}");
            Console.WriteLine($"House: {House}");
            Console.WriteLine($"Grade: {Grade}");
        }
    }

    // Derived class for high school grade cards
    public class HighSchoolGradeCard : BasicGradeCard
    {
        // Additional property for the club
        public string Club { get; set; }

        // Constructor to initialize properties of the base class and the club
        public HighSchoolGradeCard(string studentName, int rollNumber, string grade, string club)
            : base(studentName, rollNumber, grade)
        {
            Club = club;
        }

        // Override method to display high school grade card
        public override void DisplayGradeCard()
        {
            Console.WriteLine("High School Grade Card:");
            Console.WriteLine($"Student Name: {StudentName}");
            Console.WriteLine($"Roll Number: {RollNumber}");
            Console.WriteLine($"Club: {Club}");
            Console.WriteLine($"Grade: {Grade}");
        }
    }

    class Polymorphism
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            // Create a list to store different grade cards
            List<BasicGradeCard> gradeCards = new List<BasicGradeCard>();

            // Create instances of grade cards for different levels and add them to the list
            gradeCards.Add(new ElementarySchoolGradeCard("Alice", 101, "A", "Section A"));
            gradeCards.Add(new MiddleSchoolGradeCard("Bob", 201, "B", "Blue House"));
            gradeCards.Add(new HighSchoolGradeCard("Charlie", 301, "C", "Science Club"));

            Console.WriteLine("Displaying Grade Cards:");
            foreach (var gradeCard in gradeCards)
            {
                gradeCard.DisplayGradeCard(); // Polymorphism: Calls the appropriate overridden method
                Console.WriteLine();
            }
        }
    }
}
