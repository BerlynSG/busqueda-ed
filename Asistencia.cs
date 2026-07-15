public class Asistencia
{
    // Guarda la lista de nombres para revisar la asistencia.
    public string[] nombres;

    public Asistencia(string[] nombres)
    {
        this.nombres = nombres;
    }
    

    // Busca si un nombre está en la lista.
    public bool EstáPresente(string nombre)
    {
        for (int i = 0; i < nombres.Length; i++)
        {
            if (nombres[i] == nombre)
                return true;
        }
        return false;
    }

    // Devuelve un mensaje simple según si el estudiante está o no.
    public string RevisarAsistencia(string nombre)
    {
        if (EstáPresente(nombre))
            return $"El estudiante '{nombre}' está presente.";
        else
            return $"El estudiante '{nombre}' no está presente.";
    }
}