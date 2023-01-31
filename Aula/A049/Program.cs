class A049
{
    static void Main()
    {
        double vpi = double.Pi;
        int num = 10;

        Console.WriteLine(Mat.Dobro(num));
        Console.WriteLine(vpi);
    }
}

class Mat
{
    public static double pi = 3.14;
    public static int Dobro(int n)
    {
        return n * 2;
    }
}