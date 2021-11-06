using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace IndividualPartA
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            var listAllCourses = new List<Course>();
            Console.WriteLine(listAllCourses.Count);

            listAllCourses.Add(new Course());
            listAllCourses.Add(new Course());
            listAllCourses.Add(new Course());

            foreach (Course course in listAllCourses)
            {
                course.ShowData();
            }
            //Course firstCourse = new Course();
            //firstCourse.ShowData();

            //DateTime today = DateTime.Today; //2021, 11, 06
            //DateTime check = new DateTime(2020, 12, 30);
            //Console.WriteLine(today > check);

            //Trainer firstTrainer = new Trainer();
            //firstTrainer.ShowData();

            //Student firstStudent = new Student();
            //firstStudent.ShowData();

            //Assignment firstAssignment = new Assignment();
            //firstAssignment.ShowData();



        }
    }
}
