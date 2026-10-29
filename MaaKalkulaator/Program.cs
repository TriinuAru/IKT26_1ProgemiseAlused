namespace MaaKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            double coinD = 25.75; //mm
            double earthR = 6378000000; //mm
            double calc = (earthR * 2 * Math.PI) / coinD;
            Console.WriteLine("Kahe euroseid münte läheb ümber Maa:");
            Console.WriteLine("(6378000000 * 2 * PI) / 25.75 =");
            Console.WriteLine(calc + " tk");
        }
    }
}
