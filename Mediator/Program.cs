#region main

Mediator mediator = new Mediator();
Teacher teacher = new Teacher(mediator);
teacher.Name = "Hasan";

mediator.Teacher = teacher;

var student = new Student(mediator);
student.Name = "Ali";
var student1 = new Student(mediator);
student1.Name = "Emirhan";
var student2 = new Student(mediator);
student2.Name = "Aksu";
var student3 = new Student(mediator);
student3.Name = "Emre";

List<Student> students = new List<Student>()
{
    student,
    student1,
    student2,
    student3
};

mediator.Students = new List<Student>(students);


teacher.SendNewImageUrl("Slide1.jpg");

student.AskQuestion("What is that mean ?");

teacher.AnswerQuestion("It is first slide of this course, it means ...", student);

#endregion


abstract class CourseMember
{
    protected Mediator Mediator;

    protected CourseMember(Mediator mediator)
    {
        Mediator = mediator;
    }
}

class Teacher : CourseMember
{
    public Teacher(Mediator mediator) : base(mediator)
    {
    }

    public string Name { get; internal set; }

    public void ReceiveQuestion(string question, Student student)
    {
        Console.WriteLine($"Teacher received question : {question} from {student.Name}");
    }

    public void SendNewImageUrl(string url)
    {
        Console.WriteLine($"Teacher changed slide : {url}");
        Mediator.UpdateImage(url);
    }

    public void AnswerQuestion(string answer, Student student)
    {
        Console.WriteLine($"""
        Teacher answered question from {student.Name} with "{answer}"
        """);
    }
}

class Student : CourseMember
{
    public Student(Mediator mediator) : base(mediator)
    {
    }

    public string Name { get; internal set; }

    public void AskQuestion(string question)
    {
        Console.WriteLine($"{Name} asking a question: {question}");
        Mediator.SendQuestion(question, this);
    }

    public void ReceiveImage(string url)
    {
        Console.WriteLine($"{Name} received image : {url}");
    }

    public void ReceiveAnswer(string answer)
    {
        Console.WriteLine($"Student received answer : {answer}");
    }
}

class Mediator
{
    public Teacher Teacher { get; set; }
    public List<Student> Students { get; set; }

    public void UpdateImage(string url)
    {
        foreach (var student in Students)
        {
            student.ReceiveImage(url);
        }
    }

    public void SendQuestion(string question, Student student)
    {
        Teacher.ReceiveQuestion(question, student);
    }

    public void SendAnswer(string answer, Student student)
    {
        student.ReceiveAnswer(answer);
    }
}
