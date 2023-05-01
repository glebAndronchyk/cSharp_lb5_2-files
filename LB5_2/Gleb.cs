using System;
using System.Collections.Generic;

namespace LB5_2
{
    class Gleb
    {
        public int improvedScholarship = 6000;
        
        public void Task(List<Student> studs)
        {
            string result = "";
            for (int i = 0; i < studs.Count; i++)
            {
                Student student = studs[i];
                double informatics = Char.GetNumericValue(student.informaticsMark);
                double mathematics = Char.GetNumericValue(student.mathematicsMark);
                double physics = Char.GetNumericValue(student.physicsMark);
                bool isAllMarksHigh = informatics == 5 && mathematics == 5 && physics == 5;
                bool isScholarshipNotImproved = student.scholarship != improvedScholarship;
                if (isAllMarksHigh && isScholarshipNotImproved)
                {
                    student.scholarship = improvedScholarship;
                }

                result += $"{student.ToString()}\n";
            }

            Console.WriteLine(result);
            File.WriteData("input.txt", result);
        }
    }
}