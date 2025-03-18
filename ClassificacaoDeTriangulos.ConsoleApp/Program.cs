﻿namespace ClassificacaoDeTriangulos.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Classificador de Triângulos");
            Console.WriteLine("-------------------------------------------\n");

            Console.Write("Informe o valor do lado X: ");
            int ladoX = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Informe o valor do lado Y: ");
            int ladoY = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o valor do lado Z: ");
            int ladoZ = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("Valores Informados: ");
            Console.WriteLine("Lado X: " + ladoX);
            Console.WriteLine("Lado Y: " + ladoY);
            Console.WriteLine("Lado Z: " + ladoZ);
            Console.WriteLine("-------------------------------------------\n");

            bool medidasTriangulosValida = 
                ladoX + ladoY > ladoZ &&
                ladoX + ladoZ > ladoY &&
                ladoY + ladoZ > ladoX;

            if (medidasTriangulosValida)
            {
                string tipoTriângulo = "Não classificado";

                if (ladoX == ladoY && ladoY == ladoZ)
                    tipoTriângulo = "Equilátero";

                else if (ladoX != ladoY && ladoY != ladoZ && ladoX != ladoZ)
                    tipoTriângulo = "Escaleno";

                else
                    tipoTriângulo = "Isóceles";

                Console.WriteLine($"O triângulo é {tipoTriângulo}!");
            }
            else
                Console.WriteLine("Os valores informados não formam um triângulo válido!");


            Console.Write("\nDeseja continuar? (S/N)");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();
            if (opcaoContinuar != "S")
                break;
        }
    }
}
