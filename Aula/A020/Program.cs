class A020
{
    static void Main()
    {
        int[] num = new int[10];

        int i = 0;

        while (i < num.Length)
        {
            num[i] = i;
            Console.WriteLine(num[i]);
            i++;
        }

        i -= 1;

        while (i > 0)
        {
            num[i] = i;
            Console.WriteLine(num[i]);
            i--;
        }

        Console.WriteLine("Fim");
    }
}