using System;

namespace _1050ITproject2
{
    class Program
    {
        public static double SumOfAllAges;

        static void Main(string[] args)
        {
            Person p1 = new Person(); //John Doe 34 Spouse.Jane Spouse.Doe Spouse.32 (Spouse of Spouse)
            System.Console.WriteLine("Enter Your First Name: ");
            p1.FirstName = System.Console.ReadLine();
            p1.Spouse.Spouse = p1.FirstName;
            System.Console.WriteLine("Enter Your Last Name: ");
            p1.LastName = System.Console.ReadLine();
            System.Console.WriteLine("Enter Your Age: ");
            p1.Age = int.Parse(System.Console.ReadLine());
            SumOfAllAges = SumOfAllAges + p1.Age;
            System.Console.WriteLine("Enter Your Spouse's First Name: ");
            p1.Spouse.FirstName = System.Console.ReadLine();
            p1.Spouse.LastName = p1.LastName;
            System.Console.WriteLine("Enter Your Spouse's Age: ");
            p1.Spouse.Age = int.Parse(System.Console.ReadLine());
            SumOfAllAges = SumOfAllAges + p1.Spouse.Age;

            Person p2 = new Person(); //David Smith 76 Spouse.Dora Spouse.Smith Spouse.64 (Spouse of Spouse)
            System.Console.WriteLine("Enter Your First Name: ");
            p2.FirstName = System.Console.ReadLine();
            p2.Spouse.Spouse = p2.FirstName;
            System.Console.WriteLine("Enter Your Last Name: ");
            p2.LastName = System.Console.ReadLine();
            System.Console.WriteLine("Enter Your Age: ");
            p2.Age = int.Parse(System.Console.ReadLine());
            SumOfAllAges = SumOfAllAges + p2.Age;
            System.Console.WriteLine("Enter Your Spouse's First Name: ");
            p2.Spouse.FirstName = System.Console.ReadLine();
            p2.Spouse.LastName = p2.LastName;
            System.Console.WriteLine("Enter Your Spouse's Age: ");
            p2.Spouse.Age = int.Parse(System.Console.ReadLine());
            SumOfAllAges = SumOfAllAges + p2.Spouse.Age;

            Person.PrintNameAndAge(p1);
            Person.PrintNameAndAge(p1.Spouse);
            Person.PrintNameAndAge(p2);
            Person.PrintNameAndAge(p2.Spouse);

            System.Console.WriteLine("Average Age = " + (SumOfAllAges / 4));
            //(p1.Age + p2.Spouse.Age + p2.Age + p2.Spouse.Age) / 4 = 51.5

        }
    }
}
