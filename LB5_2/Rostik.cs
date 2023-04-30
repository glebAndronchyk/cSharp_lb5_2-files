using System;
using System.Collections.Generic;

namespace LB5_2
{
    public class Rostik
    {
        static void TaskSeven(List<Student> students)
        {
            Console.WriteLine("Result:\nStudents with average mark > 4.5 in Physics:");

            foreach (var student in students)
            {
                if (student.PhysicsAverage() > 4.5)
                {
                    Console.WriteLine($"{student.surName} {student.firstName} {student.patronymic} {student.physicsMark}");
                }
            }
        }
        public void MyTask()
        {
            List<Student> students = Program.ReadData("input.txt");
            TaskSeven(students);
        }
    }
}