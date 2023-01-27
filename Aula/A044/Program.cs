class A044
{
    static void Main()
    {
        Carro c1 = new("Honda", "HRV", "Prata");
        Carro c2 = new("VW", "Golf", "Azul");

        /*c1.marca = "VW";
        c1.modelo = "Golf";
        c1.cor = "Preto";
*/
        c1.Info();
        c2.Info();
    }
}

struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }

    public void Info()
    {
        Console.WriteLine("Marca: {0}", this.marca);
        Console.WriteLine("Modelo: {0}", this.modelo);
        Console.WriteLine("Cor: {0}", this.cor);
    }
}