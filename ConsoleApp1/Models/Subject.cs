namespace ConsoleApp1.Models
{
    class Subject
    {
        public int SUbjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam;

        public Subject(int sUbjectId, string subjectName)
        {
            SUbjectId = sUbjectId;
            SubjectName = subjectName;
        }
    }
}
