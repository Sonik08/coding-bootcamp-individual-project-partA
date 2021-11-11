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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }


        // Constructors
        public void MakeTrainer()
        {
            FirstName = Helper.GetName("first name");
            LastName = Helper.GetName("last name");
            Subject = Helper.GetText(20, "subject");
        }
       
    }
}
