using System;

namespace MVA_Class_Demo {
    class Employee {
        private string empNumber;
        private string firstName;
        private string lastName;
        private string address;

        public string EmpNumber {
            get { return empNumber; }
            set { empNumber = value; }
        }
        public string FirstName {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Address {
            get { return address; }
            set { address = value; }
        }
    }

    class Manager : Employee {
        private string department;

        public string Department {
            get { return department; }
            set { department = value; }
        }
    }

    class Program {
        static void Main(string[] args) {
            Manager myManager = new Manager();
        }
    }
}