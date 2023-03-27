public class student
{
    private int studentID;
    private string studentName;
public static List<student> student_list = new List<student>();

 public student(int studentID, string studentName)
    {
    
        this.studentID = studentID;
        this.studentName = studentName;
        student_list.Add(this);
    }

    public void PrintInfo()
    {
        Console.WriteLine("Student ID: " + studentID + " Student Name: " + studentName);
    }

    public int GetStudentID()
    {
        return studentID;
    }

    public string GetStudentName()
    {
        return studentName;
    }
}

public class Program
{
    public static void Main()
    {
        // generate 4 students
        student student1 = new student(111, "Alice");
        student student2 = new student(222, "Bob");
        student student3 = new student(333, "Cathy");
        student student4 = new student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        // add the name-grade combinaiton 
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        // check for record Tom
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }
   
        double total = 0;
        foreach (KeyValuePair<string, double> entry in gradebook)
        {
            // add the GPA to the total
            total += entry.Value;
        }

        double average = total / gradebook.Count;

        Console.WriteLine("Average GPA: " + average);

        // print out student info if GPA is greater than avergae
        foreach (KeyValuePair<string, double> entry in gradebook)
        {
            if (entry.Value > average)
            {

                Console.WriteLine(entry.Key + " has a GPA greater than the average GPA");

                foreach (student student in student.student_list)
                {
                    if (student.GetStudentName() == entry.Key)
                    {

                        student.PrintInfo();
                    }
                }
            }
        }


    }
}