Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{ 
 string student = Console.ReadLine();   
 double grades = double.Parse(Console.ReadLine());

    if (!students.ContainsKey(student))
    {
        students.Add(student, new List<double>());
    }
    students[student].Add(grades);
}
var excellent =students.Where(kvp => kvp.Value.Average() >= 4.50);

foreach (var CurrentStudent in excellent)
{
    Console.WriteLine($"{CurrentStudent.Key} -> {CurrentStudent.Value.Average():F2}");
}