class ProductosGUI
{
    public ProductosGUI()
    {
    }

    ProductosDAO PDAO = new ProductosDAO();
    ProductosBO PBO = new ProductosBO();

    public void iniciarPrograma()
    {
        elegirOpcion();
    }

    private void elegirOpcion()
    {
        char opcion = 'z';

        do
        {
            Console.WriteLine("Bienvenido al sistema de SuperMercado");
            Console.WriteLine("¿Que desea realizar?");
            Console.WriteLine("[1] Añadir producto");
            Console.WriteLine("[2] Mostrar productos");
            Console.WriteLine("[3] Retirar producto");
            Console.WriteLine("[4] Mostrar cantidad de productos disponibles");
            Console.WriteLine("[5] Mostrar cantidad de productos retirados");
            Console.WriteLine("[s] salir");
            opcion = char.Parse(Console.ReadLine());

            switch(opcion)
            {
                case '1':
                    añadirProducto();
                    break;
                case '2':
                    mostrarProductos();
                    break;
                case '3':
                    retirarProductos();
                    break;
                case '4':
                    productosDisponibles();
                    break;
                case '5':
                    productosRetirados();
                    break;
            }

        }while(opcion != 's');

    }

    //---------------------------------------------Metodos-------------------------------------------------------

    //------------------------------- Metodo añadir producto ----------------------------------------------------

    LinkedList<ProductosDAO> ListaProductosDAO = new LinkedList<ProductosDAO>();

    int contador = 1;
    
    private void añadirProducto()
    {
        Console.Clear();
        Console.WriteLine("Añadir producto");
        Console.WriteLine("Ingrese los datos solicitados");
        Console.WriteLine("-----------------------------------------------------------------------");
        Console.WriteLine("Ingrese el codigo del producto");
        PDAO.Codigo = int.Parse(Console.ReadLine());
        PDAO.Cantidad = PBO.cantidadRandom();
        PDAO.Precio = PBO.precioRandom();
        PDAO.Nombre = ($"Producto {contador++}");
        // Console.WriteLine(PDAO.Codigo);
        // Console.WriteLine(PDAO.Cantidad);
        // Console.WriteLine(PDAO.Precio);
        // Console.WriteLine(PDAO.Nombre);
        ListaProductosDAO = PBO.añadirNodo(PDAO.Codigo, PDAO.Cantidad, PDAO.Precio, PDAO.Nombre);
        ListaProductosDAO = PBO.pedirLista(ListaProductosDAO);

        Console.ReadKey();
    }

    
    //----------------------------------------- Metodo para visualizar Productos ----------------------------------

    private void mostrarProductos()
    {
        if (ListaProductosDAO.Count != 0)
        {
            Console.Clear();
            Console.WriteLine("...................................... Lista de Productos  ...................................");

            int contadorProductos = 1;
            foreach(ProductosDAO Productos in ListaProductosDAO)
            {
                Console.WriteLine($"{contadorProductos}.- Codigo del Producto: {Productos.Codigo}, Nombre del Producto: {Productos.Nombre}, Cantidad del Producto: {Productos.Cantidad}, Precio del Producto: {Productos.Precio}");
                contadorProductos++;
            }
            Console.ReadKey();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Aun no se agregan productos");
            Console.ReadKey();
            Console.Clear();
        }
    }

    //----------------------------------------------------- Retirar productos -------------------------------------

    public void retirarProductos()
    {
        Console.WriteLine("inserte el código del producto del cual desea hacer retiros");
        int codi = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserte la cantidad que desee retirar");
        int PR = int.Parse(Console.ReadLine());
        int cantidadRetirada = PBO.restarProductos(ListaProductosDAO, codi, PR);
        Console.WriteLine("La cantidad retirada es {0}", PR);
        Console.ReadKey();
    }

    //----------------------------------------------------- Mostrar productos retirados ---------------------------

    public void productosRetirados()
    {
        if (ListaProductosDAO.Count != 0)
        {
            Console.Clear();
            Console.WriteLine("...................................... Productos Retirados  ...................................");

            int contadorProductos = 1;
            foreach(ProductosDAO Productos in ListaProductosDAO)
            {
                Console.WriteLine($"{contadorProductos}.- Codigo del Producto: {Productos.Codigo}, Nombre del Producto: {Productos.Nombre}, Cantidad Retirada: {Productos.PR}");
                contadorProductos++;
            }
            Console.ReadKey();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Aun no se agregan productos");
            Console.ReadKey();
            Console.Clear();
        }
    }

    //-------------------------------------------------- Mostrar productos disponibles ----------------------

    public void productosDisponibles()
    {
        if (ListaProductosDAO.Count != 0)
        {
            Console.Clear();
            Console.WriteLine("...................................... Productos Disponibles  ...................................");

            int contadorProductos = 1;
            foreach(ProductosDAO Productos in ListaProductosDAO)
            {
                Console.WriteLine($"{contadorProductos}.- Codigo del Producto: {Productos.Codigo}, Nombre del Producto: {Productos.Nombre}, Cantidad Disponible: {Productos.Cantidad}");
                contadorProductos++;
            }
            Console.ReadKey();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Aun no se agregan productos");
            Console.ReadKey();
            Console.Clear();
        }
    }
}