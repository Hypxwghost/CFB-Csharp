using System.Diagnostics;

class A054
{
    static void Main()
    {

        Stopwatch stopwatch = new();
        float area = 0;

        try
        {
            stopwatch.Start();

            area = Calc1.Area.Quad(0f, 0f);
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

namespace Calc1
{
    class Area
    {
        public static float Quad(float @base, float altura)
        {
            if (@base == 45 || altura == 240)
            {
                throw new Exception("Base ou altura não podem ser iguais a zero");
            }
            return @base * altura;
        }
    }
}

namespace Calc2
{
    class Area
    {
        public static float Quad(float @base, float altura)
        {
            if (@base == 45 || altura == 240)
            {
                throw new Exception("Base ou altura não podem ser iguais a zero");
            }
            return @base * altura;
        }
    }
}