namespace ClassificacaoDeTriangulos.ConsoleApp;

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

            int ladoX;
            int ladoY;
            int ladoZ;

            while (true)
            {
                Console.Write("Informe o valor do lado X: ");

                bool conseguiuConverter = int.TryParse(Console.ReadLine(), out ladoX);

                if (conseguiuConverter)
                    break;
            }

            while (true)
            {
                Console.Write("Informe o valor do lado Y: ");

                bool conseguiuConverter = int.TryParse(Console.ReadLine(), out ladoY);

                if (conseguiuConverter)
                    break;
            }

            while (true)
            {
                Console.Write("Informe o valor do lado Z: ");

                bool conseguiuConverter = int.TryParse(Console.ReadLine(), out ladoZ);

                if (conseguiuConverter)
                    break;
            }


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
