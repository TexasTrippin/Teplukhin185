using System;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What's your weight in kg?");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("What's your height in meters?");
            double height = double.Parse(Console.ReadLine());

            double bodyMassIndex = weight / (height * height);

            bool isTooLow = bodyMassIndex <= 18.5;
            bool isNormal = bodyMassIndex > 18.5 && bodyMassIndex < 25;
            bool isAboveNormal = bodyMassIndex >= 25 && bodyMassIndex <= 30;
            bool isTooFat = bodyMassIndex > 30;

            bool isFat = isAboveNormal || isTooFat;
            //if (isFat == true)
            if (isFat)
            {
                Console.WriteLine("You'd better lose some weight");

            }
            else
            {
                Console.WriteLine("Oh, you're in a good shape.");
            }
            //if(isFat == false)
            if (!isFat)
            {
                Console.WriteLine("you dfsadssda");
            }
            if (isTooLow)
            {
                Console.WriteLine("233233223");

            }

            else if (isNormal)
            {
                Console.WriteLine("55255255553");

            }
            else if (isAboveNormal)
            {
                Console.WriteLine("1112444242423");

            }
            else
            {
                Console.WriteLine("fsffsfs");
            }

            if (isFat || isTooFat)
            {
                Console.WriteLine("sdadsaasdsda");


            }
            string description = age > 18 ? "fgssgsgf" : "fsfsfsaf";

           // if (age > 18)
          //  {
          //      description = "You can drink alcohol";
          //  }

        //    else
          // {
          //      description = "You should get a bit older";
          //  }
        }
    }
}
