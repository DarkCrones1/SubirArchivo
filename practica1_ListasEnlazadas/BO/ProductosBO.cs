class ProductosBO
{
    public ProductosBO()
    {
    }


    ProductosDAO PDAO = new ProductosDAO();


    //--------------------------------------------- Cantidad Random -----------------------------------------------

    public int cantidadRandom()
    {
        var seed = Environment.TickCount;
        var random = new Random(seed);
        return random.Next(1,20);
    }

    public int precioRandom()
    {
        var seed = Environment.TickCount;
        var random = new Random(seed);
        return random.Next(50,500);
    }


    //--------------------------------------------- crear lista de productos ----------------------------------


    LinkedList<ProductosDAO> ListaProductos2 = new LinkedList<ProductosDAO>();

    public LinkedList<ProductosDAO> añadirNodo(int codigo, int cantidad, double precio, string nombre)
    {
        LinkedList<ProductosDAO> ListaProductos = new LinkedList<ProductosDAO>();

        ListaProductos.AddFirst(new ProductosDAO(){Codigo = codigo, Cantidad = cantidad, Precio = precio, Nombre = nombre});

        return ListaProductos;
    }

    public LinkedList<ProductosDAO> pedirLista(LinkedList<ProductosDAO> listaCompleta)
    {
        foreach (ProductosDAO producto in listaCompleta)
        {
            ListaProductos2.AddLast(producto);
        }

        return ListaProductos2;
    }

    //------------------------------------------- Limpiar lista --------------------------------------------------
    public void limpiarLista(LinkedList<ProductosDAO> ListaProductosDAO)
    {
        ListaProductosDAO.Clear();
    }

    //------------------------------------------- Retirar productos -----------------------------------------------

    public int restarProductos(LinkedList<ProductosDAO> listaProductosDAO, int codi, int PR)
    {
        int cantidad = 0;
        foreach(ProductosDAO productos in listaProductosDAO)
        {
            if (codi == productos.Codigo)
            {
                cantidad = productos.Cantidad - PR;
                productos.Cantidad = cantidad;
                productos.PR = productos.PR + PR;
            }
        }
        return cantidad;
    }
}