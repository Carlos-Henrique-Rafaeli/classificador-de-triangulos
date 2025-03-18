namespace ClassificacaoDeTriangulos.ConsoleApp;

public static class ClassificadorDeTriangulos
{
    public static bool MedidasFormamTrianguloValido(int ladoX, int ladoY, int ladoZ)
    {
        bool medidasTriangulosValida =
                ladoX + ladoY > ladoZ &&
                ladoX + ladoZ > ladoY &&
                ladoY + ladoZ > ladoX;

        return medidasTriangulosValida;
    }

    public static string ClassificarTriangulo(int ladoX, int ladoY, int ladoZ)
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
