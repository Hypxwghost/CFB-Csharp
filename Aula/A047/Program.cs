class A047
{
    static void Main()
    {
        double res;
        Calc calc = new();
        res = calc.Soma(1, 5, 10, 35);

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

}