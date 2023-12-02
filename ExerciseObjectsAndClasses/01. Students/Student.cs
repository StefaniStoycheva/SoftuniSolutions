

internal class Student
{
    //fields
    private string firstName;
    private string lastName;
    private double grade;

    //properties 
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    public double Grade
    {
        get { return grade; }
        set { grade = value; }
    }

    //constructor . method whith which we create objects from the class
    public Student(string firstName, string lastName, double grade)
    {
        //new empty object
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }
}

