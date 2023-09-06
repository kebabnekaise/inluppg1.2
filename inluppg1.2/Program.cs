using System;

namespace inluppg
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sätt bakgrundsfärgen till blått. Färgen anges av ConsoleColor
            Console.BackgroundColor = ConsoleColor.Blue;
            //Gör så att hela bakgrunden tar färgen blå
            Console.Clear();

            //Skriv ut texten. Här används \n för att skapa en ny rad
            Console.WriteLine(":( \nDatorn verkar ha kraschat buhu");

            Console.ReadKey();
        }
    }
}