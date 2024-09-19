namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Koodi tähän
             Console.Write("Anna luku: ");
            int luku = int.Parse(Console.ReadLine());

            Console.WriteLine("\n" + luku + luku + luku + luku );
            Console.WriteLine(luku + " " + luku + " " + luku);
            Console.WriteLine("" + luku + luku + luku + luku + luku);

            Console.Write("\nAnna toinen luku: ");
            int luku2 = int.Parse(Console.ReadLine());
            Console.Write("Anna vielä kolmas luku: ");
            int luku3 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n" + luku + " " + luku2 + " " + luku3);
            Console.WriteLine(luku);
            Console.WriteLine(luku2);
            Console.WriteLine(luku3);
            Console.WriteLine("" + luku3 + " " + luku2 + " " + luku);
        }

    }
}


