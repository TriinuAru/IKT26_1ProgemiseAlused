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
                //% 2 topib võmalikult palju 2 numbrisse, ja kui jääk on 0 ss on paarisarv (4 - 2 + 2 = 0)
                if (number % 2 == 0)
                {
                    Console.WriteLine(input + " on paarisarv");
                    Console.WriteLine("--");
                    MeetodEven();
                }
                else
                {
                    Console.WriteLine(input + " on paarituarv");
                    Console.WriteLine("--");
                    MeetodOdd();
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
        static void MeetodOdd()
        {
            Console.WriteLine("?? Ikka veel paarituarv!");
        }
        static void MeetodEven()
        {
            Console.WriteLine("?? Ikka veel paarisarv!");
        }
    }
}
