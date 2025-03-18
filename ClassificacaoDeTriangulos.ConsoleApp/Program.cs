using System;

namespace ClassificacaoDeTriangulos.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ExibirCabecalho();

            int ladoX = LerLado("X");
            int ladoY = LerLado("Y");
            int ladoZ = LerLado("Z");

            ExibirValoresInformados(ladoX, ladoY, ladoZ);

            if (MedidasFormamTrianguloValido(ladoX, ladoY, ladoZ))
            {
                string tipoTriangulo = ClassificarTriangulo(ladoX, ladoY, ladoZ);

                Console.WriteLine($"O triângulo é {tipoTriangulo}!");
            }
            else
                Console.WriteLine("Os valores informados não formam um triângulo válido!");


            Console.Write("\nDeseja continuar? (S/N)");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();
            if (opcaoContinuar != "S")
                break;
        }
    }

    static void ExibirCabecalho()
    {
        Console.Clear();
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Classificador de Triângulos");
        Console.WriteLine("-------------------------------------------");
    }

    static int LerLado(string nomeLado)
    {
        int valor;

        while (true)
        {
            Console.Write($"\nInforme o valor do lado {nomeLado}: ");

            bool conseguiuConverter = int.TryParse(Console.ReadLine(), out valor);

            if (conseguiuConverter)
                break;

            Console.WriteLine("\nValor inválido!");
        }

        return valor;
    }

    static void ExibirValoresInformados(int ladoX, int ladoY, int ladoZ)
    {
        Console.WriteLine("\n-------------------------------------------");
        Console.WriteLine("Valores Informados: ");
        Console.WriteLine("Lado X: " + ladoX);
        Console.WriteLine("Lado Y: " + ladoY);
        Console.WriteLine("Lado Z: " + ladoZ);
        Console.WriteLine("-------------------------------------------\n");
    }

    static bool MedidasFormamTrianguloValido(int ladoX, int ladoY, int ladoZ)
    {
        bool medidasTriangulosValida =
                ladoX + ladoY > ladoZ &&
                ladoX + ladoZ > ladoY &&
                ladoY + ladoZ > ladoX;

        return medidasTriangulosValida;
    }

    static string ClassificarTriangulo(int ladoX, int ladoY, int ladoZ)
    {
        string tipoTriangulo = "Não classificado";

        if (ladoX == ladoY && ladoY == ladoZ)
            tipoTriangulo = "Equilátero";

        else if (ladoX != ladoY && ladoY != ladoZ && ladoX != ladoZ)
            tipoTriangulo = "Escaleno";

        else
            tipoTriangulo = "Isóceles";

        return tipoTriangulo;
    }
}
