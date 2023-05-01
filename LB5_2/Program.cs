using System.Collections.Generic;

namespace LB5_2
{
    class Program
    {
        static void runMenu(List<Student> studs)
        {
            new Gleb().Task(studs);
        }

        static void Main(string[] args)
        {
            List<Student> studs = File.ReadStudentsData("input.txt");
            runMenu(studs);
        }
    }
}