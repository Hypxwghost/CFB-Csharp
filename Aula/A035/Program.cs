class A034
{
    static void Main()
    {
        Carro c1 = new("Impala 64", "Azulão");
        CarroCombate cc1 = new();

        c1.Ligar();

        Console.WriteLine("Cor:.............:{0}", c1.cor);
        Console.WriteLine("Nome:............:{0}", c1.nome);
        Console.WriteLine("Roda:............:{0}", c1.GetRodas());
        Console.WriteLine("Velocidade máxima:{0}", c1.velMax);
        Console.WriteLine("Ligado:..........:{0}", c1.GetLigado());

        Console.WriteLine(new string('-', 50));

        Console.WriteLine("Cor:.............:{0}", cc1.cor);
        Console.WriteLine("Nome:............:{0}", cc1.nome);
        Console.WriteLine("Roda:............:{0}", cc1.GetRodas());
        Console.WriteLine("Velocidade máxima:{0}", cc1.velMax);
        Console.WriteLine("Ligado:..........:{0}", cc1.GetLigado());
        Console.WriteLine("Munição:.........:{0}", cc1.municao);
    }

    class Veiculo // Classe base
    {
        public int velMax;
        private bool ligado;
        private int rodas;

        public Veiculo(int rodas)
        {
            this.rodas = rodas;
        }

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
            return ligado ? "Sim" : "Não";
            /*if (ligado)
            {
                return "sim";
            }
            else
            {
                return "não";
            }*/
        }

        public int GetRodas()
        {
            return rodas;
        }

        public void SetRodas(int rodas)
        {
            if (rodas < 0)
            {
                this.rodas = 0;
            }
            else if (rodas > 40)
            {
                this.rodas = 40;
            }
            else
            {
                this.rodas = rodas;
            }
        }
    }

    class Carro : Veiculo // Classe derivada
    {
        public string nome;
        public string cor;

        public Carro(string nome, string cor) : base(4)
        {
            {
                Desligar();
                velMax = 120;
                this.nome = nome;
                this.cor = cor;
            }
        }
    }

    class CarroCombate : Carro
    {
        public int municao;

        public CarroCombate() : base("CBV1", "Verde")
        {
            municao = 100;
            SetRodas(8);
        }
    }
}