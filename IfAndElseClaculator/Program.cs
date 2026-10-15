namespace IfAndElseClaculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number:");
            float Nr1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Kasuta tingmärki *, /, +, -");
            string Mark = Console.ReadLine();

            Console.WriteLine("Sisesta teine number:");
            float Nr2 = float.Parse(Console.ReadLine());
            Console.Clear();

            if (Mark == "*")
            {
                Console.WriteLine(Nr1 + Mark + Nr2 + " = " + Nr1 * Nr2);
            }
            else if (Mark == "/")
            {
                if (Nr2 != 0)
                {
                    Console.WriteLine(Nr1 + Mark + Nr2 + " = " + Nr1 / Nr2);
                }
                else
                {
                    Console.WriteLine("Nulliga ei saa jagada");
                }
            }
            else if (Mark == "+")
            {
                Console.WriteLine(Nr1 + Mark + Nr2 + " = " + (Nr1 + Nr2));
            }
            else if (Mark == "-")
            {
                Console.WriteLine(Nr1 + Mark + Nr2 + " = " + (Nr1 - Nr2));
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
