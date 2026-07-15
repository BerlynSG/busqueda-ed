public class Clientes
{
    // Guarda las cédulas del registro masivo de clientes.
    public long[] cedulas;

    public Clientes(long[] cedulas)
    {
        this.cedulas = cedulas;
    }

    // Busca si una cédula está en la lista.
    public int BuscarCedula(long cedulaBuscada)
    {
        for (int i = 0; i < cedulas.Length; i++)
        {
            if (cedulas[i] == cedulaBuscada)
                return i;
        }

        return -1;
    }

    // Devuelve un mensaje simple según si la cédula existe o no.
    public string RevisarCliente(long cedulaBuscada)
    {
        int posicion = BuscarCedula(cedulaBuscada);

        if (posicion != -1)
            return $"La cédula {cedulaBuscada} sí existe en el registro.";

        return $"La cédula {cedulaBuscada} no aparece en el registro masivo.";
    }
}
