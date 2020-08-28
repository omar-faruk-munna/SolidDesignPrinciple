using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    //Fat Interface
    public interface IFatUser
    {
        bool Register(string email, string username, string password);
        bool Login(string username, string password);
        void ResetPassword(string username);
        void LogError(string error);
        bool SendEmail(string emailContent);
    }

    //Interface Segregation
    public interface IUser
    {
        bool Register(string email, string username, string password);
        bool Login(string username, string password);
        void ResetPassword(string username);
    }

    // Interface Segregation
    public interface ILogger
    {
        void LogError(string error);
    }

    // Interface Segregation
    public interface IEmail
    {
        bool SendEmail(string emailContent);
    }


}
