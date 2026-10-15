namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //teha switchi valik, kas *, /, +, -
            //teha neli casei, kus toimub soovitud tehe
            //peab näitama tehte tulemust
            //kasutada floati Parsimisel

            Console.WriteLine("Sisesta esimene number:");
            float input1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Kasuta tingmärki *, /, +, -");
            string input3 = Console.ReadLine();

            Console.WriteLine("Sisesta teine number:");
            float input2 = float.Parse(Console.ReadLine());
            Console.Clear();

            switch (input3)
            {
                case "*":
                    Console.WriteLine(input1 + " * " + input2 + " = " + input1 * input2);
                    break;

                case "/":
                    if (input2 != 0)
                    {
                        Console.WriteLine(input1 + " / " + input2 + " = " + input1 / input2);
                    }
                    else
                    {
                        Console.WriteLine("Nulliga jagada ei saa");
                    }
                    break;

                case "+":
                    Console.WriteLine(input1 + " + " + input2 + " = " + input1 + input2);
                    break;

                case "-":
                    Console.WriteLine(input1 + " - " + input2 + " = " + (input1 - input2));
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
