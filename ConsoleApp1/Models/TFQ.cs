namespace ConsoleApp1.Models
{
    class TFQ : Question
    {
        public TFQ(string header, string body, int mark, int correctAnswerId): base(header, body, mark)
        {
            Answers = new Answer[]
            {
                new Answer(1, "True"),
                new Answer(2, "False")
            };

            CorrectAnswerId = correctAnswerId;
            NumberOfAnswers = 2;
        }

        public override object Clone()
        {
            TFQ question = new TFQ(
                Header,
                Body,
                Mark,
                CorrectAnswerId
            );

            question.ChoosenAnsewer = ChoosenAnsewer;

            return question;
        }
    }
}
