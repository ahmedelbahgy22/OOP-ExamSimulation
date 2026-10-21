namespace ConsoleApp1.Models
{
    abstract class Question : ICloneable
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public Answer[] Answers { get; protected set; }
        public int CorrectAnswerId { get; protected set; }
        public int NumberOfAnswers { get; protected set; }
        public int ChoosenAnsewer { get; protected set; }

        protected Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        public bool checkAnswer(int ans)
        {
            ChoosenAnsewer = ans;
            return ans == CorrectAnswerId;
        }

        public abstract object Clone();

        public override string ToString()
        {
            return $"{Header}\n{Body} ({Mark} marks)";
        }
    }
}
