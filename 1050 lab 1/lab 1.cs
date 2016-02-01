using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1050_lab_1
{
    class Program
    {
        static void Main(string[] args)
        {// Compute user name
            System.Console.WriteLine("what is your first name");
            string FirstName = System.Console.ReadLine();
            System.Console.WriteLine("what is your middle inital");
            string Middleinit = System.Console.ReadLine();
            System.Console.WriteLine("what is your Last name");
            string Lastname = System.Console.ReadLine();
            
          // compute user voter eligibility
            bool correctAge;
            System.Console.WriteLine("what is your age");
            int age = int.Parse(System.Console.ReadLine());
            correctAge = age >= 18;
            System.Console.WriteLine("Are you a U.S. citizen? (y/n)");
            string answer = System.Console.ReadLine();
            bool isCitizen;
            isCitizen = answer == "y";
            bool isComputeus;
            isComputeus = isCitizen && correctAge;
            

          // Compute height
            int heightFeet;
            double heightInches;
            double totalHeightCM;
            System.Console.WriteLine("what is your height in feet? IE 6ft 1 1/4 would be 6");
            heightFeet = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("what is your height in inches? IE 6ft 1 1/14 would be 1.25");
            heightInches = double.Parse(System.Console.ReadLine());

            totalHeightCM = (((heightFeet * 12) + heightInches) * 2.54);
            System.Console.WriteLine(FirstName + " " + Middleinit + ". " + Lastname);
            System.Console.WriteLine("citizenship is " + isComputeus);
            System.Console.WriteLine("Total Height in CM is " + totalHeightCM);
            System.Console.ReadKey();
            }
    }
}
