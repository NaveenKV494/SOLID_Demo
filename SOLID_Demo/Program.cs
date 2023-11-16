using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();
            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if (isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            StandardMessages.EndApplication();
        }

    }
}
