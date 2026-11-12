namespace ForLoopTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tärnidest kolmnurk e poolik püramiid");
            Console.WriteLine("--");
            Console.WriteLine("\n\n");
            Console.WriteLine("Sisesta ridade arv:");

            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                for (int n = 0; n < i; n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
        }
    }
}
