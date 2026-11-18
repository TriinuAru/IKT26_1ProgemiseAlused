namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Korrutustabel");

            int i, k, n;

            Console.WriteLine("Sisesta tabelisse number, mis on viimane korrutis:");
            Console.WriteLine("--");

            n = int.Parse(Console.ReadLine());
            Console.Write("\n");

            for (k = 1; k <= 10; k++)
            {
                for (i = 1; i <= n; i++)
                {
                    Console.Write(k + "x" + i + " = " + k * i);
                    if (i != n)
                    {
                        Console.Write(",  ");
                    }
                }
                Thread.Sleep(250);
                Console.Write("\n");
            }
        }
    }
}
