class A033
{
    static void Main()
    {
        Jogador j1 = new("Bruno");

        j1.SetEnergia(150);

        Console.WriteLine("Nome...: {0}", j1.GetNome());
        Console.WriteLine("Energia: {0}", j1.GetEnergia());
    }
}

class Jogador
{
    private int energia;
    private string nome;

    public Jogador(string nome)
    {
        this.nome = nome;
        energia = 100;
    }

    public int GetEnergia()
    {
        return energia;
    }

    public string GetNome()
    {
        return nome;
    }

    public void SetEnergia(int e)
    {
        // Se energia "Inbound" "mais menos" energia atual for menor que zero, valor minimo == 0
        if (e < 0)
        {
            if (energia + e < 0)
            {
                energia = 0;
            }
            else
            {
                energia += e;
            }
        }
        // Se energia "Inbound" "mais mais" a energia atual for maior que 100, valor maximo == 100
        else if (e > 0)
        {
            if (energia + e > 100)
            {
                energia = 100;
            }
            else
            {
                energia += e;
            }
        }
    }
}