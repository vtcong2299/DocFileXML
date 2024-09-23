using System;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace DocFileXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ReadAndWrite readAndWrite = new ReadAndWrite();
            bool isWriten = readAndWrite.WriteToFile();
            if (isWriten)
            {
                readAndWrite.ReadFromFile();
            }
            else
            {
                System.Console.WriteLine("Write data to file occur an error. Please try again !");
            }
           
        }

    }
}