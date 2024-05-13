public static class ticketera
{
    private static Dictionary<int, cliente> dicClientes = new Dictionary<int, cliente>();
    
    private static int UltimoIDEntrada = 0;

    public static int devolverUltimoId (int UltimoIDEntrada)
    {
        return UltimoIDEntrada++;
    }

    public static int agregarCliente (cliente cliente1)
    {
        dicClientes.Add(devolverUltimoId(UltimoIDEntrada),cliente1);
        return UltimoIDEntrada;
    }
    public static cliente buscarCliente (int idBuscado)
    {
        cliente clienteBuscado = null;
        if (dicClientes.ContainsKey(idBuscado))
        {
            clienteBuscado = dicClientes[idBuscado];
            
        }
          return clienteBuscado;

    }
    
    public static void CambiarEntrada (int idCambio, int entradaCambio, DateTime fechaCambio,  int cantidadCambio, double abono )
    {
        double abonoCambio;
        abonoCambio = guardarImporte (entradaCambio, cantidadCambio);
        if(dicClientes.ContainsKey(idCambio) && abonoCambio > abono )
        {
        dicClientes[idCambio].TIPOENTRADA = entradaCambio;
        dicClientes[idCambio].FECHAINSCRIPCCION = fechaCambio;
        
        }
        

    }
      public static double guardarImporte(int tipoEntrada, int cantidad)
    {    double abono=0;
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
}
