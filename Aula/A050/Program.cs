class A050
{
    static void Main()
    {
        int res;
        Op d1 = new(Mat.Soma);

        res = d1(10, 50);

        Console.WriteLine($"Soma: {res}");

        d1 = new(Mat.Mult);

        res = d1(10, 50);

        Console.WriteLine($"Multiplicação: {res}");
    }
}

class Mat
{
    public static int Soma(int n1, int n2)
    {
        return n1 + n2;
    }

    public static int Mult(int n1, int n2)
    {
        return n1 * n2;
    }
}

delegate int Op(int n1, int n2);