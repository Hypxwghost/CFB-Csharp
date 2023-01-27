class A041
{
    static void Main()
    {
        Carro c1 = new();

        c1.Vm = 300;

        Console.WriteLine("Vel: {0}", c1.Vm);
    }
}

class Carro
{
    private int VelMax;
    public int Vm
    {
        get
        {
            return VelMax;
        }
        set
        {
            if (value < 0)
            {
                VelMax = 0;
            }
            else if (value > 300)
            {
                VelMax = 300;
            }
            else
            {
                VelMax = value;
            }
        }
    }

    public Carro()
    {
        Vm = 120;
    }
}