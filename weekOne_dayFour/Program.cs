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

            //
            //
            //DOT CONCAT WITH SPACE BETWEEN NAMES
            //IF THERE WAS A THIRD NAME FOLLOW FORMAT OF chessName
            Console.WriteLine("Enter your first name: ");
            string golfName = Console.ReadLine();
            golfName = golfName.Trim();

            Console.WriteLine("Enter your last name: ");
            string chessName = Console.ReadLine();
            chessName = " " + chessName.Trim();

            string fullName = string.Concat(golfName, chessName);

            //Console.WriteLine("Your name is " + golfName + " " + chessName);

            Console.WriteLine("Your name is " + " " + fullName);


            Console.WriteLine("Hey, can you guess the animal I saw? \nHint: It's the opposite of dog");
            string animalGuess = Console.ReadLine().ToLower();

            switch (animalGuess)
            {
                case "cat":
                    Console.WriteLine("You guessed correctly!");
                    break;
                default:
                    Console.WriteLine("You guessed incorrectly...");
                    break;
            }





        }
    }
}
