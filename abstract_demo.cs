using System;

namespace MVA_Class_Demo {
    abstract class Employee {
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

        public abstract void Hire();
        public virtual void Login() {
            Console.WriteLine("Employee login");
        }
    }

    class Manager : Employee {
        private string department;

        public string Department {
            get { return department; }
            set { department = value; }
        }

        public override void Login() {
            Console.WriteLine("Manager login");
        }
        public override void Hire() {
            Console.WriteLine("Hire someone");
        }
    }

    class Program {
        static void Main(string[] args) {
            Manager myManager = new Manager();
            myManager.Login();
            myManager.Hire();
        }
    }
}