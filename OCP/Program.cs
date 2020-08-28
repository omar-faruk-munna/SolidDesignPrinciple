using System;

namespace OCP
{
    class Program
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
