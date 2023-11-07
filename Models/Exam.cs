namespace ExamTask.Models
{
    public class Exam
    {
        public string StudentName { get; set; }
        public string Subject { get; set; }
        public int Point { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
