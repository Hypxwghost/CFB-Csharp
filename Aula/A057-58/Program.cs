class A05758
{
    static void Main()
    {
        List<string> carros = new()
        {
            "Golf",
            "HRV",
            "Focus",
            "Argo",
            "HRV"
        };

        string[] carros2 = new string[10];

        //carros2.AddRange(carros);

        if (carros2.Contains("Golf"))
        {
            Console.WriteLine("Esta na lista");
        }
        else
        {
            Console.WriteLine("Não encontrado!");
        }

        carros.CopyTo(carros2, 2);

        carros.Insert(1, "Cruze");

        int pos2 = carros.LastIndexOf("HRV");

        /*      carros.Remove("Argo");
              carros.RemoveAt(0);*/

        //carros.Reverse();
        carros.Sort();

        Console.WriteLine($"Tamanho: {carros.Count}");
        carros.Capacity = 15;
        Console.WriteLine($"Capacidade {carros.Capacity}");


        foreach (string carro in carros)
        {
            Console.WriteLine($"Carro: {carro}");
        }

        string c = "HRV";
        int pos = 0;
        pos = carros.IndexOf(c);
        Console.WriteLine($"Carro {c} está na posição {pos}");
        Console.WriteLine($"Ultimo HRV está na posição {pos2}");
    }
}