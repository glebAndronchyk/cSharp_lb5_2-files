using System;
using System.Collections.Generic;

namespace LB5_2
{
    public class Rostik
    {
        public void MyTask(List<Student> studs)
        {
            Console.WriteLine("Result:\nStudents with average mark > 4.5 in Physics:");

            foreach (var student in studs)
            {
                if (student.PhysicsAverage() > 4.5)
                {
                    Console.WriteLine($"{student.surName} {student.firstName} {student.patronymic} {student.physicsMark}");
                }
            }
        }
    }
}