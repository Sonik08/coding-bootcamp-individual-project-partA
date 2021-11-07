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
        private List<Student> ListStudentsOfCourse { get; set; }
        private List<Trainer> ListTrainersOfCourse { get; set; }
        


        // Constructors
        public Course()
        {
            CourseTitle = Helper.GetCourseTitle();
            CourseStream = Helper.GetCourseStream();
            CourseType = Helper.GetCourseType();
            CourseStartDate = Helper.GetCourseStartDate();
            CourseEndDate = Helper.GetCourseEndDate();
            ListStudentsOfCourse = Helper.GetEmptyListStudentsOfCourse();
            ListTrainersOfCourse = Helper.GetEmptyListTrainersOfCourse();



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

        public List<Student> ReturnListStudentsOfCourse()
        {
            return ListStudentsOfCourse;
        }

        public void AddStudentToCourse(Student student)
        {
            ListStudentsOfCourse.Add(student);
        }

        public void AddTrainerToCourse(Trainer trainer)
        {
            ListTrainersOfCourse.Add(trainer);
        }



    }
        
}
