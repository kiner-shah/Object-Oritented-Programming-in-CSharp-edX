using System;
using System.Collections.Generic;

namespace MVA_Class_Demo {
    class UProgram {
        // degrees
        private List<Degree> degree_lst;
        private string programName;

        public string ProgramName {
            get { return programName; }
            set { programName = value; }
        }

        public UProgram(string pName) {
            degree_lst = new List<Degree>();
            ProgramName = pName;
        }

        public void AddDegree(Degree d) {
            degree_lst.Add(d);
        }

        public void PrintDegrees() {
            Console.WriteLine($"Degrees in {ProgramName} are:");
            foreach (Degree d in degree_lst) {
                Console.WriteLine($"============= {d.DegreeName} =============");
                d.PrintCourses();
            }
            Console.WriteLine();
        }
    }
}