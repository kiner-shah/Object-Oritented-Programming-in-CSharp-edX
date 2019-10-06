using System;

namespace MVA_Class_Demo {
    abstract class Person {
        private string personName;
        public string PersonName {
            get { return personName; }
            set { personName = value; }
        }

        public Person(string name) {
            this.PersonName = name;
        }

        public abstract void DoPersonRole();
    }

    class Student : Person {
        private static int countStudents = 0;
        public Student(string name) : base(name) {
            countStudents++;
        }
        private void TakeTest() {
            Console.WriteLine($"{this.PersonName} is taking the test");
        }
        public override void DoPersonRole() {
            TakeTest();
        }
    }

    class Teacher : Person {
        public Teacher(string name) : base(name) {
        }
        private void GradeTest() {
            Console.WriteLine($"{this.PersonName} is grading the test");
        }
        public override void DoPersonRole() {
            GradeTest();
        }
    }

    class Program {
        static void Main(string[] args) {
            var p1 = new Student("S1");
            var p2 = new Teacher("T1");
            p1.DoPersonRole();
            p2.DoPersonRole();
        }
    }
}