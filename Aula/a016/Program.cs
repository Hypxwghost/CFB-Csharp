//class A015
//{
//    static void Main()
//    {
//        int tempo = 0;
//        char escolha = ' ';

//        inicio:

//        Console.Clear();

//        Console.WriteLine("Belo Horizonte/BH a Vitória/ES");
//        Console.WriteLine("Escolha o transporte:[a]Avião | [c]Carro | [o]Ônibus  "); ;

//        escolha = char.Parse(Console.ReadLine());

//        switch (escolha)
//        {
//            case 'a':case 'A':
//                tempo = 50; break;
//            case 'c':case 'C':
//                tempo = 480; break;
//            case 'o':case 'O':
//                tempo = 660; break;
//            default:
//                tempo = -1 ; break;
//        }

//        if (tempo < 0)
//        {
//            Console.WriteLine("Transporte indisponível");
//        } else
//        {
//            Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos", tempo);
//        }

//        Console.Write("\nCalcular outro transporte?[S/N]");
//        escolha = char.Parse(Console.ReadLine());
//        if (escolha == 's' || escolha == 'S')
//        {
//            goto inicio;
//        } else
//        {
//            Console.Clear();
//            Console.WriteLine("Fim do programa");
//        }
//    }
//}

class MenuTeste
{
    static void Main()
    {
        char escolha = ' ';

    inicio:
        Console.Clear();

        Console.WriteLine("===== Bem Vindo ao menu Lorem Ipsum! ======");
        Console.WriteLine("Menu principal");
        Console.WriteLine("[1] - Opções 1 \n[2] - Opções 2 \n[3] - Opções 3 \n[4] - Opções 4 \n[5] - Opções 5");
        escolha = char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case '1':
                Console.WriteLine("Menu 1");
                Console.WriteLine("[6] - The quick brown fox");
                Console.WriteLine("[2] - Jumps over the lazy dog"); break;
            case '2':
                Console.WriteLine("Menu 2");
                Console.WriteLine("[1] - Pão de queijo");
                Console.WriteLine("[2] - C# >> All cof cof cof"); break;
            case '3':
                Console.WriteLine("Menu 3");
                Console.WriteLine("[1] - Quero cafeee");
                Console.WriteLine("[2] - eeeeeeeeeee"); break;
            case '4':
                Console.WriteLine("Menu 4");
                Console.WriteLine("[1] - Tuts tuts tuts tuts queru vê");
                Console.WriteLine("[2] - Kleitin brabo"); break;
            case '5':
                Console.WriteLine("Menu 5");
                Console.WriteLine("[1] - CFB manja");
                Console.WriteLine("[2] - Lorem ipsum dolor sit amet"); break;
            default:
                Console.WriteLine("Opção não encontrada !"); break;
        }

        Console.WriteLine("Deseja usar outra opção? [S/N]");
        escolha = char.Parse(Console.ReadLine());
        if (escolha == 's' | escolha == 'S')
        {
            goto inicio;
        } else
        {
            Console.WriteLine("Obrigado por usar o menu Lorem Ipsum!");
        }
    }
}