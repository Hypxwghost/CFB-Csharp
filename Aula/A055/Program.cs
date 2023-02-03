class A055
{
    static void Main()
    {
        Dictionary<int, string> veiculos = new();

        veiculos.Add(10, "Carro");
        veiculos.Add(5, "Avião");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Moto");
        veiculos.Add(15, "Patinete");

        veiculos.Remove(20);

        //veiculos.Clear();
        Console.WriteLine($"Tamanho do Dictionary: {veiculos.Count}");
        Console.WriteLine(new string('-', 50));

        int chave = 20;
        if (veiculos.ContainsKey(chave))
        {
            Console.WriteLine($"A chave {chave} esta na coleção!");
        }
        else
        {
            Console.WriteLine($"A chave {chave} não está na coleção!");
        }

        Console.WriteLine(new string('-', 50));

        veiculos[15] = "Bicicleta";

        string valor = "Bicicleta";
        if (veiculos.ContainsValue(valor))
        {
            Console.WriteLine($"A valor {valor} esta na coleção!");
        }
        else
        {
            Console.WriteLine($"A valor {valor} não está na coleção!");
        }

        Dictionary<int, string>.ValueCollection valores = veiculos.Values;

        foreach (string v in valores)
        {
            Console.WriteLine(v);
        }
    }
}