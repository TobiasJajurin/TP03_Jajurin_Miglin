namespace Tp03_Jajurin_Miglin;

class Program
{
    static void Main(string[] args)
    {
        int opccion, dni, tipoEntrada, cantidad;
        string apellido, nombre;
        DateTime fecha;

        opccion = ingresarOpccion("Ingrese la opccion que desea");
        while (opccion != 5)
        {
            switch (opccion)
            {
                case 1:
                dni = IngresarDni ("Ingrese su dni");
                apellido = IngresarString ("Ingrese su apellido");
                nombre = IngresarString ("Ingrese su nombre");
                tipoEntrada = IngresarEntrada  ("Ingrese su tipo de entrada");
                fecha = IngresarFecha ("Ingrese su fecha");
                cantidad = IngresarCantidad ("Ingrese su cantidad");

                break;

                case 2:
                break;

                case 3:
                break;

                case 4:
                break;
                
            }
        }
    }
    public static int ingresarOpccion (string m)
    {
        int op;
        do
        {
            Console.WriteLine(m);
            op = int.Parse(Console.ReadLine());
            
        } while (op != 1 && op != 2 && op != 3 && op != 4 && op != 5);
        return op;
    }
    public static int IngresarDni (string m)
    {
        int dni;
        do
        {
            Console.WriteLine(m);
            dni = int.Parse(Console.ReadLine());
        } while (dni < 10000000);
        return dni;

    }
    public static string IngresarString (string m)
    {
        Console.WriteLine(m);
        return Console.ReadLine();
    }
    public static int IngresarEntrada (string m)
    {
        int entrada;
        do
        {
            Console.WriteLine(m);
            entrada = int.Parse(Console.ReadLine());
            
        } while (entrada != 1 && entrada != 2 && entrada != 3 && entrada != 4 );
        return entrada;
    }
    public static DateTime IngresarFecha (string m)

    {
        DateTime a;

        Console.WriteLine(m);

        a = DateTime.Parse(Console.ReadLine());
        return a;
    }
    public static int IngresarCantidad (string m)
    {
        int cant;
        do
        {
            Console.WriteLine(m);
            cant = int.Parse(Console.ReadLine());
            
        } while (cant <0);
        return cant;
    }
    
}
