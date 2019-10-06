using System;
using System.Globalization;
using System.IO;

namespace Module3_lab1 {
    class Program {
        public static void Main(string[] args) {
            StreamReader streamReaderObject = null;
            try {
                streamReaderObject = new StreamReader("file1.txt");
                String contents = streamReaderObject.ReadToEnd();
                // Writes the amount of text elements in the text file to the Console
                // StringInfo class provides functionality to split a string into text elements and to iterate through those text elements.
                // LengthInTextElements - Gets the number of text elements in the current StringInfo object.
                Console.WriteLine("The file has {0} text elements.", new StringInfo(contents).LengthInTextElements);
            }
            catch (FileNotFoundException) {
                Console.WriteLine("THe file cannot be found");
            }
            finally {
                if (streamReaderObject != null) {
                    streamReaderObject.Close();
                    // Calls upon the Dispose method
                    // Releases all resources used by the TextReader object
                    streamReaderObject.Dispose();
                }
            }
        }
    }
}