using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA
{
    class Assignment
    {
        // fields & properties
        private string AssignmentTitle { get; set; }
        private string AssignmentDescription { get; set; }
        private DateTime AssignmentSubDateTime { get; set; }
        private int AssignmentOralMark { get; set; }
        private int AssignmentTotalMark { get; set; }

        // Constructors
        public Assignment()
        {
            AssignmentTitle = Helper.GetText(25, "assignment title");
            AssignmentDescription = Helper.GetText(140, "assignment description");
            AssignmentSubDateTime = Helper.GetSubmissionDate();
            AssignmentOralMark = Helper.GetMark("oral");
            AssignmentTotalMark = Helper.GetMark("total");
        }


        // Methods
        public void ShowData()
        {
            Console.WriteLine(AssignmentTitle);
            Console.WriteLine(AssignmentDescription);
            Console.WriteLine(AssignmentSubDateTime);
            Console.WriteLine(AssignmentOralMark);
            Console.WriteLine(AssignmentTotalMark);
        }


    }
}
