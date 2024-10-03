using System;

namespace EnkelKalkylator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("En Simpel Kalkylator");

            // Ange giltig operation
            Console.WriteLine("Ange operation (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;

            // Ange och testa att i sin tur skriva det första talet
            double num1 = ReadDouble("\nAnge första talet: ");

            // Ange och testa att i sin tur skriva det andra talet
            double num2 = ReadDouble("Ange andra talet: ");

            double result = 0;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0) // Här så handskas vi i sin tur med division med noll alltså zero
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Inkorrekt: Division med siffran 0 alltså zero är förbjuden.");
                        return; // Om division med siffran noll förekommer avsluta programmet
                    }
                    break;
                default:
                    Console.WriteLine("Ogiltig operation.");
                    return; // Om istället en så kallad ogiltig operation skrivs in avsluta programmet 
            }

            Console.WriteLine($"Resultat: {result}");
            Console.ReadKey();
        }

        // Ett tillvägagångssätt för att i sin tur läsa in ett tal samt i sin tur validera det.
        static double ReadDouble(string prompt)
        {
            double number;
            while (true)
            {
                Console.WriteLine(prompt);
                if (double.TryParse(Console.ReadLine(), out number))
                {
                    return number; //  Återsänd talet om inmatningen i sin tur visar sig vara giltig, alltså korrekt. 
                }
                Console.WriteLine("Ogiltig inmatning, försök en gång till .");
            }
        }
    }
}




  

