namespace ConsoleApp1.Models
{
    class PracticalExam : Exam
    {
        public PracticalExam(int timeOfExam, int numberOfQuestions, int totalMark, Question[] questions)
            : base(timeOfExam, numberOfQuestions)
        {
            Questions = questions;
            TotalMark = totalMark;
        }
    }
}
