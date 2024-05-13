public static class ticketera
{
    private static Dictionary<int, cliente> dicClientes = new Dictionary<int, cliente>();

    private static int UltimoIDEntrada = 0;

    public static int devolverUltimoId(int UltimoIDEntrada)
    {
        return UltimoIDEntrada++;
    }

    public static int agregarCliente(cliente cliente1)
    {
        dicClientes.Add(devolverUltimoId(UltimoIDEntrada), cliente1);
        return UltimoIDEntrada;
    }
    public static cliente buscarCliente(int idBuscado)
    {
        cliente clienteBuscado = null;
        if (dicClientes.ContainsKey(idBuscado))
        {
            clienteBuscado = dicClientes[idBuscado];

        }
        return clienteBuscado;

    }

    public static bool CambiarEntrada(int idCambio, int entradaCambio, DateTime fechaCambio, int cantidadCambio, double abono)
    {
        double abonoCambio;
        bool h = false;
        abonoCambio = guardarImporte(entradaCambio, cantidadCambio);
        if (dicClientes.ContainsKey(idCambio) && abonoCambio > abono)
        {
            dicClientes[idCambio].TIPOENTRADA = entradaCambio;
            dicClientes[idCambio].FECHAINSCRIPCCION = fechaCambio;

            h = true;
        }
        return h;

    }
    public static double guardarImporte(int tipoEntrada, int cantidad)
    {
        double abono = 0;
        switch (tipoEntrada)
        {
            case 1:
                abono = 45000 * cantidad;

                break;

            case 2:
                abono = 60000 * cantidad;
                break;

            case 3:
                abono = 30000 * cantidad;
                break;

            case 4:
                abono = 100000 * cantidad;
                break;

        }
        return abono;

    }
    public static int[] calcularEntradas(int tipoEntrada, int cantidadEntradas)
    {

        int[] array1 = new int[4];

        switch (tipoEntrada)
        {
            case 1:
                array1[0] += cantidadEntradas;
                break;

            case 2:
                array1[1] += cantidadEntradas;
                break;

            case 3:
                array1[2] += cantidadEntradas;
                break;

            case 4:
                array1[3] += cantidadEntradas;
                break;

        }
        return array1;
    }

    public static int[] calcularRecaudacion(int[] array)
    {

        int[] array1 = new int[4];

        array1[0] = array[0] * 45000;
        array1[1] = array[1] * 60000;
        array1[2] = array[2] * 30000;
        array1[3] = array[3] * 100000;
        return array1;
    }

    public static void EstadisticasTicketera()
    {
        int[] array5 = new int [4];
        int[] array1 = new int[4];

        Console.WriteLine("Hay " + dicClientes.Count + " clientes inscriptos");
        foreach (cliente c in dicClientes.Values)
        {
            array5[c.TIPOENTRADA-1]++;
            
        }
      Console.WriteLine (  array5[0] ) ;
      Console.WriteLine (  array5[1] ) ;
      Console.WriteLine (  array5[2] ) ;
      Console.WriteLine (  array5[3] ) ;

        array1[0] = array5[0] * 45000;
        array1[1] = array5[1] * 60000;
        array1[2] = array5[2] * 30000;
        array1[3] = array5[3] * 100000;

      Console.WriteLine (  array1[0] ) ;
      Console.WriteLine (  array1[1] ) ;
      Console.WriteLine (  array1[2] ) ;
      Console.WriteLine (  array1[3] ) ;

        Console.WriteLine(array1[0] + array1[1] + array1[2] + array1[3]);

    }


}
