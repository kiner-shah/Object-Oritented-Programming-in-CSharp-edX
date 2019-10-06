using System;

namespace MVA_Class_Demo {
    class Program {
        static void Main(string[] args) {

            /*
             * Using #region and #endregion, one can create regions
             * within code which allows us to expand or collapse
             * sections of code. This is useful when the code is too
             * large and we want don't want to look at all sections of
             * code. #region followed by some name, shows the name on
             * collapsing.
             */

            #region Anonymous class

            var anon = new {Name = "Tom", Age = 23};
            Console.WriteLine(anon.Name + " " + anon.Age);

            #endregion
        }
    }
}