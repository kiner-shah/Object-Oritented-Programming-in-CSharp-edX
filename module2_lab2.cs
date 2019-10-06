using System;

namespace Module2_Lab2 {
    abstract class Employee {
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;
        private static int employeeCount = 1;

        public string EmployeeName {
            get { return employeeName; }
            set { employeeName = value; }
        }
        public double EmployeeBaseSalary {
            get { return employeeBaseSalary; }
            set { employeeBaseSalary = value; }
        }
        public int EmployeeId {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public Employee(string name, double baseSalary) {
            this.EmployeeName = name;
            this.EmployeeBaseSalary = baseSalary;
            this.EmployeeId = employeeCount++;
        }
        public double getBaseSalary() { return this.EmployeeBaseSalary; }
        public string getName() { return this.EmployeeName; }
        public int getEmployeeId() { return this.EmployeeId; }
        public string toString() {
            return this.EmployeeId + " " + this.EmployeeName;
        }
        public abstract string employeeStatus();
    }

    class TechnicalEmployee : Employee {
        public int successfulCheckins = 5;

        public TechnicalEmployee(string name) : base(name, 75000) {

        }
        public override string employeeStatus() {
            return this.toString() + " has " + this.successfulCheckins + " successful check ins";
        }
    }

    class BusinessEmployee : Employee {
        public double bonusBudget = 1000;

        public BusinessEmployee(string name) : base(name, 50000) {

        }
        public override string employeeStatus() {
            return this.toString() + " with a budget of " + this.bonusBudget;
        }
    }

    class Program {
        static void Main(string[] args) {
            var e1 = new TechnicalEmployee("Libbly");
            var e2 = new TechnicalEmployee("Zaynah");
            var e3 = new BusinessEmployee("Winter");

            Console.WriteLine(e1.employeeStatus() + "..." +  e2.employeeStatus() + "..." + e3.employeeStatus());
        }
    }
}