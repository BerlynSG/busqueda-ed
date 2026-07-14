public class Productos
{
    public string[] agotados;

    public Productos(string[] agotados)
    {
        this.agotados = agotados;
    }

    public bool EstáProductoAgotado(string producto)
    {
        for (int i = 0; i < agotados.Length; i++)
        {
            if (agotados[i] == producto)
                return true;
        }
        return false;
    }
}