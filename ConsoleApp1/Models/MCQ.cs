namespace ConsoleApp1.Models
{
    class MCQ : Question
    {
        public MCQ(string header, string body, int mark, Answer[] answers, int correctAnswerId)
            : base(header, body, mark)
        {
            Answers = answers;
            CorrectAnswerId = correctAnswerId;
            NumberOfAnswers = answers.Length;
        }

        public override object Clone()
        {
            Answer[] answers = new Answer[Answers.Length];

            for (int i = 0; i < Answers.Length; i++)
            {
                answers[i] = (Answer)Answers[i].Clone();
            }

            MCQ question = new MCQ(
                Header,
                Body,
                Mark,
                answers,
                CorrectAnswerId
            );

            question.ChoosenAnsewer = ChoosenAnsewer;

            return question;
        }
    }
}
