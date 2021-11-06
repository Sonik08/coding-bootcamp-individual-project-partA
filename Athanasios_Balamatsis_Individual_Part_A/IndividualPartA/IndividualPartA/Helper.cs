using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA
{
    class Helper
    {
        // START - METHODS OF COURSE CLASS

        //The following method assigns to the Course class the courseTitle value
        //While loop until user's input is valid. Validation within loop by calling IsValidCourseTitle()
        //courseTitle converted to Uppercase before returned
        public static string GetCourseTitle()
        {
            Console.WriteLine("Please enter a valid Course Title. Valid Titles start with 'CB' and are accompanied by a number e.g 'CB9'");
            string courseTitle = Console.ReadLine();

            while (!(InputValidation.IsValidCourseTitle(courseTitle)))
            {
                Console.WriteLine("Invalid input. Please enter a valid Course Title. Valid Titles start with 'CB' and are accompanied by a number e.g 'CB9'");
                courseTitle = Console.ReadLine();
            }
            
            courseTitle = courseTitle.ToUpper();
            

            return courseTitle;
        }

        public static CourseStream GetCourseStream()
        {
            Console.WriteLine("Please enter a valid Course Stream. Valid inputs: Java, CSharp, Python, JavaScript");
            string courseStream = Console.ReadLine();

            while (!(InputValidation.isValidCourseStream(courseStream)))
            {
                Console.WriteLine("Invalid input. Please enter a valid Course Stream. Valid inputs: Java, CSharp, Python, JavaScript");
                courseStream = Console.ReadLine();
            }
            

            return (CourseStream)Enum.Parse(typeof (CourseStream), courseStream.ToUpper());
        }

        //public static CourseType GetCourseType()
        //{

        //}

        //public static DateTime GetCourseStartDate()
        //{

        //}

        //public static DateTime GetCourseEndDate()
        //{

        //}
        // END - METHODS OF COURSE CLASS
    }
}
