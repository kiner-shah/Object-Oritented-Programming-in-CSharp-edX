using System;

namespace MVA_Class_Demo {
    class Program {
        static void Main(string[] args) {
            var program = new UProgram("Information Technology");   // IT
            var s1 = new Student();
            var s2 = new Student();
            var s3 = new Student();

            var c1 = new Course("Programming in C#");  // programming in C#
            c1.AddStudent(s1);
            c1.AddStudent(s2);
            c1.AddStudent(s3);

            var t1 = new Teacher();
            c1.AddTeacher(t1);

            var d1 = new Degree("Bachelor");    // bachelors
            d1.AddCourse(c1);

            program.AddDegree(d1);

            program.PrintDegrees();
        }
    }
}