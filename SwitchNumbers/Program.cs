namespace SwitchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage üks arvudest: 10, 20 või 30");
            //teha switch, kus esimene case on 10, teine 20, kolmas 30

            int input =  int.Parse(Console.ReadLine());

            switch (input)
            {
                case 10:
                    Console.WriteLine("Sisestasite arvu 10");
                    break;
                case 20:
                    Console.WriteLine("Sisestasite arvu 20");
                    break;
                case 30:
                    Console.WriteLine("Sisestasite arvu 30");
                    break;
                default:
                    Console.WriteLine("Tundmatu väärtus: " + input);
                    break;
            }
        }
    }
}