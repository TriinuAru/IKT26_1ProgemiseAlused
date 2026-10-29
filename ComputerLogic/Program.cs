namespace ComputerLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            double calc1 = 3 + 8 / (4 - 2) * 4;
            double calc2 = 3 + 8 / 4 - 2 * 4;
            double calc3 = (3 + 8) / (4 - 2) * 4;
            //kui tahad, et võtaks arvesse komakohta, siis pane lõppu nr .0
            double calc4 = (3.0 + 8.0) / (4.0 - 2.0) * 4.0;

            Console.WriteLine("3 + 8 / (4 - 2) * 4 = " + calc1);
            Console.WriteLine("3 + 8 / 4 - 2 * 4 = " + calc2);
            Console.WriteLine("(3 + 8) / (4 - 2) * 4 = " + calc3);
            Console.WriteLine("(3 + 8) / (4 - 2) * 4 = " + calc4);
        }
    }
}
