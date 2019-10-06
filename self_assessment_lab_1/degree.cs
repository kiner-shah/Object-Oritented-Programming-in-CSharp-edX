using System;
using System.Collections.Generic;

namespace MVA_Class_Demo {
    class Degree {
        private List<Course> course_lst;
        private string degreeName;

        public string DegreeName {
            get { return degreeName; }
            set { degreeName = value; }
        }

        public Degree(string dName) {
            course_lst = new List<Course>();
            DegreeName = dName;
        }
        public void AddCourse(Course c) {
            course_lst.Add(c);
        }
        public void PrintCourses() {
            Console.WriteLine($"Courses along with respective student count in {DegreeName} are:");
            foreach (Course c in course_lst) {
                Console.WriteLine(c.CourseName + " " + c.GetStudentCount());
            }
            Console.WriteLine();
        }
    }
}