using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA
{
    class Helper
    {
        
        //Method that initialises the console app
        public static void StartApp()
        {
            bool controlLoopVariable = true;
            while (controlLoopVariable)
            {
                bool createQuestion = AskYesOrNo("Would you like to submit data? Please press 'Y' for yes or 'N' for no.");
                if (createQuestion)
                {
                    CreateData();
                }

                bool showQuestion = AskYesOrNo("Would you like to show stored data? Please press 'Y' for yes or 'N' for no.");
                if (showQuestion)
                {
                    ShowData();   
                }

                controlLoopVariable = AskYesOrNo("Would you like to go back to Home page? Please press 'Y' for yes or 'N' for no.");
            }
        }



        

        //Method that creates data
        public static void CreateData()
        {
            Console.WriteLine("Please submit data to all the entities");
            bool createCourseQuestion = AskYesOrNo("Would you like to create a student? Please press 'Y' for yes or 'N' for no.");
            if (createCourseQuestion)
            {
                CreateStudent();
            }

            bool createAssignmentQuestion = AskYesOrNo("Would you like to create an assignment? Please press 'Y' for yes or 'N' for no.");
            if (createAssignmentQuestion)
            {
                CreateAssignment();
            }

            bool createTrainerQuestion = AskYesOrNo("Would you like to create a trainer? Please press 'Y' for yes or 'N' for no.");
            if (createTrainerQuestion)
            {
                CreateTrainer();
            }

            bool createStudentQuestion = AskYesOrNo("Would you like to create a course? Please press 'Y' for yes or 'N' for no.");
            if (createStudentQuestion)
            {
                CreateCourse();
            }
        }

        //Method that shows stored data
        public static void ShowData()
        {
            bool showQuestion = AskYesOrNo("Would you like to show all courses? Please press 'Y' for yes or 'N' for no.");
            if (showQuestion)
            {
                ShowAllCourses();
            }

            showQuestion = AskYesOrNo("Would you like to show all students? Please press 'Y' for yes or 'N' for no.");
            if (showQuestion)
            {
                ShowAllStudents();
            }

            showQuestion = AskYesOrNo("Would you like to show all trainers? Please press 'Y' for yes or 'N' for no.");
            if (showQuestion)
            {
                ShowAllTrainers();
            }

            showQuestion = AskYesOrNo("Would you like to show all assignments? Please press 'Y' for yes or 'N' for no.");
            if (showQuestion)
            {
                ShowAllAssignments();
            }

            showQuestion = AskYesOrNo("Would you like to show all students per course? Please press 'Y' for yes or 'N' for no.");
            if (showQuestion)
            {
                ShowAllStudentsOfCourse();
            }

            showQuestion = AskYesOrNo("Would you like to show all trainers per course? Please press 'Y' for yes or 'N' for no.");
            if (showQuestion)
            {
                ShowAllTrainersOfCourse();
            }

            showQuestion = AskYesOrNo("Would you like to show all assignments per course? Please press 'Y' for yes or 'N' for no.");
            if (showQuestion)
            {
                ShowAllAssignmentsOfCourse();
            }

            showQuestion = AskYesOrNo("Would you like to show all assignments per student? Please press 'Y' for yes or 'N' for no.");
            if (showQuestion)
            {
                ShowAllAssignmentsOfStudent();
            }

            showQuestion = AskYesOrNo("Would you like to show all students with more than one courses? Please press 'Y' for yes or 'N' for no.");
            if (showQuestion)
            {
                ShowAllStudentWithMoreCourses();
            }

            showQuestion = AskYesOrNo("Would you like to show all students that have to submit an assignment on a given date? Please press 'Y' for yes or 'N' for no.");
            if (showQuestion)
            {
                DateTime dateToCheck = GetDate();
                StudentsToSubmitInThisWeek(dateToCheck);
            }
        }


        
        //Method that creates course and selects assignments for the course
        public static void CreateCourse()
        {
            bool loopControlVariable = true;

            while (loopControlVariable)
            {
                Course tempCourse = new Course();
                tempCourse.MakeCourse();
                Database.listAllCourses.Add(tempCourse);

                Console.WriteLine("Please select assignments for this course");
                bool loopControlVariable2 = true;

                List<int> listUsedIndexesOfAssignments = new List<int>() { };
                while (loopControlVariable2)
                {
                    Console.WriteLine($"There are {Database.listAllAssignments.Count - listUsedIndexesOfAssignments.Count} available Assignments");
                    if (Database.listAllAssignments.Count - listUsedIndexesOfAssignments.Count == 0)
                    {
                        Console.WriteLine("Unfortunately there are no more available assignments ");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please Select one of the following assignments");
                        Console.WriteLine(" ");
                        int assignmentIndex = 0;
                        foreach (Assignment assignment in Database.listAllAssignments)
                        {
                            if (listUsedIndexesOfAssignments.Contains(assignmentIndex))
                            {
                                assignmentIndex++;
                                continue;
                            }
                            Console.WriteLine($"Press {assignmentIndex} for the assignment with id {assignmentIndex}, title '{assignment.AssignmentTitle}' and submission date '{assignment.AssignmentSubDateTime}");
                            Console.WriteLine("___________________________");
                            assignmentIndex++;
                        }

                        Console.WriteLine("Please enter the assignment id of your choice");
                        bool isNumber = int.TryParse(Console.ReadLine(), out int indexSelected);

                        while (!isNumber || indexSelected >= assignmentIndex)
                        {
                            Console.WriteLine("Invalid input. Please enter the valid assignment id of your choice");
                            isNumber = int.TryParse(Console.ReadLine(), out indexSelected);
                        }

                        listUsedIndexesOfAssignments.Add(indexSelected);
                        Console.WriteLine("You have selected the following assignment");
                        Console.WriteLine(Database.listAllAssignments[indexSelected].AssignmentTitle);
                        tempCourse.AssignmentsOfCourse.Add(Database.listAllAssignments[indexSelected]);
                        Console.WriteLine("Successfully subscribed the assignment to the course");
                        loopControlVariable2 = AskYesOrNo("Would you like to add another assignment to this course? Enter 'Y' for yes and 'N' for no.");
                    }
                }
                loopControlVariable = AskYesOrNo("Would you like to create another course? Enter 'Y' for yes and 'N' for no.");
            }
        }

        //Method that creates trainer and selects courses for the trainer
        public static void CreateTrainer()
        {
            bool loopControlVariable = true;

            while (loopControlVariable)
            {
                Trainer tempTrainer = new Trainer();
                tempTrainer.MakeTrainer();
                Database.listAllTrainers.Add(tempTrainer);

                Console.WriteLine("Please select courses for this trainer");
                bool loopControlVariable2 = true;

                List<int> listUsedIndexesOfCourses = new List<int>() { };
                while (loopControlVariable2)
                {
                    Console.WriteLine($"There are {Database.listAllCourses.Count - listUsedIndexesOfCourses.Count} available courses");
                    if (Database.listAllCourses.Count - listUsedIndexesOfCourses.Count == 0)
                    {
                        Console.WriteLine("Unfortunately there are no more available courses ");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please Select one of the following courses");
                        Console.WriteLine(" ");
                        int courseIndex = 0;
                        foreach (Course course in Database.listAllCourses)
                        {
                            if (listUsedIndexesOfCourses.Contains(courseIndex))
                            {
                                courseIndex++;
                                continue;
                            }
                            Console.WriteLine($"Press {courseIndex} for the course with id {courseIndex}, title '{course.CourseTitle}', stream '{course.CourseStream} and type '{course.CourseType}'");
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
                        Console.WriteLine(Database.listAllCourses[indexSelected].CourseTitle);
                        Database.listAllCourses[indexSelected].TrainersOfCourse.Add(tempTrainer);
                        Console.WriteLine("Successfully subscribed to the course");
                        loopControlVariable2 = AskYesOrNo("Would you like to add another course to this trainer? Enter 'Y' for yes and 'N' for no.");
                    }
                }
                loopControlVariable = AskYesOrNo("Would you like to create another trainer? Enter 'Y' for yes and 'N' for no.");
            }
        }

        //Method that creates assignment and adds it to courses
        public static void CreateAssignment()
        {
            bool loopControlVariable = true;

            while (loopControlVariable)
            {
                Assignment tempAssignment = new Assignment();
                tempAssignment.MakeAssignment();
                Database.listAllAssignments.Add(tempAssignment);

                Console.WriteLine("Please select courses for the assignment");
                bool loopControlVariable2 = true;

                List<int> listUsedIndexesOfCourses = new List<int>() { };
                while (loopControlVariable2)
                {
                    Console.WriteLine($"There are {Database.listAllCourses.Count - listUsedIndexesOfCourses.Count} available courses");
                    if (Database.listAllCourses.Count - listUsedIndexesOfCourses.Count == 0)
                    {
                        Console.WriteLine("Unfortunately there are no more available courses ");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please Select one of the following courses");
                        Console.WriteLine(" ");
                        int courseIndex = 0;
                        foreach (Course course in Database.listAllCourses)
                        {
                            if (listUsedIndexesOfCourses.Contains(courseIndex))
                            {
                                courseIndex++;
                                continue;
                            }
                            Console.WriteLine($"Press {courseIndex} for the course with id {courseIndex}, title '{course.CourseTitle}', stream '{course.CourseStream} and type '{course.CourseType}'");
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
                        Console.WriteLine(Database.listAllCourses[indexSelected].CourseTitle);
                        Database.listAllCourses[indexSelected].AssignmentsOfCourse.Add(tempAssignment);
                        Console.WriteLine("Successfully subscribed to the course");
                        loopControlVariable2 = AskYesOrNo("Would you like to add this assignment to another course? Enter 'Y' for yes and 'N' for no.");
                    }
                }
                loopControlVariable = AskYesOrNo("Would you like to create another assignment? Enter 'Y' for yes and 'N' for no.");
            }
        }

        //Method that creates student and adds it to courses
        public static void CreateStudent()
        {
            bool loopControlVariable = true;

            while (loopControlVariable)
            {
                Student tempStudent = new Student();
                tempStudent.MakeStudent();
                Database.listAllStudents.Add(tempStudent);

                Console.WriteLine("Please select courses for this student");
                bool loopControlVariable2 = true;

                List<int> listUsedIndexesOfCourses = new List<int>() { };
                while (loopControlVariable2)
                {
                    Console.WriteLine($"There are {Database.listAllCourses.Count - listUsedIndexesOfCourses.Count} available courses");
                    if (Database.listAllCourses.Count - listUsedIndexesOfCourses.Count == 0)
                    {
                        Console.WriteLine("Unfortunately there are no more available courses ");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please Select one of the following courses");
                        Console.WriteLine(" ");
                        int courseIndex = 0;
                        foreach (Course course in Database.listAllCourses)
                        {
                            if (listUsedIndexesOfCourses.Contains(courseIndex))
                            {
                                courseIndex++;
                                continue;
                            }
                            Console.WriteLine($"Press {courseIndex} for the course with id {courseIndex}, title '{course.CourseTitle}', stream '{course.CourseStream} and type '{course.CourseType}'");
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
                        Console.WriteLine(Database.listAllCourses[indexSelected].CourseTitle);
                        Database.listAllCourses[indexSelected].StudentsOfCourse.Add(tempStudent);
                        tempStudent.CoursesOfStudent.Add(Database.listAllCourses[indexSelected]);
                        Console.WriteLine("Successfully subscribed to the course");
                        loopControlVariable2 = AskYesOrNo("Would you like to add another course to this student? Enter 'Y' for yes and 'N' for no.");
                    }
                }
                loopControlVariable = AskYesOrNo("Would you like to create another student? Enter 'Y' for yes and 'N' for no.");
            }
        }


       
        
        
        
        //Method that shows all the courses in the list listAllCourses of Database class
        public static void ShowAllCourses()
        {
            Console.WriteLine("The list of all the courses");
            Console.WriteLine("___________________________________");
            foreach (Course course in Database.listAllCourses)
            {
                Console.WriteLine(course.CourseTitle);
                Console.WriteLine(course.CourseStream);
                Console.WriteLine(course.CourseType);
                Console.WriteLine(course.CourseStartDate);
                Console.WriteLine(course.CourseEndDate);
                
                Console.WriteLine("___________________________________");
                Console.WriteLine(" ");
            }
        }


        //Method that shows all the students in the list listAllCourses of Database class
        public static void ShowAllStudents()
        {
            Console.WriteLine("The list of all the students");
            Console.WriteLine("___________________________________");
            foreach (Student student in Database.listAllStudents)
            {
                Console.WriteLine(student.FirstName);
                Console.WriteLine(student.LastName);
                Console.WriteLine(student.DateOfBirth);
                Console.WriteLine(student.TuitionFees);
                Console.WriteLine("___________________________________");
                Console.WriteLine(" ");
            }
        }


        //Method that shows all the trainers in the list listAllTrainers of Database class
        public static void ShowAllTrainers()
        {
            Console.WriteLine("The list of all the trainers");
            Console.WriteLine("___________________________________");
            foreach (Trainer trainer in Database.listAllTrainers)
            {
                Console.WriteLine(trainer.FirstName);
                Console.WriteLine(trainer.LastName);
                Console.WriteLine(trainer.Subject);
                Console.WriteLine("___________________________________");
                Console.WriteLine(" ");
            }
        }


        //Method that shows all the assignments in the list listAllAssignments of Database class
        public static void ShowAllAssignments()
        {
            Console.WriteLine("The list of all the assignments");
            Console.WriteLine("___________________________________");
            foreach (Assignment assignment in Database.listAllAssignments)
            {
                Console.WriteLine(assignment.AssignmentTitle);
                Console.WriteLine(assignment.AssignmentDescription);
                Console.WriteLine(assignment.AssignmentSubDateTime);                
                Console.WriteLine("___________________________________");
                Console.WriteLine(" ");
            }
        }

        
       
        
        
        //Method that shows all the students per course
        public static void ShowAllStudentsOfCourse()
        {
            Console.WriteLine("___________________________________");
            Console.WriteLine(" ");

            foreach (Course course in Database.listAllCourses)
            {
                Console.WriteLine($"The list of all the students of the course {course.CourseTitle} {course.CourseStream} {course.CourseType}");
                Console.WriteLine("___________________________________");
                foreach (Student student in course.StudentsOfCourse)
                {
                    Console.WriteLine(student.FirstName);
                    Console.WriteLine(student.LastName);
                    Console.WriteLine(student.DateOfBirth);
                    Console.WriteLine(student.TuitionFees);
                    Console.WriteLine("___________________________________");
                    Console.WriteLine(" ");
                    
                }
            }

        }


        //Method that shows all the trainers per course
        public static void ShowAllTrainersOfCourse()
        {
            Console.WriteLine("___________________________________");
            Console.WriteLine(" ");
            foreach (Course course in Database.listAllCourses) 
            {
                Console.WriteLine($"The list of all the trainers of the course {course.CourseTitle} {course.CourseStream} {course.CourseType}");
                Console.WriteLine("___________________________________");
                foreach (Trainer trainer in course.TrainersOfCourse)
                {
                    Console.WriteLine(trainer.FirstName);
                    Console.WriteLine(trainer.LastName);
                    Console.WriteLine(trainer.Subject);
                    Console.WriteLine("___________________________________");
                    Console.WriteLine(" ");
                   
                }

            }

        }


        //Method that shows all the assignments per course
        public static void ShowAllAssignmentsOfCourse()
        {
            Console.WriteLine("___________________________________");
            Console.WriteLine(" ");
            foreach (Course course in Database.listAllCourses)
            {
                Console.WriteLine($"The list of all the assignments of the course {course.CourseTitle} {course.CourseStream} {course.CourseType}");
                Console.WriteLine(" ");
                foreach (Assignment assignment in course.AssignmentsOfCourse)
                {
                    Console.WriteLine(assignment.AssignmentTitle);
                    Console.WriteLine(assignment.AssignmentDescription);
                    Console.WriteLine(assignment.AssignmentSubDateTime);
                    Console.WriteLine("___________________________________");
                    Console.WriteLine(" ");
 
                }
            }
        }


        //Method that shows all the assignments per student
        public static void ShowAllAssignmentsOfStudent()
        {
            Console.WriteLine("___________________________________");
            Console.WriteLine(" ");
            foreach (Student student in Database.listAllStudents)
            {
                Console.WriteLine($"The list of all the assignments of {student.FirstName} {student.LastName}");
                Console.WriteLine(" ");
                foreach (Assignment assignment in student.AssignmentsOfStudent)
                {
                    Console.WriteLine(assignment.AssignmentTitle);
                    Console.WriteLine(assignment.AssignmentDescription);
                    Console.WriteLine(assignment.AssignmentSubDateTime);
                    Console.WriteLine(assignment.AssignmentOralMark);
                    Console.WriteLine(assignment.AssignmentTotalMark);
                    Console.WriteLine("___________________________________");
                    Console.WriteLine(" ");
                    
                }
            }
        }


        //Method that shows all the students with more than one courses
        public static void ShowAllStudentWithMoreCourses()
        {
            int studentCounter = 0;
            Console.WriteLine("The list of all the students with more than one courses");
            Console.WriteLine("___________________________________");
            foreach (Student student in Database.listAllStudents)
            {
                if (student.CoursesOfStudent.Count > 1)
                {
                    Console.WriteLine(student.FirstName);
                    Console.WriteLine(student.LastName);
                    Console.WriteLine(student.DateOfBirth);
                    Console.WriteLine(student.TuitionFees);
                    Console.WriteLine("___________________________________");
                    studentCounter++;
                }
            }
            if (studentCounter == 0)
            {
                Console.WriteLine("There are no students with more than one courses");
                Console.WriteLine("___________________________________");
            }


        }

        //Method that checks how many students should submit an assignment on a given date
        public static void StudentsToSubmitInThisWeek(DateTime dateToCheck)
        {
            DayOfWeek dayToCheck = dateToCheck.DayOfWeek;
            int spanFromMonday = dayToCheck - DayOfWeek.Monday;
            DateTime mondayDate = dateToCheck.AddDays(-spanFromMonday);
            DateTime sundayDate = mondayDate.AddDays(6);
            int studentsCounter = 0;
            foreach (Student student in Database.listAllStudents)
            {
                foreach (Assignment assignment in student.AssignmentsOfStudent)
                {

                    if ((assignment.AssignmentSubDateTime >= mondayDate) && (assignment.AssignmentSubDateTime <= sundayDate))
                    {
                        Console.WriteLine($"This student has to submit an assignment in this week: {student.FirstName} {student.LastName}");
                        studentsCounter++;
                        break;
                    }
                }
            }
            if (studentsCounter == 0)
            {
                Console.WriteLine("No student has to submit an assignment in this week");
            }
            
        }




        //Method that checks whether a date submitted by the user is valid - Overloaded
        public static DateTime GetDate(string submissionOrStarting, string forWhat)
        {
            DateTime today = DateTime.Today;
            Console.WriteLine($"Enter a valid {submissionOrStarting} date for {forWhat}. Valid format is dd/mm/yyyy");
            string startDate = Console.ReadLine();
            CultureInfo culture = new CultureInfo("el-EL");

            while (!DateTime.TryParse(startDate, out _))
            {
                Console.WriteLine($"Invalid input. Enter a valid {submissionOrStarting} date for {forWhat}. Valid format is dd/mm/yyyy");
                startDate = Console.ReadLine();
            }
            DateTime result = DateTime.Parse(startDate, culture);

            return result;
        }

        //Method with same function as the aforementioned GetDate
        public static DateTime GetDate()
        {
            
            Console.WriteLine("Enter a valid date. Valid format is dd/mm/yyyy");
            string theDate = Console.ReadLine();
            CultureInfo culture = new CultureInfo("el-EL");

            while (!DateTime.TryParse(theDate, out _))
            {
                Console.WriteLine("Invalid input. Enter a valid date. Valid format is dd/mm/yyyy");
                theDate = Console.ReadLine();
            }
            DateTime result = DateTime.Parse(theDate, culture);

            return result;
        }

        //Method with same function as the aforementioned GetDate
        public static DateTime GetBirthDate()
        {
            Console.WriteLine("Enter a valid birth date. Valid format is dd/mm/yyyy");
            string birthDate = Console.ReadLine();
            CultureInfo culture = new CultureInfo("el-EL");

            while (!DateTime.TryParse(birthDate, out _))
            {
                Console.WriteLine($"Invalid input. Enter a valid birth date. Valid format is dd/mm/yyyy");
                birthDate = Console.ReadLine();    
            }
            DateTime result = DateTime.Parse(birthDate, culture);

            return result;
        }

       



        //Method that makes a question and expects a yes or no input from user
        public static bool AskYesOrNo(string question)
        {
            bool loopControlVariable = true;
            Console.WriteLine($"{question}");
            string userResponse = (Console.ReadLine()).ToUpper();
            while (userResponse != "N" && userResponse != "Y")
            {
                Console.WriteLine($"Invalid input. {question}");
                userResponse = (Console.ReadLine()).ToUpper();
            }
            loopControlVariable = (userResponse == "N") ? false : true;

            return loopControlVariable;
        }


        

        //The following method assigns to the Course class object the courseTitle value
        //While loop until user's input is valid. Validation within loop by calling IsValidCourseTitle()
        //courseTitle converted to Uppercase before returned
        public static string GetCourseTitle()
        {
            Console.WriteLine("Please enter a valid Course Title. Valid Titles start with 'CB' and are accompanied by a number e.g 'CB9'");
            string courseTitle = Console.ReadLine();

            while (!(InputValidation.IsValidCourseTitle(courseTitle)))
            {
                Console.WriteLine("Invalid input. Please enter a valid Course Title. Valid Titles start with 'CB' and are accompanied by a number e.g 'CB9'");
                courseTitle = Console.ReadLine();
            }
            
            courseTitle = courseTitle.ToUpper();
            

            return courseTitle;
        }

        //The following method assigns to the Course class object the courseStream value
        //While loop until user's input is valid. Validation within loop by calling IsValidCourseStream()
        public static CourseStream GetCourseStream()
        {
            Console.WriteLine("Please enter a valid Course Stream. Valid inputs: Java, CSharp, Python, JavaScript");
            string courseStream = Console.ReadLine();

            while (!(InputValidation.IsValidCourseStream(courseStream)))
            {
                Console.WriteLine("Invalid input. Please enter a valid Course Stream. Valid inputs: Java, CSharp, Python, JavaScript");
                courseStream = Console.ReadLine();
            }
            

            return (CourseStream)Enum.Parse(typeof (CourseStream), courseStream.ToUpper());
        }

        //The following method assigns to the Course class object the courseType value
        //While loop until user's input is valid. Validation within loop by calling IsValidCourseType()
        public static CourseType GetCourseType()
        {
            Console.WriteLine("Please enter a valid Course Type. Valid inputs: FT , PT . FT stands for Full-Time, PT stands for Part-Time");
            string courseType = Console.ReadLine();

            while (!(InputValidation.IsValidCourseType(courseType)))
            {
                Console.WriteLine("Invalid input. Please enter a valid Course Type. Valid inputs: FT , PT . FT stands for Full-Time, PT stands for Part-Time");
                courseType = Console.ReadLine();
            }


            return (CourseType)Enum.Parse(typeof(CourseType), courseType.ToUpper());
        }

        //The following method assigns to the Course class object the courseStartDate value
        //
        public static DateTime GetCourseStartDate()
        {
            DateTime startDate = Helper.GetDate("start", "course");
            return startDate;
        }

        //The following method assigns to the Course class object the courseEndDate value
        //
        public static DateTime GetCourseEndDate(DateTime startDate, CourseType courseType)
        {
            DateTime endDate = startDate.AddMonths(3);
            
            if (courseType == CourseType.PT)
            {
                endDate = startDate.AddMonths(6);
                return endDate;
            }

            return endDate;
        }

        


        

        //The following method assigns to different classes' object a string value
        public static string GetName(string stringType)
        {
            Console.WriteLine($"Please enter a valid {stringType}");
            string name = Console.ReadLine();
            bool containsInt = name.Any(char.IsDigit);

            while (containsInt)
            {
                Console.WriteLine($"Invalid input. Please enter a valid {stringType}");
                name = Console.ReadLine();
                containsInt = name.Any(char.IsDigit);
            }

            return name.ToUpper();
        }

        //The following method assigns to different classes' object a string value
        public static string GetText(int numberOfCharacters, string stringType)
        {
            Console.WriteLine($"Please enter a valid {stringType}. Maximum number of characters: {numberOfCharacters}");
            string text = Console.ReadLine();

            while(text.Length > numberOfCharacters)
            {
                Console.WriteLine($"Invalid input. Please enter a valid {stringType}. Maximum number of characters: {numberOfCharacters}");
                text = Console.ReadLine();
            }

            return text.ToUpper();
        }
        //END - COMMON METHODS FOR TRAINER & STUDENT CLASS

        //The following method assigns to student class' instance an integer value
        public static int GetTuitionFees()
        {
            Console.WriteLine("Please enter Tuition Fees");
            bool isNumber = int.TryParse(Console.ReadLine(), out int tuitionFees);
            while (!isNumber)
            {
                Console.WriteLine("Invalid input. Please enter valid Tuition Fees");
                isNumber = int.TryParse(Console.ReadLine(), out tuitionFees);
            }

            return tuitionFees;
        }

        //The following method assigns to assignment class' object an integer value
        public static int GetMark(string typeText)
        {
            Console.WriteLine($"Please enter a valid {typeText} mark. Mark format 0 - 100");
            bool isMark = int.TryParse(Console.ReadLine(), out int mark);

            while (!isMark)
            {
                Console.WriteLine($"Invalid input. Please enter a valid {typeText} mark");
                isMark = int.TryParse(Console.ReadLine(), out mark);
            }

            while (mark > 100 || mark <= 0)
            {
                Console.WriteLine($"Invalid input. Please enter a valid {typeText} mark");
                isMark = int.TryParse(Console.ReadLine(), out mark);
            }

            return mark;
        }

       
    }
}
