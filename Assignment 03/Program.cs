using System;

namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region //1
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("You entered: " + number);
            //#endregion


            //2

            //Console.Write("Enter a string: ");
            //string str = Console.ReadLine();

            //try
            //{
            //    int number = int.Parse(str);
            //    Console.WriteLine("Converted number: " + number);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Error: The string contains non-numeric characters and cannot be converted.");
            //}


            //3

            //Console.Write("Enter first number: ");
            //float num1 = float.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //float num2 = float.Parse(Console.ReadLine());

            //float result = num1 + num2;
            //Console.WriteLine("The result of the addition is: " + result);



            //4

            //Console.Write("Enter a string: ");
            //string str = Console.ReadLine();

            //Console.Write("Enter start index: ");
            //int startIndex = int.Parse(Console.ReadLine());

            //Console.Write("Enter length: ");
            //int length = int.Parse(Console.ReadLine());

            //string substring = str.Substring(startIndex, length);
            //Console.WriteLine("Extracted substring: " + substring);


            //5


            //Console.Write("Enter value for 'a': ");
            //int a = int.Parse(Console.ReadLine());

            //int b = a;
            //Console.WriteLine($"Initial value of a: {a}, b: {b}");

            //Console.Write("Enter new value for 'b': ");
            //b = int.Parse(Console.ReadLine());

            //Console.WriteLine("Value of a: " + a); // a remains unchanged
            //Console.WriteLine("Value of b: " + b); // b is modified  


            //6


            //Console.Write("Enter array size: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] arr1 = new int[size];
            //Console.WriteLine("Enter array elements for arr1:");

            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element {i}: ");
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}

            //int[] arr2 = arr1;
            //Console.WriteLine("Enter a new value for the first element of arr2: ");
            //arr2[0] = int.Parse(Console.ReadLine());

            //Console.WriteLine("arr1[0]: " + arr1[0]); // arr1[0] is modified
            //Console.WriteLine("arr2[0]: " + arr2[0]); // arr2[0] is also modified


            //7


            //Console.Write("Enter first string: ");
            //string str1 = Console.ReadLine();

            //Console.Write("Enter second string: ");
            //string str2 = Console.ReadLine();

            //string combined = str1 + " " + str2;
            //Console.WriteLine("Combined string: " + combined);


            //8


            //Console.Write("Enter principal amount: ");
            //double principal = double.Parse(Console.ReadLine());

            //Console.Write("Enter rate of interest: ");
            //double rate = double.Parse(Console.ReadLine());

            //Console.Write("Enter time in years: ");
            //double time = double.Parse(Console.ReadLine());

            //double interest = (principal * rate * time) / 100;
            //Console.WriteLine("Simple Interest: " + interest);



            //9


            //Console.Write("Enter weight in kilograms: ");
            //double weight = double.Parse(Console.ReadLine());

            //Console.Write("Enter height in meters: ");
            //double height = double.Parse(Console.ReadLine());

            //double bmi = weight / (height * height);
            //Console.WriteLine("BMI: " + bmi);


            //10

            //Console.Write("Enter the temperature: ");
            //int temperature = int.Parse(Console.ReadLine());

            //string result = temperature < 10 ? "Just Cold" :
            //                temperature > 30 ? "Just Hot" : "Just Good";

            //Console.WriteLine("The temperature is: " + result);


            //11

            //Console.Write("Enter day (dd): ");
            //int day = int.Parse(Console.ReadLine());

            //Console.Write("Enter month (mm): ");
            //int month = int.Parse(Console.ReadLine());

            //Console.Write("Enter year (yyyy): ");
            //int year = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Today's date: {day}, {month}, {year}");
            //Console.WriteLine($"Today's date: {day} / {month} / {year}");
            //Console.WriteLine($"Today's date: {day} - {month} - {year}");



            //12


            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //string result = (number % 3 == 0 && number % 4 == 0) ? "Yes" : "No";
            //Console.WriteLine(result);



            //13

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //string result = number < 0 ? "negative" : "positive";
            //Console.WriteLine(result);


            //14


            //Console.Write("Enter three integers separated by spaces: ");
            //string[] inputs = Console.ReadLine().Split();

            //int num1 = int.Parse(inputs[0]);
            //int num2 = int.Parse(inputs[1]);
            //int num3 = int.Parse(inputs[2]);

            //int max = Math.Max(num1, Math.Max(num2, num3));
            //int min = Math.Min(num1, Math.Min(num2, num3));

            //Console.WriteLine($"Max element = {max}");
            //Console.WriteLine($"Min element = {min}");



            //15



            //Console.Write("Enter an integer: ");
            // int number = int.Parse(Console.ReadLine());

            // string result = (number % 2 == 0) ? "Even" : "Odd";
            // Console.WriteLine(result);


            //16




            //Console.Write("Enter a character: ");
            //char ch = char.ToLower(Console.ReadKey().KeyChar);
            //Console.WriteLine();

            //if ("aeiou".Contains(ch))
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else
            //{
            //    Console.WriteLine("Consonant");
            //}


            //17


            //Console.Write("Enter month number (1-12): ");
            //int month = int.Parse(Console.ReadLine());

            //int days;
            //if (month == 2)
            //{
            //    days = 28; // Consider a non-leap year
            //}
            //else if (month == 4 || month == 6 || month == 9 || month == 11)
            //{
            //    days = 30;
            //}
            //else
            //{
            //    days = 31;
            //}

            //Console.WriteLine($"Days in Month: {days}");



            //18


            //Console.Write("Enter the first number: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter the operator (+, -, *, /): ");
            //char op = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //Console.Write("Enter the second number: ");
            //double num2 = double.Parse(Console.ReadLine());

            //double result = 0;

            //switch (op)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        if (num2 != 0)
            //            result = num1 / num2;
            //        else
            //            Console.WriteLine("Division by zero is not allowed.");
            //        return;
            //    default:
            //        Console.WriteLine("Invalid operator.");
            //        return;
            //}

            //Console.WriteLine($"Result: {result}");


            //19


            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Multiplication Table of {number}:");
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write($"{number * i} ");
            //}
            //Console.WriteLine();


            //20


            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Even numbers between 1 and {number}:");
            //for (int i = 2; i <= number; i += 2)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine();


            //21

            //Console.Write("Enter the base number: ");
            //int baseNum = int.Parse(Console.ReadLine());

            //Console.Write("Enter the exponent: ");
            //int exponent = int.Parse(Console.ReadLine());

            //int result = 1;
            //for (int i = 0; i < exponent; i++)
            //{
            //    result *= baseNum;
            //}

            //Console.WriteLine($"{baseNum} ^ {exponent} = {result}");


            //22


            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //int reversed = 0;
            //while (number != 0)
            //{
            //    int digit = number % 10;
            //    reversed = reversed * 10 + digit;
            //    number /= 10;
            //}

            //Console.WriteLine($"Reversed number: {reversed}");




            //23


        //    Console.Write("Input starting number of range: ");
        //    int start = int.Parse(Console.ReadLine());

        //    Console.Write("Input ending number of range: ");
        //    int end = int.Parse(Console.ReadLine());

        //    Console.WriteLine($"The prime numbers between {start} and {end} are:");
        //    for (int num = start; num <= end; num++)
        //    {
        //        if (IsPrime(num))
        //        {
        //            Console.Write($"{num} ");
        //        }
        //    }
        //    Console.WriteLine();
        //}

        //static bool IsPrime(int number)
        //{
        //    if (number < 2)
        //        return false;

        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0)
        //            return false;
        //    }
        //    return true;


        }
    }
}
