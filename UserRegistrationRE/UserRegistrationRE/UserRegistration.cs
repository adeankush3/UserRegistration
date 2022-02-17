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
        public void Email()
        {
            Regex Email1 = new Regex("^([a-zA-Z0-9.]{3,})?[@][a-zA-Z]{5,}[.][a-zA-Z]{2,3}?$");//Abc@Yahoo.com
            
            Console.WriteLine("Enter Email id :");
            string email = Console.ReadLine();
            if (Email1.IsMatch(email))
            {
                Console.WriteLine("Your Email id is :" + email);
            }
            else
            {
                Console.WriteLine("please enter valid Email-ID");
            }
        }
        public void MobileNumber()
        {
            Regex Number = new Regex("^[9]{1}[1]{1}[ ][6-9]{1}[0-9]{9}$");

            Console.WriteLine("Enter Contact Number :");
            string contact = (Console.ReadLine());

            if (Number.IsMatch(contact))
            {
                Console.WriteLine("Your Mobile Number is :" + contact);
            }
            else
            {
                Console.WriteLine("please enter valid Mobile Number:");
            }
        }
        public void Password()
        {
            Regex PSW = new Regex("^[A-Za-z0-9]{8,}$");

            Console.WriteLine("Enter Your password :");
            string password = Console.ReadLine();

            if (PSW.IsMatch(password))
            {
                Console.WriteLine("Your password is :" + password);
            }
            else
            {
                Console.WriteLine("please enter valid password");
            }
        }
    }
}
