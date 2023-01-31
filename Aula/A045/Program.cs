class A045
{
    static void Main()
    {
        int[] numeros = new int[10];
        Carro[] carros = new Carro[4];
        /*c1.marca = "VW";
        c1.modelo = "Golf";
        c1.cor = "Preto";
*/
        carros[0].modelo = "HRV";
        carros[0].cor = "Prata";

        carros[1].modelo = "Golf";
        carros[1].cor = "Azul";

        carros[2].modelo = "Jetta";
        carros[2].cor = "Branco";

        carros[3].modelo = "Impala SS";
        carros[3].cor = "Preto";

        for (int i = 0; i < carros.Length; i++)
        {
            carros[i].Info();
        }
    }
}

struct Carro
{
    public string modelo;
    public string cor;

    public Carro(string modelo, string cor)
    {
        this.modelo = modelo;
        this.cor = cor;
    }

    public void Info()
    {
        Console.WriteLine("Modelo: {0}", this.modelo);
        Console.WriteLine("Cor: {0}", this.cor);
        Console.WriteLine(new string('-', 50));
    }
}
