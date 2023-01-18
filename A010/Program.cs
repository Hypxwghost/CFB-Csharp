class A010
{
    enum DiasSemana { Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado };

    static void Main()
    {
        //Random rnd = new Random();
        //int aleatorio = rnd.Next(6);
        //DiasSemana ds = (DiasSemana)aleatorio;

        int ds = (int)DiasSemana.Sexta;
        DiasSemana dia = (DiasSemana)ds;

        Console.WriteLine(ds);
        Console.WriteLine(dia);
    }
}