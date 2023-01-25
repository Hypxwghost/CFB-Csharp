class A034
{
    static void Main()
    {
        Carro c1 = new Carro("Impala 64", "Azulão");

        Console.WriteLine("Cor:.............:{0}", c1.cor);
        Console.WriteLine("Nome:............:{0}", c1.nome);
        Console.WriteLine("Roda:............:{0}", c1.rodas);
        Console.WriteLine("Velocidade máxima:{0}", c1.velMax);
        Console.WriteLine("Ligado:..........:{0}", c1.GetLigado());
    }

    class Veiculo // Classe base
    {
        public int velMax;
        private bool ligado;
        public int rodas;

        public void Ligar()
        {
            ligado = true;
        }

        public void Desligar()
        {
            ligado = false;
        }

        public string GetLigado()
        {
            if (ligado)
            {
                return "sim";
            }
            else
            {
                return "não";
            }
        }
    }

    class Carro : Veiculo // Classe derivada
    {
        public string nome;
        public string cor;
        public Carro(string nome, string cor)
        {
            Desligar();
            rodas = 4;
            velMax = 120;
            this.nome = nome;
            this.cor = cor;
        }
    }
}