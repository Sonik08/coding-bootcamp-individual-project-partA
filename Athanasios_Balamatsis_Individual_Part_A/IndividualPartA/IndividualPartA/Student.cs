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
        private string FirstName { get; set; }
        private string LastName { set; get; }
        private DateTime DateOfBirth { set; get; }
        private int TuitionFees { get; set; }

        // Constructors
        public Student()
        {
            FirstName = Helper.GetName("first name");
            LastName = Helper.GetName("last name");
            DateOfBirth = Helper.GetDateOfBirth();
        }


        // Methods
        public void ShowData()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(DateOfBirth);

        }
    }
}
