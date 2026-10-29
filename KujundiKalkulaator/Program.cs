namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ring on ruudu sees.");
            Console.WriteLine("--");

            double ringR = 3;
            double ringD = ringR * 2;
            double ruutP = ringD * 4;
            double ruutS = Math.Pow(ringD, 2);

            Console.WriteLine("Ringi raadius on " + ringR + " ühikut"); //r
            Console.WriteLine("--");
            Console.WriteLine("Ringi diameeter on " + ringR + " * 2" + " = " + ringD + " ühikut"); //d
            Console.WriteLine("--");
            Console.WriteLine("Ruudu pindala on " + ringD + " * " + ringD + " = " + ruutS + " ühikut ruudus"); //S
            Console.WriteLine("--");
            Console.WriteLine("Ruudu ümbermõõt on " + ringD + " * 4" + " = " + ruutP + " ühikut"); //P
            Console.WriteLine("--");

            double ringS = Math.Pow(ringR, 2) * Math.PI;
            double ringC = ringD * Math.PI;
            Console.WriteLine("Ringi pindala on " + ringR + " * " + ringR +  " * " + "PI" + " = " + ringS + " ühikut ruudus"); //S
            Console.WriteLine("--");
            Console.WriteLine("Ringi ümbermõõt on " + ringD + " * " + "PI" + " = " + ringC + " ühikut"); //C
        }
    }
}
