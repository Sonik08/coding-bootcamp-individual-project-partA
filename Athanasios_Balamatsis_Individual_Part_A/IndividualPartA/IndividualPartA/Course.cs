using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA
{
    // Enumerations        
    public enum CourseStream
    {
        JAVA,
        CSHARP,
        PYTHON,
        JAVASCRIPT

    }
    public enum CourseType
    {
        FT,  //Full-time
        PT   //Part-time

    }
    class Course
    {
        
        // Fields & Properties
        public string CourseTitle { get; set; }
        public CourseStream CourseStream { get; set; }
        public CourseType CourseType { get; set; }
        public DateTime CourseStartDate { get; set; }
        public DateTime CourseEndDate { get; set; }
        public List<Student> StudentsOfCourse { get; set; } = new List<Student>();
        public List<Trainer> TrainersOfCourse { get; set; } = new List<Trainer>();
        public List<Assignment> AssignmentsOfCourse { get; set; } = new List<Assignment>();
        
        // Methods
        public void ShowData()
        {
            Console.WriteLine(CourseTitle);
            Console.WriteLine(CourseStream);
            Console.WriteLine(CourseType);
            Console.WriteLine(CourseStartDate);
            Console.WriteLine(CourseEndDate);
        }

        public void MakeCourse()
        {
            CourseTitle = Helper.GetCourseTitle();
            CourseStream = Helper.GetCourseStream();
            CourseType = Helper.GetCourseType();
            CourseStartDate = Helper.GetCourseStartDate();
            CourseEndDate = Helper.GetCourseEndDate(CourseStartDate, CourseType);
        }







    }
        
}
