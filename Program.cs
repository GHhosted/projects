using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("in.txt"))
            {
                StreamReader inFile = new StreamReader("in.txt", Encoding.Default);
                int stringLength = Int32.Parse(inFile.ReadLine());
                string stringToFormat = inFile.ReadLine();
                inFile.Close();

                writer(stringToFormat);
            }
            else
            {
                Console.Write("File not found!\n\nPress any key to exit...");
                Console.ReadKey();
                return;
            }
        }


        static void writer(string stringToFormat)
        {
            StreamWriter outFile = File.CreateText("out.txt");
            int length = stringToFormat.Length;

            for (int i = 0; i < length; i++)
            {
                if (stringToFormat[i] == ' ')
                {
                    outFile.WriteLine();
                }
                else {
                    outFile.Write(stringToFormat[i]);
                }
            }
            outFile.Close();
        }
    }
}
