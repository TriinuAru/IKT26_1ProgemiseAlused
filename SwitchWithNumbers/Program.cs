namespace SwitchWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage number");
            int number = int.Parse(Console.ReadLine());
            //Teha switch rakendus, kus on kolm case'i

            switch (number)
            {
                case 1:
                    Console.Beep();
                    Console.WriteLine("Sisestasite numbri 1");
                    break;
                case 2:
                    Console.Beep();
                    Thread.Sleep(1000);
                    Console.Beep();
                    Console.WriteLine("Sisestasite numbri 2");
                    break;
                case 3:
                    Console.Beep();
                    Thread.Sleep(1000);
                    Console.Beep();
                    Thread.Sleep(1000);
                    Console.Beep();
                    Console.WriteLine("Sisestasite numbri 3");
                    break;

                default:
                    Console.WriteLine("Sisestasite tundmatu väärtuse");
                    break;
            }
        }
    }
}
