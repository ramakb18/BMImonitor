using BMImonitor.ReferenceTypes;

class Program
{
    static void Main(string[] args)
    {
        var person = new Person
        {
            FirstName = "John",
            LastName = "Doe",
            Weight = 70,  // in kg
            Height = 1.75 // in meters
        };

        Console.WriteLine($"BMI for {person.FirstName} {person.LastName} is: {person.BMI:F2}");
    }
}
