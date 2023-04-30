using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LB5_2
{
    partial class Program
    {
        static List<Student> ReadData(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string studentInfo;
            List<Student> students = new List<Student>();
            
            try
            {
                while (!sr.EndOfStream)
                {
                    studentInfo = sr.ReadLine();
                    Student student = new Student(studentInfo);
                    students.Add(student);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Failed to read line {fileName}:\n" + e.Message);
                throw;
            }

            return students;
        }

        static void runMenu(List<Student> studs)
        {
            Console.WriteLine(studs[0].firstName);
        }

        static void Main(string[] args)
        {
            List<Student> studs = ReadData("input.txt");
            runMenu(studs);
        }
    }
}