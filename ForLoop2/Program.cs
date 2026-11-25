namespace ForLoop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kõrgus (vähemalt 3):");

            if (!int.TryParse(Console.ReadLine(), out int height) || height < 3)
            {
                Console.WriteLine("Sisesta täisarv:");
                return;
            }

            for (int row = 1; row <= height; row++)
            {
                for (int empty = 1; empty <= height - row; empty++)
                {
                    Console.Write(" ");
                }

                for (int loc = 1; loc <= 2 * row - 1; loc++)
                {
                    bool thing = (row == 2 && loc == 1) ||
                        (row == height - 1 && loc == 2 * row - 1) ||
                        (row == height && loc == row);

                    Console.ForegroundColor = thing
                        ? ConsoleColor.DarkRed : ConsoleColor.DarkGreen;

                    //ternary operaator: muutuja ? (kaks valikut peale seda)
                    //kui esimene valik on vale, siis vali teine e kui ei tule "o" pane *
                    Console.Write(thing ? "O" : "*");
                }
                Console.WriteLine();
            }

            for (int row = 1; row <= 2; row++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                for (int empty = 1; empty < height; empty++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("*");
            }
            Console.ResetColor();
        }
    }
}
