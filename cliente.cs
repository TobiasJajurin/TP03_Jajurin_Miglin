class cliente 
{
    public int DNI {get; private set;}
    public string APELLIDO { get; private set; }   
    public string NOMBRE  { get; private set; }
    public DateTime FECHAINSCRIPCCION { get; set; }
    public int TIPOENTRADA { get; set; }
    public int CANTIDAD {get; set;}

     public cliente (int dni, string apellido, string nombre, int tipoEntrada, DateTime fecha, int cantidad )
    {
        DNI = dni;
        APELLIDO = apellido;
        NOMBRE = nombre;
        FECHAINSCRIPCCION = fecha ;
        TIPOENTRADA = tipoEntrada;
        CANTIDAD = cantidad;

    }


}