using ExamTask.Models;

namespace ExamTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam> exams = new List<Exam>();

            Console.WriteLine("Enter data to enter Exam (you can exit by typing exit):");

            while (true)
            {
                Console.Write("Student Name: ");
                string studentName = Console.ReadLine();

                if (studentName.ToLower() == "exit")
                {
                    break;
                }
                Console.Write("subject Name: ");
                string subject = Console.ReadLine();

                Console.Write("Point: ");
                int point = Convert.ToInt32(Console.ReadLine());



                Exam exam = new Exam
                {
                    StudentName = studentName,
                    Subject = subject,
                    Point = point,
                };

                exams.Add(exam);
            }

            var highPointExams = exams.FindAll(exam => exam.Point > 50);
            Console.WriteLine("Exams with more than 50 points:");
            DisplayExams(highPointExams);
        }

        static void DisplayExams(List<Exam> exams)
        {
            foreach (var exam in exams)
            {
                Console.WriteLine($"Student: {exam.StudentName}  subject: {exam.Subject}  Point: {exam.Point} ");
            }
        }
    }
}