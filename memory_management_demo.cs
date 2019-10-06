using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Class_Demo {
    class Animal {
        public int AnimalId { get; set; }
        public int Species { get; set; }
        public int Habitat { get; set; }
    }

    class Person : IDisposable {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        // flag to check if the object has been disposed
        private bool disposed = false;

        StreamReader sr;
        StreamWriter outputFile;

        public void ReadDetails(string fileName) {
            sr = new StreamReader(fileName);
            try {
                using (sr) {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e) {
                Console.WriteLine("File couldn't be read:");
                Console.WriteLine(e.Message);
            }
            finally {
                sr.Close();
                sr = null;
            }

        }

        public bool WriteDetails(string fileName) {
            bool result = false;
            outputFile = new StreamWriter(fileName);

            string[] lines = {this.PersonID.ToString(), this.FirstName, this.LastName, this.Gender, this.Age.ToString()};

            try {
                using (outputFile) {
                    foreach (string line in lines) {
                        outputFile.WriteLine(line);
                    }
                }
                result = true;
            }
            catch (Exception e) {
                Console.WriteLine("File couldn't be written:");
                Console.WriteLine(e.Message);
                result = false;
            }
            finally {
                outputFile.close();
                outputFile = null;
            }
            return result;
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing) {
            if (!disposed) {
                if (disposing) {
                    if (sr != null) sr.Close();
                    if (outputFile != null) outputFile.Close();
                }
            }
            disposed = true;
        }
    }

    class Program {
        static void Main(string[] args) {
        }
    }
}