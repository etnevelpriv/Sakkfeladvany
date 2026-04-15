namespace Sakkfeladvany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sorok = 0;
            int oszlopok = 0;

            while (true)
            {
                Console.Write("Adja meg a sakktábla sorainak számát: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out sorok) && sorok > 0)
                {
                    break;
                } else
                {
                    Console.WriteLine("Hibas adatok");
                }
            }
            while (true)
            {
                Console.Write("Adja meg a sakktábla oszlopainak számát: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out oszlopok) && oszlopok > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hibás adatok");
                }
            }

            Feladvany feladvany = new Feladvany(sorok, oszlopok);
        }
    }
}
