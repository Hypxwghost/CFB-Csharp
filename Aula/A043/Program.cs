class A043
{
    static void Main()
    {
        Carro c1 = new();
    }
}

public interface Veiculo
{
    void Ligar();
    void Desligar();
    void Info();
}

public interface Combate
{
    void Disparar();
}

class Carro : Veiculo, Combate
{
    public bool ligado;
    private int municao;

    public Carro()
    {
        SetMunicao(100);
    }

    public void SetMunicao(int qtde)
    {
        this.municao = qtde;
    }

    public void Ligar()
    {
        this.ligado = true;
    }

    public void Desligar()
    {
        this.ligado = false;
    }

    public void Disparar() { }

    public void Info()
    {

    }
}