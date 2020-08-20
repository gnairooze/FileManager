using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            sample();

            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }

        static void sample() 
        {
            string readFilename = "sample.txt";
            string saveFilename = "save-sample.txt";
            string message1 = "sample text 1 to save";
            string message2 = "sample text 2 to save";

            FileManager.Controller manager = new FileManager.Controller();
            manager.LineRead += Manager_LineRead;

            manager.ReadFile(false, readFilename);

            manager.SaveFile(true, saveFilename, message1);
            manager.SaveFile(true, saveFilename, message2);
        } 

        private static void Manager_LineRead(object sender, FileManager.LineReadEventArgs e)
        {
            Console.WriteLine(e.Header);
            Console.WriteLine(e.CurrentLine);
        }
    }
}
