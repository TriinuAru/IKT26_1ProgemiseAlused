namespace IfAndElseNesting2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha üks if ja else nestimine iseseisvalt");
            Console.WriteLine("Teise else if-i sisse panna if ja else nestimine");

            int number = 10;
            if (number == 12)
            {
                if (number == 25)
                {
                    Console.WriteLine("Number on 25");
                }
                else
                {
                    Console.WriteLine("Number on vahemikus 21 kuni 24 ja 26  kuni lõpmatus");
                }
            }
            else
            {
                Console.WriteLine("Mingid kahtlased numbrid jälle");
            }
        }
    }
}
