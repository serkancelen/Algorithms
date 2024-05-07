using System;

class Program
{
    static void Main(string[] args)
    {
        bool devam = true;

        while (devam)
        {
            Console.WriteLine("Which algorithm would you like to use?");
            Console.WriteLine("1. Interior Angles of a Triangle");
            Console.WriteLine("2. Single or Double?");
            Console.WriteLine("3. Midterm and Final Grade Calculation");
            Console.WriteLine("4. Units Digit");
            Console.WriteLine("5. Discount Calculation");
            Console.WriteLine("6. Down From 10");
            Console.WriteLine("7. Find positive integer divisors of a number");
            Console.WriteLine("8. Find odd numbers between two numbers");
            Console.WriteLine("9. Calculate the circumference of a circle");
            Console.WriteLine("10. Find total characters in a name");
            Console.WriteLine("11. Find age with a year");
            Console.WriteLine("12. Calculate square root and absolute value of a number");
            Console.WriteLine("13. Generate a random number and check if it's odd or even");
            Console.WriteLine("14. Calculate factorial of a number");
            Console.WriteLine("15. Generate 5 random even numbers");
            Console.WriteLine("16. Play the number guessing game");
            Console.WriteLine("0. Exit");

            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    TriangleInteriorAngles();
                    break;
                case 2:
                    SingleOrDouble();
                    break;
                case 3:
                    MidtermFinalGradeCalculation();
                    break;
                case 4:
                    UnitsDigit();
                    break;
                case 5:
                    DiscountCalculator();
                    break;
                case 6:
                    DownFromTen();
                    break;
                case 7:
                    FindPositiveIntegerDivisors();
                    break;
                case 8:
                    FindOddNumbersBetween();
                    break;
                case 9:
                    CalculateCircleCircumference();
                    break;
                case 10:
                    FindChar();
                    break;
                case 11:
                    FindAge();
                    break;
                case 12:
                    CalculateSquareRootAndAbsoluteValue();
                    break;
                case 13:
                    RandomNumberAndOddEvenCheck();
                    break;
                case 14:
                    CalculateFactorial();
                    break;
                case 15:
                    GenerateRandomEvenNumbers();
                    break;
                case 16:
                    PlayNumberGuessingGame();
                    break;
                case 0:
                    devam = false;
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }
    }

    static void TriangleInteriorAngles()
    {
        Console.WriteLine("Enter First Angle:");
        double ang1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Second Angle:");
        double ang2 = double.Parse(Console.ReadLine());

        double ang3 = 180 - (ang1 + ang2);
        Console.WriteLine("Third Angle is: " + ang3);
    }

    static void SingleOrDouble()
    {
        Console.WriteLine("Enter the Number:");
        int num = int.Parse(Console.ReadLine());

        int rem = num % 2;

        if (rem != 0)
        {
            Console.WriteLine("SINGLE");
        }
        else
        {
            Console.WriteLine("DOUBLE");
        }
    }

    static void MidtermFinalGradeCalculation()
    {
        Console.WriteLine("Enter the Midterm Grade:");
        double mid = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Final Grade:");
        double final = double.Parse(Console.ReadLine());

        double grad = (mid * 0.4) + (final * 0.6);

        if (grad > 60)
        {
            Console.WriteLine("Congratulations! You Passed: " + grad);
        }
        else
        {
            Console.WriteLine("Sorry, you failed: " + grad);
        }
    }

    static void UnitsDigit()
    {
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());

        int uni = num % 10;

        Console.WriteLine("The units digit of the number is: " + uni);
    }

    static void DiscountCalculator()
    {
        Console.WriteLine("Enter the Price:");
        double price = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Discount:");
        double disc = double.Parse(Console.ReadLine());

        double totdis = (price * disc) / 100;
        double newpri = price - totdis;
        Console.WriteLine("New Price is: " + newpri);
    }

    static void DownFromTen()
    {
        Console.WriteLine("Counting down from 10...");

        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Counting down completed.");
    }

    static void FindPositiveIntegerDivisors()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Positive integer divisors of the number:");
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    static void FindOddNumbersBetween()
    {
        Console.WriteLine("Enter the first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Odd numbers between " + num1 + " and " + num2 + ":");

        for (int i = num1; i <= num2; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
    static void CalculateCircleCircumference()
    {
        Console.WriteLine("Enter the radius of the circle");
        double radius = double.Parse(Console.ReadLine());

        double circumference = 2 * Math.PI * radius;

        Console.WriteLine("The circumference of the circle is: " + circumference);
    }

    static void FindChar()
    {
        Console.WriteLine("Enter the Name");
        string name = Console.ReadLine();

        string newname = name.Trim().ToUpper();
        int count = newname.Length;

        Console.WriteLine("Entered Name : " + newname);
        Console.WriteLine("Count of the Name : " + count);
    }

    static void FindAge()
    {
        Console.WriteLine("Enter the Year");
        int year = int.Parse(Console.ReadLine());
        DateTime currentDate = DateTime.Now;
        int currentYear = currentDate.Year;

        int age = currentYear - year;
        Console.WriteLine("Your age is : " + age);

    }

    static void CalculateSquareRootAndAbsoluteValue()
    {
        Console.WriteLine("Enter a Number");
        double number = double.Parse(Console.ReadLine());   
        double squareRoot = Math.Sqrt(number);
        double absoluteValue = Math.Abs(number);
        Console.WriteLine("Square root of the number: " + squareRoot);
        Console.WriteLine("Absolute value of the number: " + absoluteValue);
    }

    static void RandomNumberAndOddEvenCheck()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101);

        Console.WriteLine("Generated random number: " + randomNumber);

        if (randomNumber % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
    }

    static void CalculateFactorial()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        long factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("Factorial of " + number + " is: " + factorial);
    }
    static void GenerateRandomEvenNumbers()
    {
        Random random = new Random();
        Console.WriteLine("5 random even number: ");
        for (int i = 0; i<5; i++)
        {
            int rndNum = random.Next(1, 101);
            while (rndNum % 2 != 0)
            {
                rndNum = random.Next(1, 101);
            }
            Console.WriteLine(rndNum);
        }

    }
    static void PlayNumberGuessingGame()
    {
        Random random = new Random();
        int targetNumber = random.Next(1, 101);

        bool correctGuess = false;

        Console.WriteLine("The computer has chosen a number. Make your guess (between 1 and 100).");

        while (!correctGuess)
        {
            Console.Write("Your guess: ");
            int guess = int.Parse(Console.ReadLine());

            if (guess < targetNumber)
            {
                Console.WriteLine("Your guess is too small. Increase your guess.");
            }
            else if (guess > targetNumber)
            {
                Console.WriteLine("Your guess is too large. Decrease your guess.");
            }
            else
            {
                Console.WriteLine("Congratulations, you guessed it right!");
                correctGuess = true;
            }
        }
    }
}
