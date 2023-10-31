namespace ObjectOrientedProgrammingIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("Opel", "Insignia", 5, 60);

            System.Console.WriteLine(car1.FuelLevel);
            car1.AddFuel(10);
            
            System.Console.WriteLine(car1.FuelLevel);
            car1.AddFuel(100);

            System.Console.WriteLine(car1.FuelLevel);

            car1.Drive(1000);
            System.Console.WriteLine($"Odometer is {car1.Odometer} and fuel level is {car1.FuelLevel}");

            car1.Drive(150);
            System.Console.WriteLine($"Odometer is {car1.Odometer} and fuel level is {car1.FuelLevel}");

            car1.Drive(150);
            System.Console.WriteLine($"Odometer is {car1.Odometer} and fuel level is {car1.FuelLevel}");

            car1.Drive(-100);
            System.Console.WriteLine($"Odometer is {car1.Odometer} and fuel level is {car1.FuelLevel}");

            //Java style
            //OldSchoolStudent s1 = new OldSchoolStudent("John", "Smith", 20);

            //Console.WriteLine($"{s1.GetName()} {s1.GetLastName()} is {s1.GetAge()} years old");

            //s1.SetAge(21);
            //Console.WriteLine($"{s1.GetName()} {s1.GetLastName()} is {s1.GetAge()} years old");

            //s1.SetLastName("Bond");
            //Console.WriteLine($"{s1.GetName()} {s1.GetLastName()} is {s1.GetAge()} years old");

            //C# style
            //Student s1 = new Student("John", "Smith", 20);
            //s1.LastName = "Bond";
            //s1.Age = 18;
            //Console.WriteLine($"{s1.FirstName} {s1.LastName} is {s1.Age} years old");
        }
    }
}
