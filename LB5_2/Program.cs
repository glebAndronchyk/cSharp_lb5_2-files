using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace LB5_2
{
    internal class Program
    {
        static void RunMenu(List<Student> studs)
        {
            int choice;

            do
            {
                Console.WriteLine("Select:\nEnter 1 to select student Rostik:");
                Console.WriteLine("Enter 2 to select student Gleb:");
                Console.WriteLine("Enter 0 to exit the program!");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        break;
                    case 1:
                        Rostik rostik = new Rostik();
                        rostik.MyTask(studs);
                        break;
                    case 2:
                        Gleb gleb = new Gleb();
                        gleb.Task(studs);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Команда не розпiзнана!");
                        Console.ResetColor();
                        break;
                }
            } while (choice != 0);
        }
        static void Main()
        {
            List<Student> studs = File.ReadStudentsData("input.txt");
            RunMenu(studs);
        }
    }
}