namespace IfElseOddAndEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //konsool küsib numbrit
            //number tuleb ära parsida
            //if ja else juures toimub kontroll, kas on paaris või paaritu number
            Console.WriteLine("Sisestage number");
            Console.WriteLine("--");

            string input = Console.ReadLine();
            Console.WriteLine("--");
            if (int.TryParse(input, out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(input + " on paarisarv");
                }
                else
                {
                    Console.WriteLine(input + " on paaritu arv");
                }
            }
            else if (input == "meow")
            {
                Console.WriteLine("m- meow..? :3");
            }
            else
            {
                Console.WriteLine("Tegemist pole numbriga");
            }
        }
    }
}
