using System;

namespace RemainingTopics
{
    public static class StringUtilities
    {
        public static string ToName(this string input) =>
            $"{input[0].ToString().ToUpper()}{input[1..].ToLower()}";
    }
    public static class NumberUtilities
    {
        public static bool IsOdd(this int input) =>
            input % 2 == 1;
    }


    class Program
    {
        static void Main(string[] args)
        {
            string name = "jamES";
            
            Console.WriteLine(name.ToName());
            
            Console.WriteLine(5.IsOdd());
            Console.WriteLine(6.IsOdd());

            //Pair<int,int> p = new Pair<int, int>();
            //p.First = 10;
            //p.Second = 20;

            //Console.WriteLine($"{p.First} {p.Second}");

            //Pair<string, string> ps = new Pair<string, string>();
            //ps.First = "James";
            //ps.Second = "Bond";

            //Console.WriteLine($"{ps.First} {ps.Second}");

            //Pair<string, int> ppp = new Pair<string, int>();
            //ppp.First = "10";
            //ppp.Second = 10;

            //Person p = new Person();
            //p.name = "James";
            //p.age = 40;
            //ModifyPerson(p);
            //Console.WriteLine($"{p.name} is {p.age}");
        }

        static void ModifyPerson(Person person)
        {
            person.name = "Bond";
            person.age = 50;
        }
    }
}
