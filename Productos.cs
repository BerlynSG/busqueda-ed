public class Productos
{
    public string[] agotados;

    public Productos(string[] agotados)
    {
        this.agotados = agotados;
    }

    public bool EstáProductoAgotado(string producto)
    {
        return BuscarPosicion(producto) != -1;
    }

    public int BuscarPosicion(string producto)
    {
        for (int i = 0; i < agotados.Length; i++)
        {
            if (agotados[i].Equals(producto, StringComparison.OrdinalIgnoreCase))
                return i;
        }

        return -1;
    }

    public string RevisarProducto(string producto)
    {
        int posicion = BuscarPosicion(producto);

        if (posicion != -1)
            return $"El producto '{producto}' está agotado. Se encuentra en la posición {posicion}.";

        return $"El producto '{producto}' no está agotado.";
    }
}