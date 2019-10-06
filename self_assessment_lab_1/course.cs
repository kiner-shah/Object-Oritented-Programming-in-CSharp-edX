using System;
using System.Collections.Generic;

namespace MVA_Class_Demo {
    class Course {
        private List<Student> student_lst;
        private List<Teacher> teacher_lst;

        private string courseName;

        public string CourseName {
            get { return courseName; }
            set { courseName = value; }
        }

        public Course(string cName) {
            student_lst = new List<Student>();
            teacher_lst = new List<Teacher>();
            CourseName = cName;
        }
        public void AddStudent(Student s) {
            student_lst.Add(s);
        }
        public void AddTeacher(Teacher t) {
            teacher_lst.Add(t);
        }
        public int GetStudentCount() {
            return student_lst.Count;
        }
    }
}