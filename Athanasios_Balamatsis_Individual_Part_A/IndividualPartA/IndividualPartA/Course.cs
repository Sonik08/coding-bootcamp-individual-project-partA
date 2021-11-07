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
        private StudentsOfCourse StudentsOfCourseInstance { get; set; } = new StudentsOfCourse();
        private TrainersOfCourse TrainersOfCourseInstance { get; set; } = new TrainersOfCourse();
        //private List<Student> ListStudentsOfCourse { get; set; } = new List<Student>() { };
        //private List<Trainer> ListTrainersOfCourse { get; set; } = new List<Trainer>() { };
        


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
        //Methods that show data of instances
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

        //Methods that return instances of classes associated with lists of students and trainers
        public StudentsOfCourse ReturnStudentsOfCourseInstance()
        {
            return StudentsOfCourseInstance;
        }

        public TrainersOfCourse ReturnTrainersOfCourseInstance()
        {
            return TrainersOfCourseInstance;
        }

        //Methods that add either student or trainer to the list of the course which is an instance of either the StudentsOfCourse or TrainersOfCourse class
        public void AddStudentToCourse(Student student)
        {
            StudentsOfCourseInstance.AddStudentToCourse(student);
        }

        public void AddTrainerToCourse(Trainer trainer)
        {
            TrainersOfCourseInstance.AddTrainerToCourse(trainer);
        }



    }
        
}
