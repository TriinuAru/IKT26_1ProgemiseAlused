namespace PaperScissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string PC = " ";
            int PP = 0;
            int CompP = 0;

            while (PC != "lõpeta")
            {
                Console.WriteLine("Vali: kivi, paber või käärid");
                Console.WriteLine("Mängulõpetamiseks kirjuta: lõpeta");
                //ToLower muudab su kirjutatud teksti väikesteks tähtedeks
                PC = Console.ReadLine().ToLower();

                if (PC == "lõpeta")
                {
                    break;
                }
                else if (PC != "kivi" && PC != "paber" && PC != "käärid")
                {
                    Console.WriteLine("Sellist valikut pole, proovi uuesti");
                    continue;
                }

                int CN = random.Next(1, 4);
                string CC = "";

                if (CN == 1)
                {
                    CC = "kivi";
                }
                else if (CN == 2)
                {
                    CC = "paber";
                }
                else
                {
                    CC = "käärid";
                }

                Console.WriteLine($"Arvuti valis: {CC}");

                if (PC == CC)
                {
                    Console.WriteLine("Viik!");
                }
                else if ((PC == "kivi" && CC == "käärid") || (PC == "paber" && CC == "kivi") || (PC == "käärid" && CC == "paber"))
                {
                    Console.WriteLine("Sina võitsid");
                    PP++;
                }
                else
                {
                    Console.WriteLine("Arvuti võitis");
                    CompP++;
                }

                Console.WriteLine($"Punktid: sina {PP} -- arvuti {CompP}");
                Console.WriteLine();
            }
            Console.WriteLine("Mäng on läbi");
            Console.WriteLine($"Lõpptulemus: sina {PP} -- arvuti {CompP}");
        }
    }
}
