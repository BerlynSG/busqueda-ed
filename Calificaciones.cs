public class Calificaciones
{
    // Guarda la lista de calificaciones ordenadas.
    public int[] notas;

    public Calificaciones(int[] notas)
    {
        this.notas = notas;
    }

    // Busca una nota en la lista de forma ordenada.
    public int BuscarNota(int notaBuscada)
    {
        int inicio = 0;
        int fin = notas.Length - 1;

        while (inicio <= fin)
        {
            int medio = inicio + (fin - inicio) / 2;

            if (notas[medio] == notaBuscada)
                return medio;

            if (notas[medio] < notaBuscada)
                inicio = medio + 1;
            else
                fin = medio - 1;
        }

        return -1;
    }

    // Da un mensaje según si la nota aparece o no.
    public string RevisarNota(int notaBuscada)
    {
        int posicion = BuscarNota(notaBuscada);

        if (posicion != -1)
            return $"Hay un estudiante con la calificación {notaBuscada}.";

        return $"No hay ningún estudiante con la calificación {notaBuscada}.";
    }
}
