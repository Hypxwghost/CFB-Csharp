﻿class A042
{
    static void Main()
    {
        Carro c1 = new();

        c1[4] = 200;

        Console.WriteLine("Vel: {0}", c1[4]);
    }
}

class Carro
{
    private int[] VelMax = new int[5] { 80, 120, 160, 240, 300 };
    public int this[int i]
    {
        get
        {
            return VelMax[i];
        }
        set
        {
            if (value < 0)
            {
                VelMax[i] = 0;
            }
            else if (value > 300)
            {
                VelMax[i] = 300;
            }
            else
            {
                VelMax[i] = value;
            }
        }
    }

    public Carro()
    {
    }
}