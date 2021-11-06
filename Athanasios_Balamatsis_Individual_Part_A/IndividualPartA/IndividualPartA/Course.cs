using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA
{
    // Enumerations        
    enum CourseStream
    {
        JAVA,
        CSHARP,
        PYTHON,
        JAVASCRIPT

    }
    enum CourseType
    {
        FT,  //Full-time
        PT   //Part-time

    }
    class Course
    {
        
        // Fields & Properties
        private string CourseTitle { get; set; }
        private CourseStream CourseStream { get; set; }
        //private CourseType CourseType { get; set; }
        //private DateTime CourseStartDate { get; set; }
        //private DateTime CourseEndDate { get; set; }


        // Constructors
        public Course()
        {
            CourseTitle = Helper.GetCourseTitle();
            CourseStream = Helper.GetCourseStream();
            //CourseType = Helper.GetCourseType();
            //CourseStartDate = Helper.GetCourseStartDate();
            //CourseEndDate = Helper.GetCourseEndDate();
        }


        public void ShowData()
        {
            Console.WriteLine(CourseTitle);
            Console.WriteLine(CourseStream);
        }

    }
        
}
