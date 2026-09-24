namespace IfElseMethodCall
{
    internal class Program
    {
        //main on meetod, mis läheb alati esimesena tööle
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("Hello, World!");
            //kasutada if ja else
            //kui kasutaja soovib, siis saab meetodid ta välja kutsuda
            Console.WriteLine("Ütle meow.");
            string Input = Console.ReadLine();

            if (Input == "meow")
            {
                HelloMethod();
            }
            else
            {
                Console.WriteLine(">:(");
            }
        }

        //teha teine meetod siia ja nimeks on sellel HelloMethod
        static void HelloMethod()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Hello Kitty! :3");
        }
    }
}
