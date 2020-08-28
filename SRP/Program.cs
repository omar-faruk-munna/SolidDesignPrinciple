using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    //Multiple Responsibility
    public class MultipleResponsibility
    {
        void Register(string email, string username, string password)
        {
            Console.WriteLine("register function");
        }
        void Login(string username, string password)
        {
            Console.WriteLine("Login function");
        }
        void ResetPassword(string username)
        {
            Console.WriteLine("ResetPassword function");
        }
        void LogError(string error)
        {
            Console.WriteLine("LogError function");
        }
        void SendEmail(string emailContent)
        {
            Console.WriteLine("SendEmail function");
        }
    }

    //Single Responsibility
    public class User
    {
        void Register(string email, string username, string password)
        {
            Console.WriteLine("register function");
        }
        void Login(string username, string password)
        {
            Console.WriteLine("Login function");
        }
        void ResetPassword(string username)
        {
            Console.WriteLine("ResetPassword function");
        }
    }

    //Single Responsibility
    public class Logger
    {
        void LogError(string error)
        {
            Console.WriteLine("LogError function");
        }
    }

    //Single Responsibility
    public class Email
    {
        void SendEmail(string emailContent)
        {
            Console.WriteLine("SendEmail function");
        }
    }

}
