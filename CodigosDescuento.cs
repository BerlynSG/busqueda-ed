public class CodigosDescuento
{
    public int[] codigos;

    public CodigosDescuento(int[] codigos)
    {
        this.codigos = codigos;
    }

    public int BuscarCodigo(int codigoBuscado)
    {
        int inicio = 0;
        int fin = codigos.Length - 1;

        while (inicio <= fin)
        {
            int medio = inicio + (fin - inicio) / 2;

            if (codigos[medio] == codigoBuscado)
                return medio;

            if (codigos[medio] < codigoBuscado)
                inicio = medio + 1;
            else
                fin = medio - 1;
        }

        return -1;
    }

    public string ValidarCodigo(int codigoBuscado)
    {
        int posicion = BuscarCodigo(codigoBuscado);

        if (posicion != -1)
            return $"El código {codigoBuscado} sí es válido. Se encuentra en la posición {posicion}.";

        return $"El código {codigoBuscado} no existe en los códigos de descuento.";
    }
}
