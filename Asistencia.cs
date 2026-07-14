public class Asistencia
{
    public string[] nombres;

    public Asistencia(string[] nombres)
    {
        this.nombres = nombres;
    }
    

    public bool EstáPresente(string nombre)
    {
        for (int i = 0; i < nombres.Length; i++)
        {
            if (nombres[i] == nombre)
                return true;
        }
        return false;
    }
}