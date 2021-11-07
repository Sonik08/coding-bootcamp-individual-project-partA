using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA
{
    class Helper
    {
        // START - METHOD THAT PRINTS THE ELEMENTS OF A LIST
        public static void PrintAllCourses(List<Course> listAllCourses)
        {
            foreach (Course course in listAllCourses)
            {
                course.ShowData();
                Console.WriteLine(" ");
            }
        }
        // END - METHOD THAT PRINTS THE ELEMENTS OF A LIST


        // START - METHODS OF COURSE CLASS

        //The following method assigns to the Course class object the courseTitle value
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

        //The following method assigns to the Course class object the courseStream value
        //While loop until user's input is valid. Validation within loop by calling IsValidCourseStream()
        public static CourseStream GetCourseStream()
        {
            Console.WriteLine("Please enter a valid Course Stream. Valid inputs: Java, CSharp, Python, JavaScript");
            string courseStream = Console.ReadLine();

            while (!(InputValidation.IsValidCourseStream(courseStream)))
            {
                Console.WriteLine("Invalid input. Please enter a valid Course Stream. Valid inputs: Java, CSharp, Python, JavaScript");
                courseStream = Console.ReadLine();
            }
            

            return (CourseStream)Enum.Parse(typeof (CourseStream), courseStream.ToUpper());
        }

        //The following method assigns to the Course class object the courseType value
        //While loop until user's input is valid. Validation within loop by calling IsValidCourseType()
        public static CourseType GetCourseType()
        {
            Console.WriteLine("Please enter a valid Course Type. Valid inputs: FT , PT . FT stands for Full-Time, PT stands for Part-Time");
            string courseType = Console.ReadLine();

            while (!(InputValidation.IsValidCourseType(courseType)))
            {
                Console.WriteLine("Invalid input. Please enter a valid Course Type. Valid inputs: FT , PT . FT stands for Full-Time, PT stands for Part-Time");
                courseType = Console.ReadLine();
            }


            return (CourseType)Enum.Parse(typeof(CourseType), courseType.ToUpper());
        }

        //The following method assigns to the Course class object the courseStartDate value
        //
        public static DateTime GetCourseStartDate()
        {
            //Console.WriteLine("Please enter a valid Course Start Date. Valid input format: dd/mm/yyyy example: 30/05/2020 ");
            //int courseStartDate = Console.ReadLine();

            //while (!(InputValidation.IsValidCourseStartDate(courseStartDate)))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid Course Start Date. Valid input format: dd/mm/yyyy example: 30/05/2020 ");
            //    courseStartDate = Console.ReadLine();
            //}

            //DateTime courseStartDateConverted = Convert.ToDateTime(courseStartDate);
            var today = DateTime.Today;

            return today;
        }

        //The following method assigns to the Course class object the courseEndDate value
        //
        public static DateTime GetCourseEndDate()
        {
            var today = DateTime.Today;
            var endDate = today.AddDays(+90);

            return endDate;
        }

        //The following method assigns to the Course class instance an empty List of students of the instance
        public static List<Student> GetEmptyListStudentsOfCourse()
        {
            List<Student> emptyListStudentsOfCourse = new List<Student>() { };

            return emptyListStudentsOfCourse; 
        }

        //The following method assigns to the Course class instance an empty List of trainers of the instance
        public static List<Trainer> GetEmptyListTrainersOfCourse()
        {
            List<Trainer> emptyListTrainersOfCourse = new List<Trainer>() { };

            return emptyListTrainersOfCourse;
        }


        // END - METHODS OF COURSE CLASS


        //START - COMMON METHODS FOR TRAINER & STUDENT CLASS

        //The following method assigns to different classes' object a string value
        public static string GetName(string stringType)
        {
            Console.WriteLine($"Please enter a valid {stringType}");
            string name = Console.ReadLine();
            bool containsInt = name.Any(char.IsDigit);

            while (containsInt)
            {
                Console.WriteLine($"Invalid input. Please enter a valid {stringType}");
                name = Console.ReadLine();
                containsInt = name.Any(char.IsDigit);
            }

            return name.ToUpper();
        }

        //The following method assigns to different classes' object a string value
        public static string GetText(int numberOfCharacters, string stringType)
        {
            Console.WriteLine($"Please enter a valid {stringType}. Maximum number of characters: {numberOfCharacters}");
            string text = Console.ReadLine();

            while(text.Length > numberOfCharacters)
            {
                Console.WriteLine($"Invalid input. Please enter a valid {stringType}. Maximum number of characters: {numberOfCharacters}");
                text = Console.ReadLine();
            }

            return text.ToUpper();
        }
        //END - COMMON METHODS FOR TRAINER & STUDENT CLASS


        //START - METHODs FOR STUDENT CLASS

        //The following method assigns to student class' object a DateTime value
        public static DateTime GetDateOfBirth()
        {
            Console.WriteLine("Please enter a valid Date of Birth");
            DateTime dateOfBirth;

            var today = DateTime.Today;
            var timespan = new TimeSpan(30);
            dateOfBirth = today.Subtract(timespan);

            return dateOfBirth; 
        }

        //The following method assigns to student class' instance an integer value
        public static int GetTuitionFees()
        {
            Console.WriteLine("Please enter Tuition Fees");
            bool isNumber = int.TryParse(Console.ReadLine(), out int tuitionFees);
            while (!isNumber)
            {
                Console.WriteLine("Invalid input. Please enter valid Tuition Fees");
                isNumber = int.TryParse(Console.ReadLine(), out tuitionFees);
            }

            return tuitionFees;
        }

        //END - METHOD FOR STUDENT CLASS


        //START - METHODS FOR ASSIGNMENT CLASS

        //The following method assigns to assignment class' object a DateTime value
        public static DateTime GetSubmissionDate()
        {
            Console.WriteLine("Please enter a valid submission date");
            DateTime submissionDate;

            var today = DateTime.Today;
            var timespan = new TimeSpan(30);
            submissionDate = today.Subtract(timespan);

            return submissionDate;
        }
        //The following method assigns to assignment class' object an integer value
        public static int GetMark(string typeText)
        {
            Console.WriteLine($"Please enter a valid {typeText} mark. Mark format 0 - 100");
            bool isMark = int.TryParse(Console.ReadLine(), out int mark);

            while (!isMark)
            {
                Console.WriteLine($"Invalid input. Please enter a valid {typeText} mark");
                isMark = int.TryParse(Console.ReadLine(), out mark);
            }

            while (mark > 100 || mark <= 0)
            {
                Console.WriteLine($"Invalid input. Please enter a valid {typeText} mark");
                isMark = int.TryParse(Console.ReadLine(), out mark);
            }

            return mark;
        }

        //END - METHODS FOR ASSIGNMENT CLASS
    }
}
