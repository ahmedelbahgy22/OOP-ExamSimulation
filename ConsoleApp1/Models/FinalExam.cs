namespace ConsoleApp1.Models
{
    class FinalExam : Exam
    {
        public FinalExam(int timeOfExam, int numberOfQuestions, int totalMark, Question[] questions)
            : base(timeOfExam, numberOfQuestions)
        {
            Questions = questions;
            TotalMark = totalMark;
        }
    }
}
