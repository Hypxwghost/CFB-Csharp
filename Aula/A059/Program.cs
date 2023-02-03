class A059
{
    static void Main()
    {
        Queue<string> veiculos = new();

        veiculos.Enqueue("Carro"); // Adiciona no final da fila
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Avião");

        string v = "Pão";

        if (veiculos.Contains(v))
        {
            Console.WriteLine($"Veiculo {v} encontrado");
        }
        else
        {
            Console.WriteLine($"Veiculo {v} não encontrado!");
        }
        //veiculos.Clear();
        //Console.WriteLine($"Primeiro veiculo: {veiculos.Dequeue()}");
        Console.WriteLine($"Primeiro veiculo: {veiculos.Peek()}");
        /*foreach (string veic in veiculos)
        {
            Console.WriteLine($"Veiculo: {veic}");
        }*/

        Console.WriteLine($"Tamanho fila: {veiculos.Count}");

        while (veiculos.Count > 0)
        {
            Console.WriteLine(veiculos.Dequeue());
        }
        Console.WriteLine($"Tamanho fila: {veiculos.Count}");
    }
}