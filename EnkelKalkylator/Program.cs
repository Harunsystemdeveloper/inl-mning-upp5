using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enkel Kalkylator");
        Console.WriteLine("Ange första siffran:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ange operator (+, -, *, /):");
        string op = Console.ReadLine();

        Console.WriteLine("Ange andra siffran:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultat = 0;

        switch (op)
        {
            case "+":
                resultat = num1 + num2;
                break;
            case "-":
                resultat = num1 - num2;
                break;
            case "*":
                resultat = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                {
                    resultat = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Fel: Division med noll är inte tillåten.");
                }
                break;
            default:
                Console.WriteLine("Ogiltig operator.");
                break;
        }

        Console.WriteLine($"Resultat: {resultat}");
    }
}

