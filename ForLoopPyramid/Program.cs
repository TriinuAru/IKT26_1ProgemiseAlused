namespace ForLoopPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Püramiid");
            Console.WriteLine("--");
            Console.WriteLine("\n");
            Console.WriteLine("Sisesta ridade arv:");

            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                for (int n = 0; n < input - i; n++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("**");
                }
                Console.WriteLine("*");
            }
        }
    }
}
