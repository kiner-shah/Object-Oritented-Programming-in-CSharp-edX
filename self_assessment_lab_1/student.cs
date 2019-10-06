using System;

namespace MVA_Class_Demo {
    class Student {
        private static int countStudents = 0;

        public Student() {
            countStudents++;
        }
    }
}