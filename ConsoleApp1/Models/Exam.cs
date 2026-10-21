namespace ConsoleApp1.Models
{
    abstract class Exam
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; protected set; }
        public int TotalMark { get; protected set; }
        public int Result { get; set; }
        public int ElapsedTime { get; set; }

        protected Exam(int timeOfExam, int numberOfQuestions)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
        }
    }
}
