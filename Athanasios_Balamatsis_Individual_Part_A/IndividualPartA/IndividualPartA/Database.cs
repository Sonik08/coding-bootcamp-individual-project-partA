using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA
{
    static class Database
    {
        //This class serves as a database that stores the four main required lists 
        public static List<Course> listAllCourses = new List<Course>()
        {
                new Course()
                {
                    CourseTitle = "CB1",
                    CourseStream = CourseStream.JAVA,
                    CourseType = CourseType.FT,
                    CourseStartDate = DateTime.Today.AddMonths(1),
                    CourseEndDate = DateTime.Today.AddMonths(4),
                    StudentsOfCourse = new List<Student>()
                    {
                        new Student()
                        {
                            FirstName = "GIANNAKIS",
                            LastName = "OKKAS",
                            DateOfBirth = new DateTime(1990, 5, 12),
                            TuitionFees = 2000,
                            AssignmentsOfStudent = new List<Assignment>()
                            {
                                new Assignment ()
                                {
                                    AssignmentTitle = "DATA STRUCTURES",
                                    AssignmentDescription = "THIS IS ASSIGNMENT'S DESCRIPTION",
                                    AssignmentSubDateTime = DateTime.Today.AddMonths(2)
                                }
                            },
                            CoursesOfStudent = new List<Course>()
                            {
                                new Course()
                                {
                                    CourseTitle = "CB1",
                                    CourseStream = CourseStream.JAVA,
                                    CourseType = CourseType.FT,
                                    CourseStartDate = DateTime.Today.AddMonths(1),
                                    CourseEndDate = DateTime.Today.AddMonths(4),
                                    StudentsOfCourse = new List<Student>(),
                                    TrainersOfCourse = new List<Trainer>(),
                                    AssignmentsOfCourse = new List<Assignment>()
                                }
                            }
                        }
                    },
                    TrainersOfCourse = new List<Trainer>()
                    {
                        new Trainer()
                        {
                            FirstName = "ALAN",
                            LastName = "TURING",
                            Subject = "THIS IS TURING'S SUBJECT"
                        }
                    },
                    AssignmentsOfCourse = new List<Assignment>()
                    {
                        new Assignment ()
                        {
                            AssignmentTitle = "DATA STRUCTURES",
                            AssignmentDescription = "THIS IS ASSIGNMENT'S DESCRIPTION",
                            AssignmentSubDateTime = DateTime.Today.AddMonths(2)
                        }
                    }

                },
                new Course()
                {
                    CourseTitle = "CB1",
                    CourseStream = CourseStream.PYTHON,
                    CourseType = CourseType.FT,
                    CourseStartDate = DateTime.Today.AddMonths(1),
                    CourseEndDate = DateTime.Today.AddMonths(4),
                    StudentsOfCourse = new List<Student>()
                    {
                        new Student()
                        {
                            FirstName = "GRIGORIS",
                            LastName = "GEORGATOS",
                            DateOfBirth = new DateTime(1985, 4, 1),
                            TuitionFees = 2000,
                            AssignmentsOfStudent = new List<Assignment>()
                            {
                                new Assignment ()
                                {
                                    AssignmentTitle = "ALGORITHMS",
                                    AssignmentDescription = "THIS IS ASSIGNMENT'S DESCRIPTION",
                                    AssignmentSubDateTime = DateTime.Today.AddMonths(2)
                                }
                            },
                            CoursesOfStudent = new List<Course>()
                            {
                                new Course()
                                {
                                    CourseTitle = "CB1",
                                    CourseStream = CourseStream.PYTHON,
                                    CourseType = CourseType.FT,
                                    CourseStartDate = DateTime.Today.AddMonths(1),
                                    CourseEndDate = DateTime.Today.AddMonths(4),
                                    StudentsOfCourse = new List<Student>(),
                                    TrainersOfCourse = new List<Trainer>(),
                                    AssignmentsOfCourse = new List<Assignment>()
                                }

                            }
                        }
                    },
                    TrainersOfCourse = new List<Trainer>()
                    {
                        new Trainer()
                        {
                            FirstName = "ADA",
                            LastName = "LOVELACE",
                            Subject = "THIS IS LOVELACE'S SUBJECT"
                        }
                    },
                    AssignmentsOfCourse = new List<Assignment>()
                    {
                        new Assignment ()
                        {
                            AssignmentTitle = "ALGORITHMS",
                            AssignmentDescription = "THIS IS ASSIGNMENT'S DESCRIPTION",
                            AssignmentSubDateTime = DateTime.Today.AddMonths(2)
                        }
                    }

                },
                new Course()
                {
                    CourseTitle = "CB1",
                    CourseStream = CourseStream.JAVASCRIPT,
                    CourseType = CourseType.FT,
                    CourseStartDate = DateTime.Today.AddMonths(1),
                    CourseEndDate = DateTime.Today.AddMonths(4),
                    StudentsOfCourse = new List<Student>()
                    {
                        new Student()
                        {
                            FirstName = "FELIX",
                            LastName = "BORJA",
                            DateOfBirth = new DateTime(1983, 2, 21),
                            TuitionFees = 2000,
                            AssignmentsOfStudent = new List<Assignment>()
                            {
                                new Assignment ()
                                {
                                    AssignmentTitle = "WEB DEVELOPMENT",
                                    AssignmentDescription = "THIS IS ASSIGNMENT'S DESCRIPTION",
                                    AssignmentSubDateTime = DateTime.Today.AddMonths(2)
                                }
                            },
                            CoursesOfStudent = new List<Course>()
                            {
                                new Course()
                                {
                                    CourseTitle = "CB1",
                                    CourseStream = CourseStream.JAVASCRIPT,
                                    CourseType = CourseType.FT,
                                    CourseStartDate = DateTime.Today.AddMonths(1),
                                    CourseEndDate = DateTime.Today.AddMonths(4),
                                    StudentsOfCourse = new List<Student>(),
                                    TrainersOfCourse = new List<Trainer>(),
                                    AssignmentsOfCourse = new List<Assignment>()
                                }

                            }
                        }
                    },
                    TrainersOfCourse = new List<Trainer>()
                    {
                        new Trainer()
                        {
                            FirstName = "JOHN",
                            LastName = "VON NEUMANN",
                            Subject = "THIS IS VON NEUMANN'S SUBJECT"
                        }
                    },
                    AssignmentsOfCourse = new List<Assignment>()
                    {
                        new Assignment ()
                        {
                            AssignmentTitle = "WEB DEVELOPMENT",
                            AssignmentDescription = "THIS IS ASSIGNMENT'S DESCRIPTION",
                            AssignmentSubDateTime = DateTime.Today.AddMonths(2)
                        }
                    }
                }
        };

        public static List<Trainer> listAllTrainers = new List<Trainer>()
        {
                new Trainer()
                {
                    FirstName = "ALAN",
                    LastName = "TURING",
                    Subject = "THIS IS TURING'S SUBJECT"
                },

                new Trainer()
                {
                    FirstName = "ADA",
                    LastName = "LOVELACE",
                    Subject = "THIS IS LOVELACE'S SUBJECT"
                },

                new Trainer()
                {
                    FirstName = "JOHN",
                    LastName = "VON NEUMANN",
                    Subject = "THIS IS VON NEUMANN'S SUBJECT"
                }
        };

        public static List<Student> listAllStudents = new List<Student>()
        {
                new Student()
                {
                    FirstName = "GIANNAKIS",
                    LastName = "OKKAS",
                    DateOfBirth = new DateTime(1990, 5, 12),
                    TuitionFees = 2000,
                    AssignmentsOfStudent = new List<Assignment>()
                    {
                        new Assignment ()
                        {
                            AssignmentTitle = "DATA STRUCTURES",
                            AssignmentDescription = "THIS IS ASSIGNMENT'S DESCRIPTION",
                            AssignmentSubDateTime = DateTime.Today.AddMonths(2)
                        }
                    },
                    CoursesOfStudent = new List<Course>()
                    {
                        new Course()
                        {
                            CourseTitle = "CB1",
                            CourseStream = CourseStream.JAVA,
                            CourseType = CourseType.FT,
                            CourseStartDate = DateTime.Today.AddMonths(1),
                            CourseEndDate = DateTime.Today.AddMonths(4),
                            StudentsOfCourse = new List<Student>(),
                            TrainersOfCourse = new List<Trainer>(),
                            AssignmentsOfCourse = new List<Assignment>()
                        }
                    }
                },

                new Student()
                {
                    FirstName = "GRIGORIS",
                    LastName = "GEORGATOS",
                    DateOfBirth = new DateTime(1985, 4, 1),
                    TuitionFees = 2000,
                    AssignmentsOfStudent = new List<Assignment>()
                    {
                        new Assignment ()
                        {
                            AssignmentTitle = "ALGORITHMS",
                            AssignmentDescription = "THIS IS ASSIGNMENT'S DESCRIPTION",
                            AssignmentSubDateTime = DateTime.Today.AddMonths(2)
                        }
                    },
                    CoursesOfStudent = new List<Course>()
                    {
                        new Course()
                        {
                            CourseTitle = "CB1",
                            CourseStream = CourseStream.PYTHON,
                            CourseType = CourseType.FT,
                            CourseStartDate = DateTime.Today.AddMonths(1),
                            CourseEndDate = DateTime.Today.AddMonths(4),
                            StudentsOfCourse = new List<Student>(),
                            TrainersOfCourse = new List<Trainer>(),
                            AssignmentsOfCourse = new List<Assignment>()
                        }

                    }
                },

                new Student()
                {
                    FirstName = "FELIX",
                    LastName = "BORJA",
                    DateOfBirth = new DateTime(1983, 2, 21),
                    TuitionFees = 2000,
                    AssignmentsOfStudent = new List<Assignment>()
                    {
                        new Assignment ()
                        {
                            AssignmentTitle = "WEB DEVELOPMENT",
                            AssignmentDescription = "THIS IS ASSIGNMENT'S DESCRIPTION",
                            AssignmentSubDateTime = DateTime.Today.AddMonths(2)
                        }
                    },
                    CoursesOfStudent = new List<Course>()
                    {
                        new Course()
                        {
                            CourseTitle = "CB1",
                            CourseStream = CourseStream.JAVASCRIPT,
                            CourseType = CourseType.FT,
                            CourseStartDate = DateTime.Today.AddMonths(1),
                            CourseEndDate = DateTime.Today.AddMonths(4),
                            StudentsOfCourse = new List<Student>(),
                            TrainersOfCourse = new List<Trainer>(),
                            AssignmentsOfCourse = new List<Assignment>()
                        }

                    }
                }
        };

        public static List<Assignment> listAllAssignments = new List<Assignment>()
        {
                new Assignment ()
                {
                    AssignmentTitle = "DATA STRUCTURES",
                    AssignmentDescription = "THIS IS ASSIGNMENT'S DESCRIPTION",
                    AssignmentSubDateTime = DateTime.Today.AddMonths(2)
                },

                new Assignment ()
                {
                    AssignmentTitle = "ALGORITHMS",
                    AssignmentDescription = "THIS IS ASSIGNMENT'S DESCRIPTION",
                    AssignmentSubDateTime = DateTime.Today.AddMonths(2)
                },

                new Assignment ()
                {
                    AssignmentTitle = "WEB DEVELOPMENT",
                    AssignmentDescription = "THIS IS ASSIGNMENT'S DESCRIPTION",
                    AssignmentSubDateTime = DateTime.Today.AddMonths(2)
                }

        };
    }
}
