using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA
{
    class Trainer
    {

        // fields & properties
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Subject { get; set; }


        // Constructors
        public Trainer()
        {
            FirstName = Helper.GetName("first name");
            LastName = Helper.GetName("last name");
            Subject = Helper.GetText(20, "subject");
        }

        public void ShowData()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(Subject);
            
        }
    }
}
