using System.Diagnostics;

class A053
{
    static void Main()
    {

        Stopwatch stopwatch = new();
        float area = 0;

        try
        {
            stopwatch.Start();

            area = Area.Quad(0f, 0f);
            Console.WriteLine($"Area do quadrado: {area}");

            stopwatch.Stop();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Erro: {e.Message}");
        }
        finally
        {
            Console.WriteLine(new string('_', 50));
            Console.WriteLine($"Tempo de execução: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}

class Area
{
    public static float Quad(float @base, float altura)
    {
        if (@base == 0 || altura == 0)
        {
            throw new Exception("Base ou altura não podem ser iguais a zero");
        }
        return @base * altura;
    }
}