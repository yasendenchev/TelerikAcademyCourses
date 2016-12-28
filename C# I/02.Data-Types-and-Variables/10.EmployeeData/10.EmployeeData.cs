using System;
    class Program
    {
        static void Main()
        {
            Console.Write("First name: ");
            string fName = Console.ReadLine();
            Console.Write("Last name: ");
            string lName = Console.ReadLine();
            Console.Write("Age: ");
            byte age = byte.Parse(Console.ReadLine());
            Console.Write("Gender: ");
            string gender = Console.ReadLine();
            Console.Write("ID Number: ");
            long idNumber = long.Parse(Console.ReadLine());
            Console.Write("Employee Number: ");
            uint employeeNumber = uint.Parse(Console.ReadLine());


            Console.WriteLine(fName);
            Console.WriteLine(lName);
            Console.WriteLine(age);
            Console.WriteLine(gender);
            Console.WriteLine(idNumber);
            Console.WriteLine(employeeNumber);
        }
    }

