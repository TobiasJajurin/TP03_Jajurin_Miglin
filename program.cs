namespace Tp03_Jajurin_Miglin;

class Program
{
    static void Main(string[] args)
    {
        int opccion, dni, tipoEntrada , cantidad, clientesInscriptos = 0;
        int[] cantidadesEntradas = new int [4];
        int[] calculosRecaudacion = new int [4];

        string apellido, nombre;
        double abono=0;
        DateTime fecha;
        cliente cliente;

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
                cantidad = IngresarNatural ("Ingrese su cantidad");
                cliente = new cliente(dni, apellido, nombre, tipoEntrada, fecha, cantidad);
                clientesInscriptos ++;
                abono = ticketera.guardarImporte (tipoEntrada,cantidad);
              
                cantidadesEntradas = ticketera.calcularEntradas(tipoEntrada, cantidad);
                calculosRecaudacion = ticketera.calcularRecaudacion(cantidadesEntradas);
                break;

                case 2:
                ticketera.EstadisticasTicketera (clientesInscriptos, cantidadesEntradas, calculosRecaudacion);
                
                


                break;

                case 3:
                int idBusqueda;
                idBusqueda = IngresarNatural("Ingrese su id");
                ticketera.buscarCliente (idBusqueda);
                break;

                case 4:
                 int idCambio, entradaCambio, cantidadCambio;
                 DateTime fechaCambio;
            
                idCambio = IngresarNatural ("Ingrese su id");
                entradaCambio = IngresarEntrada ("Ingrese su nueva entrada");
                fechaCambio = IngresarFecha ("Ingrese su nueva fecha");
                cantidadCambio = IngresarNatural ("Ingrese su nueva cantidad");
                ticketera.CambiarEntrada (idCambio, entradaCambio, fechaCambio, cantidadCambio, abono);
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
   
  
    public static int IngresarNatural(string m)
    {
        int n;
        do
        {
        Console.WriteLine(m);
        n = int.Parse (Console.ReadLine());
            
        } while (n < 0);
        return n;
       
    }
   

}
