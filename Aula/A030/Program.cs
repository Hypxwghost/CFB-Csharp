using System;

class A030
{
    static void Main()
    {
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("Klebin");
        Jogador j3 = new Jogador("Kleitin", 100);
        Jogador j4 = new Jogador("Junin", 30, false);

        j1.Info();
        j2.Info();
        j3.Info();
        j4.Info();
    }
}

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador()
    {
        energia = 100;
        vivo = true;
        nome = "Jogador";
    }

    public Jogador(string n, int e)
    {
        energia = e;
        vivo = true;
        nome = n;
    }

    public Jogador(string n, int e, bool v)
    {
        energia = e;
        vivo = v;
        nome = n;
    }

    public Jogador(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }

    public void Info()
    {
        Console.WriteLine("Nome do jogador {0}", nome);
        Console.WriteLine("Energia do jogador {0}", energia);
        Console.WriteLine("Estado do jogador {0}\n", vivo);
    }
}