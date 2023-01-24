class A025
{
    static void Main()
    {
        int num = 10;
        Dobrar(ref num);
        Console.WriteLine(num);
    }

    static void Dobrar(ref int valor)
    {
        valor *= 2;
    }
}