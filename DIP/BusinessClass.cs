using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class BusinessClass : IRepo
    {
        public void MyMethod()
        {
            Console.WriteLine("hello");
        }
    }
}
