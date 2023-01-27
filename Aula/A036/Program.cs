class A036
{
    static void Main()
    {
        Carro carro = new("S15", 400);

        Console.WriteLine("Nome:{0}", carro.nome);
        Console.WriteLine("Velocidade máxima:{0}", carro.GetVelMax());
        Console.WriteLine("Ligado:{0}", carro.GetLigado());
    }
}

class Veiculo
{
    public int VelAtual;
    private int VelMax;
    protected bool ligado;

    public Veiculo(int velMax)
    {
        VelAtual = 0;
        this.VelMax = velMax;
        ligado = false;
    }

    public bool GetLigado()
    {
        return ligado;
    }

    public int GetVelMax()
    {
        return VelMax;
    }
}

class Carro : Veiculo
{
    public string nome;

    public Carro(string nome, int vm) : base(vm)
    {
        this.nome = nome;
        ligado = true;
    }
}