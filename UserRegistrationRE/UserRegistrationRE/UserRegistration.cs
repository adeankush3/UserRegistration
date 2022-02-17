using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationRE
{
    public class UserRegistration
    {
        public void FirstName()
        {
            Regex FirstName = new Regex("^[A-Z]{1}[a-z]{3,14}$");

            System.Console.WriteLine("Enter Your First Name is:-");
            string firstname = Console.ReadLine();
            if (FirstName.IsMatch(firstname))
            {
                System.Console.WriteLine("Your Name is :" + firstname);
            }
            else
            {
                System.Console.WriteLine("Enter Valid Name");
            }
        }
    }
}
