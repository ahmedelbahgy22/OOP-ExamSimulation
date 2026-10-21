using ConsoleApp1.Models;

namespace ConsoleApp1.Logic
{
    static class ExamResult
    {
        public static void ShowExamResult(Exam exam)
        {
            
            Console.WriteLine("Final Exam Results:");

            for (int i = 0; i < exam.Questions.Length; i++)
            {
                Question question = exam.Questions[i];

                Console.WriteLine($"Question {i + 1}: {question.Body}");

                Console.WriteLine($"Your Answer => {question.Answers[question.ChoosenAnsewer - 1].AnswerText}");

                Console.WriteLine($"Correct Answer => {question.Answers[question.CorrectAnswerId - 1].AnswerText}");
            }

            Console.WriteLine();
            Console.WriteLine($"Your Grade is {exam.Result} from {exam.TotalMark}");
            Console.WriteLine($"Time = {TimeSpan.FromMilliseconds(exam.ElapsedTime)}");
            Console.WriteLine("Thank you");
        }
    }
}
