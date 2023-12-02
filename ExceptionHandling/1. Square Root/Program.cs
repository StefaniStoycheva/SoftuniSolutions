
try
{
    int num = int.Parse(Console.ReadLine());
    if (num < 0)
    {
        throw new ArgumentException();  //causing the problem
    }

    double sqrt = Math.Sqrt(num); 
    Console.WriteLine(sqrt);
}
catch(ArgumentException)
{
    Console.WriteLine("Invalid number."); //catching it 
}
finally
{
    Console.WriteLine("Goodbye."); //always write/execute
}