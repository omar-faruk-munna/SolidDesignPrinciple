using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class ControllerClass
    {
        private readonly IRepo repo;

        public ControllerClass(IRepo repo)
        {
            this.repo = repo;
        }

        public void MyControllerMethod()
        {
            repo.MyMethod();
        }

    }
}
