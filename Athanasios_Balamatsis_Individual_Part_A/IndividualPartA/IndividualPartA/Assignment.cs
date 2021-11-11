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
        public string AssignmentTitle { get; set; }
        public string AssignmentDescription { get; set; }
        public DateTime AssignmentSubDateTime { get; set; }
        public int AssignmentOralMark { get; set; }
        public int AssignmentTotalMark { get; set; }





        // Methods
        public void MakeAssignment()
        {
            AssignmentTitle = Helper.GetText(25, "assignment title");
            AssignmentDescription = Helper.GetText(140, "assignment description");
            AssignmentSubDateTime = Helper.GetDate("submission", "assignment");

        }
        public void ShowData()
        {
            Console.WriteLine(AssignmentTitle);
            Console.WriteLine(AssignmentDescription);
            Console.WriteLine(AssignmentSubDateTime);
            
        }

        public void SetMarkToAssignment()
        {
            AssignmentOralMark = Helper.GetMark("oral");
            AssignmentTotalMark = Helper.GetMark("total");
        }


        

    }
}
