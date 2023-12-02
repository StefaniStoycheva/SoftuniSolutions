int countStudents = int.Parse(Console.ReadLine());

List<Student> students = new List<Student>(); //list with the students to contain them from line 15

for (int count = 1; count <= countStudents; count++)
{
    String data = Console.ReadLine();
    string[] dataParts = data.Split(" ");//масив

    string firstName = dataParts[0];
    string lastName = dataParts[1];
    double grade = double.Parse(dataParts[2]); //Convert to double

    Student student = new Student(firstName, lastName, grade); //new object is created 
    students.Add(student);
}
students = students.OrderByDescending(s => s.Grade).ToList();

foreach(Student student in students)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
}