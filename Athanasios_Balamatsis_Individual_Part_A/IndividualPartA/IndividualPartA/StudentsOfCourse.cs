using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA
{
    class StudentsOfCourse
    {

        public static List<Student> ListOfStudentsOfCourse = new List<Student>()
        {
            
        };

        public StudentsOfCourse(Student student)
        {
            ListOfStudentsOfCourse.Add(student);
        }
    }
}
