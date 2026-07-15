public class Clientes
{
    public long[] cedulas;

    public Clientes(long[] cedulas)
    {
        this.cedulas = cedulas;
    }

    public int BuscarCedula(long cedulaBuscada)
    {
        for (int i = 0; i < cedulas.Length; i++)
        {
            if (cedulas[i] == cedulaBuscada)
                return i;
        }

        return -1;
    }

    public string RevisarCliente(long cedulaBuscada)
    {
        int posicion = BuscarCedula(cedulaBuscada);

        if (posicion != -1)
            return $"La cédula {cedulaBuscada} sí existe en el registro. Se encuentra en la posición {posicion}.";

        return $"La cédula {cedulaBuscada} no aparece en el registro masivo.";
    }
}
