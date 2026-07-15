public class Productos
{
    // Guarda los productos que están fuera de stock.
    public string[] agotados;

    public Productos(string[] agotados)
    {
        this.agotados = agotados;
    }

    // Busca la posición de un producto en la lista.
    public int BuscarPosicion(string producto)
    {
        for (int i = 0; i < agotados.Length; i++)
        {
            if (agotados[i].Equals(producto, StringComparison.OrdinalIgnoreCase))
                return i;
        }

        return -1;
    }

    // Devuelve un mensaje simple para decir si está agotado o no.
    public string RevisarProducto(string producto)
    {
        int posicion = BuscarPosicion(producto);

        if (posicion != -1)
            return $"El producto '{producto}' está agotado. Se encuentra en la posición {posicion}.";

        return $"El producto '{producto}' no está agotado.";
    }
}