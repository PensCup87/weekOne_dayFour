using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekOne_dayFour
{
    class Program
    {
        static void Main(string[] args)
        {
            //STRINGS
            // - consist of various characters, symbols, or numbers (a number can not be used for MATH)
            // - Contents are in DOUBLE QUOTES


            //Console.WriteLine("This is a tab \t.");
            //Console.WriteLine("This is a \"quote\".");
            //Console.WriteLine("This is a backslash\\");
            //Console.WriteLine("This is a \n new line.");
            //Console.WriteLine("This is a bell \a");

            //string firstName = "Daniel";
            //string dogName = "Gus";

            //Console.WriteLine("His name is {1} and his dog is {1}.", firstName, dogName);

            //Console.WriteLine(firstName.Length);

            //End Of Class Practice Problems:

            string firstName = "Brian";
            int firstNameLength = firstName.Length;
            Console.WriteLine(firstName.Length);
            string lastName = "Tome";
            int lastNameLength = lastName.Length;
            Console.WriteLine(lastName.Length);

            if (firstNameLength > lastNameLength)
            {
                Console.WriteLine("First is longer");
            }
            else if (firstNameLength == lastNameLength)
            {
                Console.WriteLine("Samsis");
            }
            else
            {
                Console.WriteLine("Last must be longer");
            }

            Console.WriteLine("This is tab /t & this is a \"quote\" & this is a backslash\\ \n && \a");

            string dudeName = "Bill";
            string nickName = "Pedro";
            
            //if (dudeName == nickName)
            //{
            //    Console.WriteLine("The names are the same.");
            //}
            //else
            //{
            //    Console.WriteLine("The names are different");
            //}

            if (dudeName.Equals(nickName))
                {
                Console.WriteLine("The names are the same");
            }
            else
            {
                Console.WriteLine("The names are not equal");
            }
            









        }
    }
}
