using System;

class A031
{
    static void Main()
    {
        Jogador.Iniciar("Jubiscleito");
        Jogador.Info();

        Inimigo i1 = new("Tuts tuts queru vê");
        Inimigo i2 = new("Lorem");
        Inimigo i3 = new("Kleber");

        Inimigo.alerta = true;

        i1.Info();
        i2.Info();
        i3.Info();
    }
}

class Inimigo
{
    static public bool alerta;
    public string nome;

    public Inimigo(string n)
    {
        alerta = false;
        nome = n;
    }

    public void Info()
    {
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine(new string('-', 50));
    }
}

static public class Jogador
{
    static public int energia;
    static public bool vivo;
    static public string nome;

    static public void Iniciar(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }

    static public void Info()
    {
        Console.WriteLine("Nome do jogador {0}", nome);
        Console.WriteLine("Energia do jogador {0}", energia);
        Console.WriteLine("Estado do jogador {0}\n", vivo);
    }
}