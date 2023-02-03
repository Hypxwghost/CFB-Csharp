class A051
{
    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            Console.WriteLine($"Qtde de argumentos {args.Length}");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Argumento {i}:{args[i]}");
            }
            Console.WriteLine(new string('-', 50));

            if (args[0] == "Queijo")
            {
                Console.WriteLine("Pão de queijo");
            }
        }
        else
        {
            Console.WriteLine("Não foram passados argumentos");
        }
    }
}