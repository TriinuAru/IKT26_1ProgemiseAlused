namespace IfElseAutod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //kasutada if ja else
            //kirjuta automark
            //valikus on BMW, Audi, Porsche, Fiat ja Skoda
            //kui valitakse Skoda, siis seal sees on uuesti küsimus, et mis mudelit soovid valida (Kodiaq, Octavia)

            Console.WriteLine("Sisestage automark");
            Console.WriteLine("------------------");
            string input = Console.ReadLine();
            if (input == "BMW")
            {
                Console.WriteLine("Sisestasite BMW");
            }
            else if (input == "Audi")
            {
                Console.WriteLine("Sisestasite Audi");
            }
            else if (input == "Porsche")
            {
                Console.WriteLine("Sisestasite Porsche");
            }
            else if (input == "Fiat")
            {
                Console.WriteLine("Sisestasite Fiat");
            }
            else if (input == "Skoda")
            {
                Console.WriteLine("Sisestasite Skoda");
                Console.WriteLine("------------------");
                Console.WriteLine("Sisestage mudel");
                string mudel = Console.ReadLine();
                if (mudel == "Kodiaq")
                {
                    Console.WriteLine("Sisestasite Skoda Kodiaq");
                }
                else if (mudel == "Octavia")
                {
                    Console.WriteLine("Sisestasite Skoda Octavia");
                }
                else
                {
                    Console.WriteLine("Tundmatu mudel");
                }
            }
            else
            {
                Console.WriteLine("Tundmatu automark");
            }
        }
    }
}
