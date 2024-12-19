using System;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace c_ass._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 - Write a program that allows the user to enter a number then print it.
            //Console.WriteLine("enter number please");
            //string? str=Console.ReadLine();
            //int num = int.Parse(str);
            //Console.WriteLine($"your number is{num}");



            //2 - Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 

            //Console.WriteLine("enter number please");
            //string? str = Console.ReadLine();
            //int num = int.Parse(str);
            //Console.WriteLine($"your number is{num}");
            //i entered ahmed it will give exception
            //System.FormatException: 'The input string 'ahmed' was not in a correct format.'


            //3 - Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            //float x = 10.5f;
            //float y = 3.5f;
            //float res = x + y;
            //Console.WriteLine(res);


            //4 - Write C# program that Extract a substring from a given string.
            //string x = "nagat fouad";
            //string y = x.Substring(0,5);
            //Console.WriteLine(y);

            //5 - Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            //int x = 5;
            //int y;
            //y = x;

            //Console.WriteLine($"x is {x}");
            //Console.WriteLine($"y is {y}");
            //x = 10;

            //Console.WriteLine($"x is {x}");
            //Console.WriteLine($"y is {y}");
            //y محستش بالتغيير
            //6 - Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //string x = "nagat";
            //string y;
            //Console.WriteLine(x);
           
            // y = x;
            //Console.WriteLine(y);
            //x = "ali";
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //ليه محسش بالتغيير
            //7 - Write C# program that take two string variables and print them as one variable 
            //Console.WriteLine("enter two strings");
            //string x=Console.ReadLine();
            //string y=Console.ReadLine();
            //string z = x +' ' + y;
            //    Console.WriteLine(z);

            //8 - Write a program that calculates the simple interest given the principal amount,
            //rate of interest, and time. The formula for simple interest is
            //Interest = (principal * rate * time) / 100.
            //Console.WriteLine("enter amount");
            //int principal = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter rate");
            //decimal rate = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("enter time");
            //int time = int.Parse(Console.ReadLine());
            //decimal Interest = (principal * rate * time) / 100;
            //Console.WriteLine(Interest);
            ////Console.WriteLine(" time now");
            ////DateTime time = DateTime.Now;
            ////Console.WriteLine(time.Hour);

            //9 - Write a program that calculates the Body Mass Index(BMI) given a person's weight in kilograms and height in meters. The formula for BMI is
            //BMI = (Weight) / (Height * Height)
            //  Console.WriteLine("enter your weight");
            //decimal weight= decimal.Parse( Console.ReadLine());
            //  Console.WriteLine("enter your height");
            //  decimal height= decimal.Parse(Console.ReadLine());
            //  decimal z = (weight) / (height * height);
            //  Console.WriteLine(z);

            //10 - Write a program that uses the ternary operator to check if the
            //temperature is too hot, too cold, or just good. Assign the result in a
            //variable then display the result. Assume that below 10 degrees is "Just Cold",
            //above 30 degrees is "Just Hot", and anything else is "Just Good".
            //    int tempreture2 = int.Parse(Console.ReadLine());
            // string res=   tempreture2 < 10 ? "Just Cold" : tempreture2 > 30 ? "Just hot":"just good";
            //Console.WriteLine(res);
            //////////////////////////
            //int tempreture = int.Parse(Console.ReadLine());
            //if (tempreture < 10)
            //    Console.WriteLine("Just Cold");
            //else if (tempreture > 30)
            //    Console.WriteLine("Just hot");
            //else 
            //    Console.WriteLine("just good");
            //11 - Write a program that takes the date from the user and displays it in
            //various formats using string interpolation.
            //Ex:
            //            Today’s date : 20 , 11 , 2001
            //Today's date : 20 / 11 / 2001
            //Today's date : 20 – 11 – 2001
            // Console.WriteLine("enter date");
            //DateTime yourdate=DateTime.Parse(Console.ReadLine());
            // Console.WriteLine($"your date is{yourdate: dd,MM,yyyy}");
            // Console.WriteLine($"your date is{yourdate: dd/MM/yyyy}");
            // Console.WriteLine($"your date is{yourdate: dd-MM-yyyy}");
            //12 - What is the output of the following C# code?
            //DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");

            //c)	 The event is on 06/14/2024

            //13 - Which of the following statements is correct about the C#.NET code snippet given below?

            //            int d;
            //            d = Convert.ToInt32(!(30 < 20));

            //            f)	A value 1 will be assigned to d.





            //14 - Which of the following is the correct output for the C# code given below?

            //Console.WriteLine(13 / 2 + " " + 13 % 2);

            //d)	6   1



            //15 - What will be the output of the C# code given below?

            //int num = 1, z = 5;

            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);



            //d)	7 7


        }
    }
}
