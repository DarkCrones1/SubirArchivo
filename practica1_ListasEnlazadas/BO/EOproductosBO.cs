class EOproductosBO
{
    public EOproductosBO()
    {
    }

    EOproductosDAO EODAO = new EOproductosDAO();

    LinkedList<EOproductosDAO> listaProductos = new LinkedList<EOproductosDAO>();
    LinkedList<CompraDAO> listaTickets = new LinkedList<CompraDAO>();

    public LinkedList<EOproductosDAO> crearProducto(int clave, string nombre, int cantidad, int precio)
    {
        LinkedList<EOproductosDAO> productoNuevo = new LinkedList<EOproductosDAO>();

        productoNuevo.AddFirst(new EOproductosDAO(){Clave = clave, Nombre = nombre, Cantidad = cantidad, Precio = precio});

        return productoNuevo;
    }

    public LinkedList<EOproductosDAO> pedirLista(LinkedList<EOproductosDAO> lista)
    {
        foreach(EOproductosDAO articulo in lista)
        {
            listaProductos.AddLast(articulo);
        }

        return listaProductos;
    }

    public int restarProductos(LinkedList<EOproductosDAO> listaProductos, int clave, int PR)
    {
        int cantidad = 0;
        foreach(EOproductosDAO productos in listaProductos)
        {
            if (clave == productos.Clave)
            {
                cantidad = productos.Cantidad - PR;
                productos.Cantidad = cantidad;
                productos.PR = productos.PR + PR;
            }
        }
        return cantidad;
    }

    public int solicitarCantidad(int clave, LinkedList<EOproductosDAO> listaCompleta)
    {
        int cantidadDisponible = 0;
        foreach(EOproductosDAO producto in listaCompleta)
        {
            if (clave == producto.Clave)
            {
                cantidadDisponible = producto.Cantidad;
            }
        }
        return cantidadDisponible;
    }

    public LinkedList<CompraDAO> generarTicket(string nombre, int ticket, int cantidad, int costo)
    {
        

        listaTickets.AddLast(new CompraDAO(){NTicket = ticket, Nombre = nombre, Cantidad = cantidad, Precio = costo});

        return listaTickets;
    }

    

}