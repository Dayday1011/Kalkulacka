internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Zadejte pozadovanou operaci (+,-,*,/), prvni a druhy operand ");
        Console.WriteLine("Operace: ");
        var c = Console.ReadLine();
        double a = 0;
        bool integer = false;
        Console.WriteLine("Operand 1: ");
        while (!integer)
        {
            integer = double.TryParse(Console.ReadLine(), out a);
            if (integer)
            {
                break;
            }
            else
            {
                Console.WriteLine("Neni to celociselne cislo");
            }
        }
        double b = 0;
        bool booler = false;
        Console.WriteLine("Operand 2: ");
        while (!booler)
        {
            booler = double.TryParse(Console.ReadLine(), out b);
            if (booler)
            {
                break;
            }
            else
            {
                Console.WriteLine("Neni to desetinne cislo");
            }
        }

        switch (c)
        {
             case "+":
                 Console.WriteLine("Vysledek operace je: "+ (a + b));
                 break;
             case "-":
                 Console.WriteLine("Vysledek operace je: " + (a - b));
                 break;
             case "*":
                 Console.WriteLine("Vysledek operace je: " + (a * b));
                 break;
             case "/":
                if (b != 0)
                {
                    Console.WriteLine("Vysledek operace je: " + (a / b));
                }
                else
                {
                    Console.WriteLine(" Cislo nemuze byt nulou");   
                }
                break;
             default:
                 Console.WriteLine("Chyba operandu");
                 break;
        }
    }
}