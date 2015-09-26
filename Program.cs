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

                writer(stringToFormat, stringLength);
            }
            else
            {
                Console.Write("File not found!\n\nPress any key to exit...");
                Console.ReadKey();
                return;
            }
        }


        static void writer(string stringToFormat, int stringLength)
        {
            StreamWriter outFile = File.CreateText("out.txt");
            string[] stringOfWords = stringToFormat.Split(' ');

            for (int i = 0, counter = 0; i < stringOfWords.Length; i++)
            {
                counter += stringOfWords[i].Length;
                if (counter <= stringLength)
                {
                    outFile.Write(stringOfWords[i]);
                }
                else
                {
                    counter = 0;
                    i--;
                    outFile.WriteLine();
                    continue;
                }
                if (counter + 1 < stringLength)
                {
                    outFile.Write(" ");
                    counter++;
                }
            }

            outFile.Close();
        }
    }
}
