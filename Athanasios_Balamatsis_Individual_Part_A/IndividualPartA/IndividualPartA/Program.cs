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

            // define four variables each one corresponding to one of the four main lists

            //In the following list, every newly created course will be added
            var listAllCourses = new List<Course>();
            //Console.WriteLine(listAllCourses.Count);

            //In the following list, every newly created trainer will be added
            var listAllTrainers = new List<Trainer>();
            //Console.WriteLine(listAllTrainers.Count);

            //In the following list, every newly created student will be added
            var listAllStudents = new List<Student>();
            //Console.WriteLine(listAllStudents.Count);

            //In the following list, every newly created assignment will be added
            var listAllAssignments = new List<Assignment>();
            //Console.WriteLine(listAllAssignments.Count);



            // Define methods that each one creates instance of one of the four main classes.
            // Each newly created instance is added to the corresponding main list where instances of the same class are stored.

            // Define method that creates instance of Course and stores it to the listAllCourses list
            void CreateCourse()
            {
                listAllCourses.Add(new Course());
            }

            // Define method that creates instance of Trainer and stores it to the listAllTrainers list
            void CreateTrainer()
            {
                Trainer tempTrainer = new Trainer();
                listAllTrainers.Add(tempTrainer);

                Console.WriteLine("Please select courses for this trainer");
                bool loopControlVariable = true;

                List<int> listUsedIndexesOfCourses = new List<int>() { };
                while (loopControlVariable)
                {
                    Console.WriteLine($"There are {listAllCourses.Count - listUsedIndexesOfCourses.Count} available courses");
                    if (listAllCourses.Count - listUsedIndexesOfCourses.Count == 0)
                    {
                        Console.WriteLine("Unfortunately there are no more available courses ");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please Select one of the following courses");
                        Console.WriteLine(" ");
                        int courseIndex = 0;
                        foreach (Course course in listAllCourses)
                        {
                            if (listUsedIndexesOfCourses.Contains(courseIndex))
                            {
                                courseIndex++;
                                continue;
                            }
                            Console.WriteLine($"Press {courseIndex} for the course with id {courseIndex}, title '{course.ShowCourseTitle()}', stream '{course.ShowCourseStream()} and type '{course.ShowCourseType()}'");
                            Console.WriteLine("___________________________");
                            courseIndex++;
                        }

                        Console.WriteLine("Please enter the course id of your choice");
                        bool isNumber = int.TryParse(Console.ReadLine(), out int indexSelected);

                        while (!isNumber || indexSelected >= courseIndex)
                        {
                            Console.WriteLine("Invalid input. Please enter the valid course id of your choice");
                            isNumber = int.TryParse(Console.ReadLine(), out indexSelected);
                        }

                        listUsedIndexesOfCourses.Add(indexSelected);
                        Console.WriteLine("You have selected the following course");
                        listAllCourses[indexSelected].ShowData();
                        Console.WriteLine(listAllCourses[indexSelected] is Course);
                        Console.WriteLine(tempTrainer is Trainer);
                        listAllCourses[indexSelected].AddTrainerToCourse(tempTrainer);
                        Console.WriteLine(listAllCourses[indexSelected].ReturnTrainersOfCourseInstance().ReturnListTrainersOfCourse().Count());
                        Console.WriteLine("Successfully subscribed to the course");
                        Console.WriteLine("The length of the list is" + listUsedIndexesOfCourses.Count);
                        Console.WriteLine(listUsedIndexesOfCourses.Contains(0));
                    }
                    Console.WriteLine("Would you like to add another course to this trainer? Enter 'Y' for Yes or 'N' for No");
                    string userResponse = (Console.ReadLine()).ToUpper();
                    while (userResponse != "N" && userResponse != "Y")
                    {
                        Console.WriteLine("Invalid input. Would you like to add another course to this trainer? Enter 'Y' for Yes or 'N' for No");
                        userResponse = (Console.ReadLine()).ToUpper();
                    }
                    loopControlVariable = (userResponse == "N") ? false : true;


                }

             



            }

            // Define method that creates instance of Student and stores it to the listAllStudents list
            // The newly created student selects one of the courses in the listAllCourses list.
            // If the list is empty the student is not assigned a course
            void CreateStudent()
            {
                Student tempStudent = new Student();
                listAllStudents.Add(tempStudent);

                Console.WriteLine($"There are {listAllCourses.Count} available courses");
                if (listAllCourses.Count == 0)
                {
                    Console.WriteLine("Unfortunately there are no available courses ");
                }
                else
                {
                    Console.WriteLine("Please Select one of the following courses");
                    Console.WriteLine(" ");
                    int courseIndex = 0;
                    foreach (Course course in listAllCourses)
                    {
                        Console.WriteLine($"Press {courseIndex} for the course with id {courseIndex}, title '{course.ShowCourseTitle()}', stream '{course.ShowCourseStream()} and type '{course.ShowCourseType()}'");
                        Console.WriteLine("___________________________");
                        courseIndex++;
                    }

                    Console.WriteLine("Please enter the course id of your choice");
                    bool isNumber = int.TryParse(Console.ReadLine(), out int indexSelected);

                    while (!isNumber || indexSelected >= courseIndex)
                    {
                        Console.WriteLine("Invalid input. Please enter the valid course id of your choice");
                        isNumber = int.TryParse(Console.ReadLine(), out indexSelected);
                    }

                    Console.WriteLine("You have selected the following course");
                    listAllCourses[indexSelected].ShowData();
                    Console.WriteLine(listAllCourses[indexSelected] is Course);
                    Console.WriteLine(tempStudent is Student);
                    listAllCourses[indexSelected].AddStudentToCourse(tempStudent);
                    Console.WriteLine(listAllCourses[indexSelected].ReturnStudentsOfCourseInstance().ReturnListStudentsOfCourse().Count());
                    Console.WriteLine("Successfully subscribed to the course");
                }


            }

            // Define method that creates instance of Assignment and stores it to the listAllAssignments list
            void CreateAssignment()
            {
                listAllAssignments.Add(new Assignment());
            }

            CreateCourse();
            CreateCourse();
            CreateTrainer();
            Console.WriteLine("GAMIESAI");



            //Helper.PrintAllCourses(listAllCourses);






            //foreach (Course course in listAllCourses)
            //{
            //    //course.ShowData();
            //    switch (course.ShowStream())
            //    {
            //        case CourseStream.CSHARP:
            //            Console.WriteLine("It's C#");
            //            break;
            //        case CourseStream.JAVA:
            //            Console.WriteLine("It's Java");
            //            break;
            //        case CourseStream.JAVASCRIPT:
            //            Console.WriteLine("It's JavaScript");
            //            break;
            //        default:
            //            Console.WriteLine("It's Python");
            //            break;



            //    }
            //    Console.WriteLine(" ");
            //    Console.WriteLine(" ");
            //}
            //Course firstCourse = new Course();
            //firstCourse.ShowData();

            //DateTime today = DateTime.Today; //2021, 11, 06
            //DateTime check = new DateTime(2020, 12, 30);
            //Console.WriteLine(today > check);

            //Trainer firstTrainer = new Trainer();
            //firstTrainer.ShowData();

            //Student firstStudent = new Student();
            //firstStudent.ShowData();

            //Assignment firstAssignment = new Assignment();
            //firstAssignment.ShowData();
        }
    }
}


