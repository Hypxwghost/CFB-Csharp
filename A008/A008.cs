class A008
{
    static void Main()
    {
        int v1, v2, soma;

        Console.Write("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine());

        soma = v1 + v2;

        Console.WriteLine("A soma de {0} mais {1} é igual a {2}", v1, v2, soma);
    }
}