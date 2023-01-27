class A38
{
    static void Main()
    {
        Base Ref;
        Derivada1 derivada1 = new();
        Derivada2 derivada2 = new();

        Ref = derivada2;

        Ref.Info();
    }
}

class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da classe Base");
    }

    virtual public void Info()
    {
        Console.WriteLine("Base");
    }
}

class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor da Classe derivada1");
    }

    override public void Info()
    {
        Console.WriteLine("Derivada1");
    }
}

class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor da classe derivada2");
    }

    public override void Info()
    {
        Console.WriteLine("Derivada 2");
    }
}