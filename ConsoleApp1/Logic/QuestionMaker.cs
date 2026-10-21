using ConsoleApp1.Models;

namespace ConsoleApp1.Logic
{
    static class QuestionMaker
    {
        public static Question GetQuestion(QuestionType questionType)
        {
            Console.WriteLine("Enter The Header : ");
            string header = Console.ReadLine();

            Console.WriteLine("Enter Body : ");
            string body = Console.ReadLine();

            Console.WriteLine("Enter Mark : ");
            int mark = int.Parse(Console.ReadLine());

            while (mark <= 0)
            {
                Console.WriteLine("Mark must be greater than 0:");
                mark = int.Parse(Console.ReadLine());
            }

            return questionType == QuestionType.MCQ? GetMCQ(header, body, mark): GetTFQ(header, body, mark);
        }

        private static MCQ GetMCQ(string header, string body, int mark)
        {
            Answer[] answers = new Answer[4];

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter answer {i + 1} : ");
                string answerText = Console.ReadLine();

                answers[i] = new Answer(i + 1, answerText);
            }

            Console.WriteLine("Enter Correct Answer Id [1:4] : ");
            int correctAnswer = int.Parse(Console.ReadLine());

            while (correctAnswer < 1 || correctAnswer > 4)
            {
                Console.WriteLine("Wrong Choice ! choose from [1:4] : ");
                correctAnswer = int.Parse(Console.ReadLine());
            }

            return new MCQ(header, body, mark, answers, correctAnswer);
        }

        private static TFQ GetTFQ(string header, string body, int mark)
        {
            Console.WriteLine("Enter Correct Answer Id  (1. true , 2. false): ");
            int correctAnswer = int.Parse(Console.ReadLine());

            while (correctAnswer < 1 || correctAnswer > 2)
            {
                Console.WriteLine("Wrong Choice ! choose from [1:2] : ");
                correctAnswer = int.Parse(Console.ReadLine());
            }

            return new TFQ(header, body, mark, correctAnswer);
        }
    }
}
