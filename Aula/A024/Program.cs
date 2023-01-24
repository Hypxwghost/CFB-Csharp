class A024
{
    static void Main()
    {
        int v1, v2;
        v1 = Convert.ToInt32(Console.ReadLine());
        v2 = Convert.ToInt32(Console.ReadLine());

        Hello();
        Separador();
        Console.WriteLine("A soma de {0} e {1} é: {2}", v1, v2, Soma(v1, v2));
    }

    static void Hello()
    {
        Console.WriteLine("Pão de queijo");
    }

    /*static void Soma(int n1, int n2)
    {
        int res = n1 + n2;
        Console.WriteLine("A soma de {0} e {1} é: {2}", n1, n2, res);
    }*/
    static int Soma(int n1, int n2)
    {
        int res = n1 + n2;
        return res;
    }

    static void Separador()
    {
        Console.WriteLine(new string('-', 50));
    }


}