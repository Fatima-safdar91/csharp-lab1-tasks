using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1();
            task2();
            //task3();
        }

        static void task1()
        {
            string filepath = "C:\\Fatima's Personal\\backup\\C#\\dangar.txt";
            StreamReader variable = new StreamReader(filepath);
            string record;
            while ((record = variable.ReadLine()) != null)
            {
                Console.WriteLine(record);
            }
            variable.Close();
            Console.ReadKey();
        }
        static void task2()
        {
            string filepath = "C:\\Fatima's Personal\\backup\\C#\\dangar.txt";
            StreamReader variable = new StreamReader(filepath);
            string record;
            if (File.Exists(filepath))
            {
                while ((record = variable.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                variable.Close();
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
            Console.ReadKey();
        }
        static void task3()
        {
            string filepath = "C:\\Fatima's Personal\\backup\\C#\\dangar.txt";
            StreamWriter variable = new StreamWriter(filepath, true);
            variable.WriteLine("SAB MAYA HAII");
            variable.Flush();
            variable.Close();
            Console.ReadKey();
        }

    }
}
