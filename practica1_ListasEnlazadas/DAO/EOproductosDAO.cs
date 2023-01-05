public class EOproductosDAO
{
    private string nombre = "";
    private int clave = 0;
    private int precio = 0;
    private int cantidad = 0;
    private int pr;

    public string Nombre {get{return nombre;} set{nombre = value;}}
    public int Clave {get{return clave;} set{clave = value;}}
    public int Precio {get{return precio;} set{precio = value;}}
    public int Cantidad {get{return cantidad;} set{cantidad = value;}}
    public int PR {get{return pr;} set{pr = value;}}
}

public class CompraDAO:EOproductosDAO
{
    private int nTicket;
    private int costo;
    
    public int NTicket {get{return nTicket;} set{nTicket = value;}}
    public int Costo {get{return costo;} set{costo = value;}}
    
}