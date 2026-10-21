
using ConsoleApp1.Logic;
using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1, "Math");

            Console.Write("Choose Exam Type (1.PracticalExam 2.FinalExam) : ");
            int choosen = int.Parse(Console.ReadLine());

            while (choosen < 1 || choosen > 2)
            {
                Console.WriteLine("Wrong Choice ! choose from [1:2]:");
                choosen = int.Parse(Console.ReadLine());
            }

            subject.SubjectExam = ExamMaker.GetExam((ExamType)choosen);

            Console.Clear();
            string ans;

            do
            {
                Console.Write("Do you want to start the exam (Y | N)? ");
                ans = Console.ReadLine().Trim().ToUpper();

                if (ans != "Y" && ans != "N")
                {
                    Console.WriteLine("Invalid Choice! Please enter Y or N.");
                }

            } while (ans != "Y" && ans != "N");

            if (ans == "Y")
            {
                ExamStarter.SovleExam(subject.SubjectExam);
            }
            else
            {
                Console.WriteLine("Exam cancelled. Thank you!");
            }

        }
    }
}
