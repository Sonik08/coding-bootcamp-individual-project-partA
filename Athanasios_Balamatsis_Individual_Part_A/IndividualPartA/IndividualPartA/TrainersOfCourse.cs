using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA
{
    class TrainersOfCourse
    {
        //fields & properties
        private static List<Trainer> ListTrainersOfCourse = new List<Trainer>() { };


        //method
        public void AddTrainerToCourse(Trainer trainer)
        {
            ListTrainersOfCourse.Add(trainer);
        }

        public List<Trainer> ReturnListTrainersOfCourse()
        {
            return ListTrainersOfCourse;
        }

    }
}
