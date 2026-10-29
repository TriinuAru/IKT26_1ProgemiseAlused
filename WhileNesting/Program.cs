namespace WhileNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                int s = 2;
                while (s <= 5)
                {
                    Console.Write(s + "  ");
                    s++;
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}
