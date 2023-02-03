class A056
{
    static void Main()
    {
        LinkedList<string> transp = new();

        transp.AddFirst("Carro");
        transp.AddFirst("Avião");
        transp.AddFirst("Navio");
        transp.AddFirst("Moto");

        transp.AddLast("Bicicleta");

        LinkedListNode<string> no;
        no = transp.FindLast("Navio").Next;
        transp.AddAfter(no, "Patinete");

        transp.AddBefore(no, "Patins");


        if (transp.Find("Carro") == null)
        {
            Console.WriteLine("Não encontrado!");
        }
        else
        {
            Console.WriteLine("Elemento encontrado!");
        }

        //transp.Remove("Navio");
        transp.RemoveFirst();
        transp.RemoveLast();

        foreach (string t in transp)
        {
            Console.WriteLine($"Transporte: {t}");
        }
    }
}