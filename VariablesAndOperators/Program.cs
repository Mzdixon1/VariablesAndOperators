using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing new firstname variable
            string name = "Mike";
            //Printing the value of FirstName to the console
            Console.WriteLine(name);

            name = "Daniel";
            Console.WriteLine(name);

            string birthMonth = "February";
            Console.WriteLine(birthMonth);

            //int age = 65;
            //String why = "becuase I said so";
            //char firstInitial = 'L';

            ////Floating point types
            //float floatNumber = 2.164403304897294849383961032f;
            //    Console.WriteLine(floatNumber);

            //double doubleNumber = 2.164403304897294849383961032d;
            //Console.WriteLine(doubleNumber);

            //decimal decimalNumber = 2.164403304897294849383961032m;
            //Console.WriteLine(decimalNumber);

            ////Jessica is 23 years old.
            ////Sam is 47.
            ////Jessica is younger than Sam.
            //int JessicaAge = 23;
            //int SamAge = 47;
            //Console.WriteLine(JessicaAge < SamAge);

            // At a restaurant, Mike and his three friends decided to divide the bill evenly.If each person paid $13 then what was the total bill?

            //Console.WriteLine("What is the name on the reservation");
            //string reserveName = Console.ReadLine();

            //Console.WriteLine("How many people in your party?");
            //int numberOfPeople = int.Parse(Console.ReadLine());

            //double amountEach = 13.53d;

            //double totalBill = numberOfPeople * amountEach;
            //Console.WriteLine("Reservation: name" + "reserveName"); //concatenate
            //Console.WriteLine("Total due: $" + totalBill);

            //Lisa is cooking muffins.The recipe calls for 7 cups of sugar.She has already put in 2 cups.How many more cups does she need to put in?

            int totalCups = 7;
            int cupsAlreadyAdded = 2;
            Console.WriteLine(totalCups - cupsAlreadyAdded);

            //            Your client needs to print receipts when donations are received. Donations are received in ones, fives, tens, twenties, fifties, hundreds, and quarters. Ask the user how many of each denomination are being donated, and print a receipt. Your client wants the following information printed on the receipts:
            //Name of Donor
            //Address of Donor
            //Email of Donor
            //Fiscal Year
            //Donation Amount
          
            Console.WriteLine("What is your first and last name?");
            Console.ReadLine();
            Console.WriteLine("What is your address?");
            Console.ReadLine();
            Console.WriteLine("What is your email address?");
            Console.ReadLine();
            Console.WriteLine("How much are you donating?");
            Console.ReadLine();
            double donationAmount = 
            string = ("ones" + "fives" + "tens" + "twenty" + "fifties" + "hundreds" + "quarters");

        }
    }
}
