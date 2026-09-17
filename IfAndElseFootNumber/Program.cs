namespace IfAndElseFootNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma jalanumber");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                if (number < 30)
                {
                    Console.WriteLine("Liiga väike suurus");
                }
                if (number >= 30 && number <= 33)
                {
                    Console.WriteLine("Jalasuurus on vahemikus 30-33");
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                if (number >= 34 && number <= 38)
                {
                    Console.WriteLine("Jalasuurus on vahemikus 34 - 38");
                }
                if (number >= 39 && number <= 44)
                {
                    Console.WriteLine("Jalasuurus on vahemikus 39 - 44");
                }
                if (number >= 45 && number <= 49)
                {
                    Console.WriteLine("Jalanumber on vahemikus 45 - 49");
                }
                if (number > 48)
                {
                    Console.WriteLine("Liiga suur suurus");
                }
            }
            else
            {
                Console.WriteLine("Number, palun.");
            }

        }
    }
}
