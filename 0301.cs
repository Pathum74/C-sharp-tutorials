/*
 Design a C# class named Course that encapsulates information about a student's course and demonstrates proper use of access 
 specifiers and properties. The class should have the following:

•	Private fields for courseName, instructorName, and grade (double between 0 and 100).
•	Public properties for CourseName (read-only) and Grade (read-only) with validation (throw exceptions for invalid data).
•	A public method SetInstructorName to set the instructor's name with validation (empty strings not allowed).
•	A private method CalculateLetterGrade to calculate the letter grade based on the grade (A-F) and return it as a string.
•	A public method PrintCourseInfo that displays the course name, instructor name, and letter grade without revealing the 
actual numeric grade.
*/



using System;


namespace InventorySystem
{

    class Course
    {
        private string courseName { get; } //field
        private string instructorName;    //,
        private double grade { get; }      //,

        public Course(string CourseName, double Grade) //properties
        {
            //Validate course name
            if (string.IsNullOrWhiteSpace(CourseName))
            {
                throw new ArgumentNullException("Course name cannot be empty. ", nameof(courseName));
            }

            //Validate for grade
            if (grade < 0 || 100 < grade)
            {
                throw new ArgumentOutOfRangeException("Grade must be between 0 & 100 ", nameof(grade));
            }

            courseName = CourseName;
            grade = Grade;
        }

        public void SetInstructorName(string InstructorName) //public method
        {
            //Validate instructer name
            if (string.IsNullOrWhiteSpace(InstructorName))
            {
                throw new ArgumentNullException("Empty strings not allowed", nameof(InstructorName));
            }

            instructorName = InstructorName;
        }

        private string CalculateLetterGrade()  //private method
        {
            if (grade > 100) return "Wrong input";
            else if (grade >= 75) return "A";
            else if (grade >= 65) return "B";
            else if (grade >= 50) return "C";
            else return "F";
        }

        public static void PrintCourseInfo(Course course)
        {
            string letterGrade = course.CalculateLetterGrade();
            Console.WriteLine("Course: " + course.courseName);
            Console.WriteLine("Name: " + course.instructorName);
            Console.WriteLine("Garde: " + letterGrade);
        }
    }

    class program
    {
        public static void Main(string[] args)
        {
            Course co = new Course("Math", 95);
            co.SetInstructorName("Eagle");
            Course.PrintCourseInfo(co);

            Console.ReadKey();
        }
    }

}

