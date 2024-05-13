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
    
}
