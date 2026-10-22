namespace SwitchToo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valige tegevus:");
            Console.WriteLine("1) korrutamine");
            Console.WriteLine("2) vanus");
            Console.WriteLine("3) kiisu");
            short input = short.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Sisestage esimene arv:");
                    float esimeneNr = float.Parse(Console.ReadLine());
                    Console.WriteLine("Sissta teine number korrutisse:");
                    float teineNr = float.Parse(Console.ReadLine());
                    Console.WriteLine(esimeneNr + " * " + teineNr + " = " + esimeneNr * teineNr);
                    break;

                case 2:
                    Console.WriteLine("Sisestage oma vanus (numbriga):");
                    int vanus = int.Parse(Console.ReadLine());
                    Console.WriteLine("Te olete " + vanus + " aastat vana!");
                    break;

                case 3:
                    MeetodKiisu();
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
        static void MeetodKiisu()
        {
            Console.WriteLine("Mjäu!");
        }
    }
}
