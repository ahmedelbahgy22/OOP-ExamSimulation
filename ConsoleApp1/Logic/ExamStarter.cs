using ConsoleApp1.Models;
using System.Diagnostics;

namespace ConsoleApp1.Logic
{
    static class ExamStarter
    {
        public static void SovleExam(Exam exam)
        {
            int result = 0;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < exam.Questions.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}:");
                Console.WriteLine(exam.Questions[i]);

                foreach (var ans in exam.Questions[i].Answers)
                {
                    Console.WriteLine(ans);
                }

                Console.Write("Choose Answer : ");
                int choosen = int.Parse(Console.ReadLine());

                while (choosen < 1 || choosen > exam.Questions[i].Answers.Length)
                {
                    Console.WriteLine(
                        $"Wrong Choice ! choose from [1:{exam.Questions[i].Answers.Length}]:");

                    choosen = int.Parse(Console.ReadLine());
                }

                if (exam.Questions[i].checkAnswer(choosen))
                {
                    result += exam.Questions[i].Mark;
                }
            }

            stopwatch.Stop();

            exam.ElapsedTime = (int)stopwatch.ElapsedMilliseconds;
            exam.Result = result;
            Console.Clear();
            ExamResult.ShowExamResult(exam);
        }
    }
}
