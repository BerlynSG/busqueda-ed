public class Program
{
    // Este programa muestra varios ejemplos de búsqueda en listas.
    public static void Main(string[] args)
    {
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Revisar asistencia");
        Console.WriteLine("2. Revisar producto agotado");
        Console.WriteLine("3. Buscar calificación específica");
        Console.WriteLine("4. Validar código de descuento");
        Console.WriteLine("5. Verificar cliente en registro masivo");
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
            case "4":
                RevisarCodigoDescuento();
                break;
            case "5":
                RevisarCliente();
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }

    // Revisa si un nombre está en la lista de asistencia.
    static void RevisarAsistencia()
    {
        string[] nombres = { "Juan", "María", "Pedro", "Ana" };
        var asistencia = new Asistencia(nombres);

        string? nombre = LeerEntrada("Ingrese el nombre del estudiante:");

        if (nombre == string.Empty) return;
        Console.WriteLine(asistencia.RevisarAsistencia(nombre));
    }

    // Revisa si un producto está agotado.
    static void RevisarProducto()
    {
        string[] productosAgotados = { "pan", "leche", "arroz", "azúcar" };
        var productos = new Productos(productosAgotados);

        string? producto = LeerEntrada("Ingrese el nombre del producto:");

        if (producto == string.Empty) return;
        Console.WriteLine(productos.RevisarProducto(producto));
    }

    // Busca una calificación en una lista ordenada.
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

    // Valida si un código de descuento existe.
    static void RevisarCodigoDescuento()
    {
        int[] codigosDescuento = { 100, 200, 300, 400, 500 };
        var codigos = new CodigosDescuento(codigosDescuento);

        string? entrada = LeerEntrada("Ingrese el código de descuento:");

        if (entrada == string.Empty) return;

        if (int.TryParse(entrada, out int codigoBuscado))
        {
            Console.WriteLine(codigos.ValidarCodigo(codigoBuscado));
        }
        else
        {
            Console.WriteLine("El código debe ser un número entero.");
        }
    }

    // Busca una cédula en un registro grande de clientes.
    static void RevisarCliente()
    {
        long[] clientes = new long[1005];
        for (int i = 0; i < clientes.Length; i++)
        {
            clientes[i] = 1000000000 + i;
        }

        var registro = new Clientes(clientes);
        string? entrada = LeerEntrada("Ingrese la cédula del cliente:");

        if (entrada == string.Empty) return;

        if (long.TryParse(entrada, out long cedulaBuscada))
        {
            Console.WriteLine(registro.RevisarCliente(cedulaBuscada));
        }
        else
        {
            Console.WriteLine("La cédula debe ser un número válido.");
        }
    }

    // Pide un dato al usuario y lo devuelve como texto.
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