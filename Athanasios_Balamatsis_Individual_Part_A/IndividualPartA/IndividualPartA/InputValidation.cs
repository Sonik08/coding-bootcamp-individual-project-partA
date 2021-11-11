using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace IndividualPartA
{
    class InputValidation
    {
        //The following method checks whether a course title is valid.
        //Requirement #1: length == 3 or length == 4
        //Requirement #2: starts with "CB"
        //Requirement #3: an integer follows
        public static bool IsValidCourseTitle(string courseTitle)
        {
            if (!((courseTitle.Length == 3) || (courseTitle.Length ==4)))
            {
                return false;
            }
            
            if (!((courseTitle.Substring(0,2) == "cb") || (courseTitle.Substring(0,2) == "CB")))
            {
                return false;
            }

            string integerPartOfTitle = courseTitle.Substring(2);

            foreach (char character in integerPartOfTitle)
            {
                if (!char.IsDigit(character))
                {
                    return false;
                }
            }

            return true;
        }

        //The following method checks whether a course stream is valid
        //Requirement #1: the course stream input will be valid only if it matches with one of the elements of the validInputsArray array
        public static bool IsValidCourseStream(string courseStream)
        {
            string CourseStreamUpperCase = courseStream.ToUpper();
            string[] validInputsArray = new string[4] { "JAVA", "CSHARP", "PYTHON", "JAVASCRIPT" };

            return Array.Exists(validInputsArray, element => element == CourseStreamUpperCase);
        }

        //The following method checks whether a course type is valid
        //Requirement #1: the course type input will be valid only if it matches with one of the elements of the validInputsArray array
        public static bool IsValidCourseType(string courseType)
        {
            string CourseTypeUpperCase = courseType.ToUpper();
            string[] validInputsArray = new string[2] { "FT", "PT" };

            return Array.Exists(validInputsArray, element => element == CourseTypeUpperCase);
        }


       
    }
}
