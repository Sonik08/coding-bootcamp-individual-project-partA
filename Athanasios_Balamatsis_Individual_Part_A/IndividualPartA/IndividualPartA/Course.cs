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
        private string CourseTitle { get; set; }
        private CourseStream CourseStream { get; set; }
        private CourseType CourseType { get; set; }
        private DateTime CourseStartDate { get; set; }
        private DateTime CourseEndDate { get; set; }
        public static List<Student> ListStudentsOfCourse { get; set; }
        public static List<Trainer> ListTrainersOfCourse { get; set; }
        


        // Constructors
        public Course()
        {
            CourseTitle = Helper.GetCourseTitle();
            CourseStream = Helper.GetCourseStream();
            CourseType = Helper.GetCourseType();
            CourseStartDate = Helper.GetCourseStartDate();
            CourseEndDate = Helper.GetCourseEndDate();
            
            
        }

        // Methods
        public void ShowData()
        {
            Console.WriteLine(CourseTitle);
            Console.WriteLine(CourseStream);
            Console.WriteLine(CourseType);
            Console.WriteLine(CourseStartDate);
            Console.WriteLine(CourseEndDate);
        }

        public string ShowCourseTitle()
        {
            return CourseTitle;
        }
        public CourseStream ShowCourseStream()
        {
            return CourseStream;
        }
        public CourseType ShowCourseType()
        {
            return CourseType;
        }

        public static void AddStudentToCourse(Student student)
        {
            ListStudentsOfCourse.Add(student);
        }

        public static void AddTrainerToCourse(Student student)
        {
            ListStudentsOfCourse.Add(student);
        }



    }
        
}
