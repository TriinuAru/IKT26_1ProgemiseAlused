using System.Numerics;

namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal to binary");

            Console.WriteLine("Sisesta number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string binary = "";

            while (num > 0)
            {
                int reminder = num % 2;
                binary = reminder + binary;
                num /= 2;
            }

            Console.WriteLine("Binnar: {0}", binary);
        }
    }
}
