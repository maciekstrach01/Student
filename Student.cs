namespace myStudent
{
public class Student
{
    public string Surname { get; set; }
    public int Identifier { get; set; }
    private List<int> grades;

    public Student(string surname, int identifier)
    {
        Surname = surname;
        Identifier = identifier;
        grades = new List<int>();
    }

    public void AddGrade(int grade)
    {
        grades.Add(grade);
    }

    public int? this[int index]
    {
        get
        {
            if (index >= 0 && index < grades.Count)
            {
                return grades[index];
            }
            else
            {
                Console.WriteLine("Index out of scope. There is no such assessment.");
                return null;
            }
        }
    }
}
}