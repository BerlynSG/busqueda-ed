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

    public string RevisarAsistencia(string nombre)
    {
        if (EstáPresente(nombre))
            return $"El estudiante '{nombre}' está presente.";
        else
            return $"El estudiante '{nombre}' no está presente.";
    }
}