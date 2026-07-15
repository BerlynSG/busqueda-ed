public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Revisar asistencia");
        Console.WriteLine("2. Revisar producto agotado");
        string? opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                RevisarAsistencia();
                break;
            case "2":
                RevisarProducto();
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

        Console.WriteLine("Ingrese un nombre para verificar asistencia:");
        string? nombre = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(nombre))
        {
            bool presente = asistencia.EstáPresente(nombre);
            if (presente)
                Console.WriteLine($"El estudiante '{nombre}' está presente.");
            else
                Console.WriteLine($"El estudiante '{nombre}' no está presente.");
        }
        else
        {
            Console.WriteLine("No se ingresó ningún nombre.");
        }
    }

    static void RevisarProducto()
    {
        string[] productosAgotados = { "pan", "leche", "arroz", "azúcar" };
        var productos = new Productos(productosAgotados);

        Console.WriteLine("Ingrese un producto para revisar si está agotado:");
        string? producto = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(producto))
        {
            Console.WriteLine(productos.RevisarProducto(producto));
        }
        else
        {
            Console.WriteLine("No se ingresó ningún producto.");
        }
    }
}