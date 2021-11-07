using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA
{
    class StudentsOfCourse
    {
        // fields & properties
        private static List<Student> ListStudentsOfCourse = new List<Student>() { };


        // methods
        public void AddStudentToCourse(Student student)
        {
            ListStudentsOfCourse.Add(student);
        }

        public List<Student> ReturnListStudentsOfCourse()
        {
            return ListStudentsOfCourse;
        }
        
        

        
    }
}
