namespace SwitchLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meetodi valimine");


            //tee kolm meetodit, mis teevad järgmist:
            //1. ütleb auh
            //2. ütleb tahan magada
            //3. ütleb tahan õppida
            //need tuleb esile kutsuda numbri valikuga
            //tuleb kasutada switchi
            //tuleb teha menüü, kus kasutaja saab valida, millist meetodit ta tahab esile kutsuda

            Console.WriteLine("Mis sa teha tahad? Sisesta vastav number.");
            Console.WriteLine("1) Haukuda");
            Console.WriteLine("2) Magada");
            Console.WriteLine("3) Õppida");
            Console.WriteLine("--");

            Console.WriteLine(" ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            switch (input)
            {
                case 1:
                    MeetodAuh();
                    break;
                case 2:
                    MeetodMagamine();
                    break;
                case 3:
                    MeetodÕppimine();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("ERROR.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }
        }
        static void MeetodAuh()
        {
            Console.WriteLine("Auh! Sa tahad haukuda!!");
        }
        static void MeetodMagamine()
        {
            Console.WriteLine("zzZZZ... Sa tahad magada.");
        }
        static void MeetodÕppimine()
        {
            Console.WriteLine("..? Sa tahad õppida?");
        }
    }
}