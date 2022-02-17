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
            Regex FirstName = new Regex("^[A-Z]{1}[a-z]{2,20}$");

            Console.WriteLine("Enter Your First Name is:-");
            string firstname = Console.ReadLine();
           
            if (FirstName.IsMatch(firstname))
            {
                Console.WriteLine("Your Name is :" + firstname);
            }
            else
            {
                Console.WriteLine("Enter Valid Name");
            }
        }
        
        public void LastName()
        {
            Regex LastName = new Regex("^[A-Z]{1}[a-z]{2,20}$");

            Console.WriteLine("Enter Last Name :");
            string lastname = Console.ReadLine();
            
            if (LastName.IsMatch(lastname))
            {
                Console.WriteLine("Your last Name is :" + lastname);
            }
            else
            {
                Console.WriteLine("Enter Valid Last Name");
            }
        }
    }
}
