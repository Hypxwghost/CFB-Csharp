class A047
{
    static void Main()
    {
        double res;
        Calc calc = new();
        res = calc.Fat(5);

        Console.WriteLine(res);
    }
}

class Calc
{
    public int Soma(params int[] n)
    {
        int s = 0;
        for (int i = 0; i < n.Length; i++)
        {
            s += n[i];
        }
        return s;
    }

    public double Soma(params double[] n)
    {
        double s = 0;
        for (int i = 0; i < n.Length; i++)
        {
            s += n[i];
        }
        return s;
    }

    public int Fat(int n)
    {
        int res;
        if (n < 1)
        {
            res = 1;
        }
        else
        {
            res = n * Fat(n - 1);
        }
        return res;
    }

}