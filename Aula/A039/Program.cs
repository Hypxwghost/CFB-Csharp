class A039
{
    static void Main()
    {
        Carro carro1 = new();

        carro1.Aceleracao(1);
        carro1.Aceleracao(-1);

        Console.WriteLine(carro1.GetVelAtual());
    }
}

abstract class Veiculo
{
    protected int VelMaxima;
    protected int VelAtual;
    protected bool Ligado;

    public Veiculo()
    {
        Ligado = false;
        VelAtual = 0;
    }

    public void SetLigado(bool Ligado)
    {
        this.Ligado = Ligado;
    }

    public int GetVelAtual()
    {
        return VelAtual;
    }

    abstract public void Aceleracao(int mult);
}

class Carro : Veiculo
{
    public Carro()
    {
        VelMaxima = 120;
    }

    public override void Aceleracao(int mult)
    {
        VelAtual += 10 * mult;
    }
}