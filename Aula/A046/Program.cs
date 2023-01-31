class A046
{
    static void Main()
    {
        Galinha g1 = new("g1");
        Galinha g2 = new("g2");
        Galinha g3 = new("g3");

        g1.botar();
        g1.botar();
        g1.botar();

        g2.botar();

        g3.botar();
        g3.botar();

        Console.WriteLine($"qtde {Galinha.qtdeOvos}");
    }
}

class Galinha
{
    private string nomeGalinha;
    private int numOvo;
    static public int qtdeOvos;

    public Galinha(string nomeGalinha)
    {
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }

    public Ovo botar()
    {
        numOvo++;
        qtdeOvos++;
        return new Ovo(numOvo, nomeGalinha);
    }
}

class Ovo
{
    private int numOvo;
    private string minhaGalinha;

    public Ovo(int numOvo, string minhaGalinha)
    {
        this.numOvo = numOvo;
        this.minhaGalinha = minhaGalinha;
        Console.WriteLine("Ovo criado: {0} - {1}", this.numOvo, this.minhaGalinha);
    }
}