public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Revisar asistencia");
        Console.WriteLine("2. Revisar producto agotado");
        Console.WriteLine("3. Buscar calificación específica");
        string? opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                RevisarAsistencia();
                break;
            case "2":
                RevisarProducto();
                break;
            case "3":
                RevisarCalificacion();
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }

    static void RevisarAsistencia()
    {
        string[] nombres = { "Juan", "María", "Pedro", "Ana" };
        var asistencia = new Asistencia(nombres);

        string? nombre = LeerEntrada("Ingrese el nombre del estudiante:");

        if (nombre == string.Empty) return;
        Console.WriteLine(asistencia.RevisarAsistencia(nombre));
    }

    static void RevisarProducto()
    {
        string[] productosAgotados = { "pan", "leche", "arroz", "azúcar" };
        var productos = new Productos(productosAgotados);

        string? producto = LeerEntrada("Ingrese el nombre del producto:");

        if (producto == string.Empty) return;
        Console.WriteLine(productos.RevisarProducto(producto));
    }

    static void RevisarCalificacion()
    {
        int[] notas = { 60, 70, 80, 90, 100 };
        var calificaciones = new Calificaciones(notas);

        string? entrada = LeerEntrada("Ingrese la calificación a buscar:");

        if (entrada == string.Empty) return;

        if (int.TryParse(entrada, out int notaBuscada))
        {
            Console.WriteLine(calificaciones.RevisarNota(notaBuscada));
        }
        else
        {
            Console.WriteLine("La calificación debe ser un número entero.");
        }
    }

    static string LeerEntrada(string mensaje){
        Console.WriteLine(mensaje);
        string? entrada = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("No se ingresó nada.");
            return string.Empty;
        }

        return entrada;
    } 
}