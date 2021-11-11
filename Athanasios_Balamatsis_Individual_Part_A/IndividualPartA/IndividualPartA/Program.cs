using System.Globalization;
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
        static void Main(string[] args)
        {
            /* Welcome! 
             * 
             * Database class serves as a static database that doesn't create instances, though it stores the four main lists : all courses, all students, all trainers, all assignments
             * 
             * The procedures take place in Helper class
             * 
             * InputValidation class encompasses methods that check the validity of the user's input. 
             * However validation take also place in some methods of helper class. Modularity is a work in progress.
             * 
             * The rest of the lists can be found as properties in the corresponding classes.
             * 
             * The main structure of the app can be seen in the StartApp() method of Helper class.
             * 
             * Thank you for your time! 
             * 
             */


            Helper.StartApp();
        }
    }
}


