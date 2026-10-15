namespace SwitchBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");

            //esimese koondtulemuse puhul on number vahemikus
            //0-100
            //101-200
            //201-300
            //kasutada switchi
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case >= 0 and <= 100:
                Console.WriteLine("Sisestasite numbri vahemikus 0 kuni 100");
                    break;

                case > 100 and <= 200:
                    Console.WriteLine("Sisestasite numbri vahemikus 101 kuni 200");
                    break;

                case > 200 and <= 300:
                    Console.WriteLine("Sisestasite numbri vahemikus 201 kuni 300");
                    break;

                default:
                    Console.WriteLine("Tundmatu väärtus: " + input);
                    break;
            }
        }
    }
}
