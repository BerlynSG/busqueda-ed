public class Calificaciones
{
    public int[] notas;

    public Calificaciones(int[] notas)
    {
        this.notas = notas;
    }

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

    public string RevisarNota(int notaBuscada)
    {
        int posicion = BuscarNota(notaBuscada);

        if (posicion != -1)
            return $"Hay un estudiante con la calificación {notaBuscada}.";

        return $"No hay ningún estudiante con la calificación {notaBuscada}.";
    }
}
