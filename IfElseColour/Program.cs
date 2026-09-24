namespace IfElseColour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Teha if ja else konsoolirakendus, kus kontrollitakse stringi abil värvi vastavust.");
            Console.WriteLine("Värvide valikuks on: red, blue, green ja white.");
            Console.WriteLine("Peab käsitlema juhust, kus vastaja ei sisesta eelpool sisestatud värvi.");

            Console.WriteLine("Vali värv: punane, sinine, roheline, valge");
            string input = Console.ReadLine();
            if (input == "punane")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Valisite punase");
            }
            else if (input == "sinine")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Valisite sinise");
            }
            else if (input == "roheline")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Valisite rohelise");
            }
            else if (input == "valge")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Valiste valge");
            }
            else
            {
                Console.WriteLine("Tundmatu värv");
            }
        }
    }
}
