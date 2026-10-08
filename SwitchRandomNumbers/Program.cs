namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täringu viskamise mäng");
            Console.WriteLine("--");

            //Random genereerib iga kord suvalise numbri 1-st 6-ni
            int cube = new Random().Next(1, 7);
            //Kasuta switchi ja iga juhtum tuleb ära printida, mis number tuli
            Thread.Sleep(1000);

            switch (cube)
            {
                case 1:
                    Console.WriteLine("Veeretatud number on 1");
                    break;
                case 2:
                    Console.WriteLine("Veeretatud number on 2");
                    break;
                case 3:
                    Console.WriteLine("Veeretatud number on 3");
                    break;
                case 4:
                    Console.WriteLine("Veeretatud number on 4");
                    break;
                case 5:
                    Console.WriteLine("Veeretatud number on 5");
                    break;
                case 6:
                    Console.WriteLine("Veeretatud number on 6");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
