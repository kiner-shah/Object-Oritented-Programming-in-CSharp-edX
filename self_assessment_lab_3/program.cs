using System;
using System.Globalization;
using System.IO;

namespace MVA_Class_Demo {
    abstract class Person : IDisposable {
        private string personName;

        public string PersonName {
            get { return personName; }
            set { personName = value; }
        }

        public Person(string name) {
            this.PersonName = name;
        }

        public abstract void DoPersonRole();

        private StreamWriter outputFile = null;
        private StreamReader inputFile = null;

        public StreamWriter OutputFile {
            get { return outputFile; }
            set { outputFile = value; }
        }
        public StreamReader InputFile {
            get { return inputFile; }
            set { inputFile = value; }
        }

        public virtual string ReadFromFile(string filename) {
            String input = null;
            try {
                InputFile = new StreamReader(filename);
                input = InputFile.ReadToEnd();
            }
            catch (FileNotFoundException) {
                Console.WriteLine($"File {filename} not found");
            }
            finally {
                InputFile.Close();
                InputFile.Dispose();
                InputFile = null;
            }
            return input;
        }
        public virtual void WriteToFile(string filename, string line) {
            try {
                OutputFile = new StreamWriter(filename);
                OutputFile.WriteLine("Person: " + line);
            }
            catch (FileNotFoundException) {
                Console.WriteLine($"File {filename} not found");
            }
            finally {
                OutputFile.Close();
                OutputFile.Dispose();
                OutputFile = null;
            }
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing) {
            if (!disposed) {
                if (disposing) {
                    if (OutputFile != null) {
                        OutputFile.Close();
                        OutputFile.Dispose();
                        OutputFile = null;
                    }
                    if (InputFile != null) {
                        InputFile.Close();
                        InputFile.Dispose();
                        InputFile = null;
                    }
                }
            }
            disposed = true;
        }
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~Person() {
            Dispose(false);
        }
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
        public override void WriteToFile(string filename, string line) {
            try {
                OutputFile = new StreamWriter(filename);
                OutputFile.WriteLine("Student: " + line);
            }
            catch (FileNotFoundException) {
                Console.WriteLine($"File {filename} not found");
            }
            finally {
                OutputFile.Close();
                OutputFile.Dispose();
                OutputFile = null;
            }
        }
        public override string ReadFromFile(string filename) {
            String input = null;
            try {
                InputFile = new StreamReader(filename);
                input = InputFile.ReadToEnd();
                InputFile.Close();
            }
            catch (FileNotFoundException) {
                Console.WriteLine($"File {filename} not found");
            }
            finally {
                if (InputFile != null) {
                    InputFile.Dispose();
                    InputFile = null;
                }
            }
            return "Student: " + input;
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
        public override void WriteToFile(string filename, string line) {
            try {
                OutputFile = new StreamWriter(filename);
                OutputFile.WriteLine("Teacher: " + line);
            }
            catch (FileNotFoundException) {
                Console.WriteLine($"File {filename} not found");
            }
            finally {
                OutputFile.Close();
                OutputFile.Dispose();
                OutputFile = null;
            }
        }
        public override string ReadFromFile(string filename) {
            String input = null;
            try {
                InputFile = new StreamReader(filename);
                input = InputFile.ReadToEnd();
                InputFile.Close();
            }
            catch (FileNotFoundException) {
                Console.WriteLine($"File {filename} not found");
            }
            finally {
                if (InputFile != null) {
                    InputFile.Dispose();
                    InputFile = null;
                }
            }
            return "Teacher: " + input;
        }
    }

    class Program {
        static void Main(string[] args) {
            var p1 = new Student("S1");
            var p2 = new Teacher("T1");
            // p1.WriteToFile("student.txt", "I am writing a test");
            // p2.WriteToFile("teacher.txt", "I am grading a test");
            Console.WriteLine(p1.ReadFromFile("student.txt"));
            Console.WriteLine(p2.ReadFromFile("teacher.txt"));
        }
    }
}