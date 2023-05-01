using System;
using System.Collections.Generic;
using System.IO;

namespace LB5_2
{
    class File
    {
        public static List<Student> ReadStudentsData(string fileName)
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
            finally
            {
                sr.Close();
            }

            return students;
        }
        
        public static void WriteData(string fileName, string data)
        {
            StreamWriter sw = new StreamWriter(fileName, false);

            try
            {
                sw.Write(data);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to write data in {fileName}:\n" + e.Message);
                throw;
            }
            finally
            {
                sw.Close();
            }
        }

    }
}