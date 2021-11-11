using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA
{
    class Student
    {
        // fields & properties
        public string FirstName { get; set; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public int TuitionFees { get; set; }
        public List<Assignment> AssignmentsOfStudent = new List<Assignment>() { };
        public List<Course> CoursesOfStudent = new List<Course>() { };

        // Methods
        public void MakeStudent()
        {
            FirstName = Helper.GetName("first name");
            LastName = Helper.GetName("last name");
            DateOfBirth = Helper.GetBirthDate();
            TuitionFees = Helper.GetTuitionFees();
        }
    }
}
