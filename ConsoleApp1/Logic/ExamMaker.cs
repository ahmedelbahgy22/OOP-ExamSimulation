using ConsoleApp1.Models;

namespace ConsoleApp1.Logic
{
    static class ExamMaker
    {
        public static Exam GetExam(ExamType type)
        {
            Console.WriteLine("Enter Time Of Exam [30:180] minutes: ");
            int time = int.Parse(Console.ReadLine());

            while (time < 30 || time > 180)
            {
                Console.WriteLine("Wrong choice ! choose from [30:180]");
                time = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter The Number Of Questions : ");
            int n = int.Parse(Console.ReadLine());

            while (n <= 0)
            {
                Console.WriteLine("Number of questions must be greater than 0:");
                n = int.Parse(Console.ReadLine());
            }

            return type == ExamType.Practical? GetPracticalExam(time, n): GetFinalExam(time, n);
        }

        private static PracticalExam GetPracticalExam(int time, int n)
        {
            Question[] questions = new Question[n];
            int totalMark = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"-----Enter Question {i + 1}----");

                questions[i] = QuestionMaker.GetQuestion(QuestionType.MCQ);

                totalMark += questions[i].Mark;
            }

            return new PracticalExam(time, n, totalMark, questions);
        }

        private static FinalExam GetFinalExam(int time, int n)
        {
            Question[] questions = new Question[n];
            int totalMark = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"-----Enter Question {i + 1}----");

                Console.WriteLine("Choose question type:");
                Console.WriteLine("1. MCQ");
                Console.WriteLine("2. True / False");

                int choosen = int.Parse(Console.ReadLine());

                while (choosen < 1 || choosen > 2)
                {
                    Console.WriteLine("Wrong Choice ! choose from [1:2]:");
                    choosen = int.Parse(Console.ReadLine());
                }

                questions[i] = QuestionMaker.GetQuestion((QuestionType)choosen);

                totalMark += questions[i].Mark;
            }

            return new FinalExam(time, n, totalMark, questions);
        }
    }
}
