class EOproductosGUI
{
    public EOproductosGUI()
    {
    }

    EOproductosDAO EODAO = new EOproductosDAO();
    EOproductosBO EOBO = new EOproductosBO();
    CompraDAO CDAO = new CompraDAO();

    public void iniciarVenta()
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
            Console.WriteLine("[3] Commprar Productos");
            Console.WriteLine("[4] Mostrar ticket específico");
            Console.WriteLine("[5] Mostrar tickets de compra");
            Console.WriteLine("[s] salir");
            opcion = char.Parse(Console.ReadLine());

            switch(opcion)
            {
                case '1':
                    agregarProducto();
                    break;
                case '2':
                    mostrarProductos();
                    break;
                case '3':
                    generarCompra();
                    break;
                case '4':
                    mostrarTickets();
                    break;
                case '5':
                    listarTickets();
                    break;
            }

        }while(opcion != 's');

    }

    LinkedList<EOproductosDAO> listaProductos = new LinkedList<EOproductosDAO>();
    LinkedList<CompraDAO> listaTickets = new LinkedList<CompraDAO>();

    private void agregarProducto()
    {
        Console.WriteLine("Inserte los datos solicitados");
        Console.WriteLine("Clave del producto");
        EODAO.Clave = int.Parse(Console.ReadLine());
        Console.WriteLine("Nombre del producto:");
        EODAO.Nombre = Console.ReadLine();
        Console.WriteLine("Cantidad del producto:");
        EODAO.Cantidad = int.Parse(Console.ReadLine());
        Console.WriteLine("Precio del producto:");
        EODAO.Precio = int.Parse(Console.ReadLine());

        listaProductos = EOBO.crearProducto(EODAO.Clave, EODAO.Nombre, EODAO.Cantidad, EODAO.Precio);
        listaProductos = EOBO.pedirLista(listaProductos);
        Console.ReadKey();
    }

    private void mostrarProductos()
    {
        if (listaProductos.Count != 0)
        {
            Console.Clear();
            Console.WriteLine("...................................... Lista de Productos  ...................................");

            int contadorProductos = 1;
            foreach(EOproductosDAO Productos in listaProductos)
            {
                Console.WriteLine($"{contadorProductos}.- Codigo del Producto: {Productos.Clave}, Nombre del Producto: {Productos.Nombre}, Cantidad del Producto: {Productos.Cantidad}, Precio del Producto: {Productos.Precio}");
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

    private void comprarProducto(int ticket)
    {
        int claveP;
        int cantidadDisponible;
        int cantidadCompra;
        LinkedList<CompraDAO> Ticket = new LinkedList<CompraDAO>();
        Console.WriteLine("Realizará una compra, inserte los datos solicitados a continuacion");
        Console.WriteLine("Inserte la clave del producto");
        claveP = int.Parse(Console.ReadLine());
        cantidadDisponible = EOBO.solicitarCantidad(claveP, listaProductos);
        Console.WriteLine("La cantidad disponible es: {0}", cantidadDisponible);
        Console.WriteLine("Inserte la cantidad que desea comprar:");
        cantidadCompra = int.Parse(Console.ReadLine());
        
        foreach(EOproductosDAO producto in listaProductos)
        {
            if (claveP == producto.Clave)
            {
                EOBO.restarProductos(listaProductos, claveP, cantidadCompra);
                CDAO.Costo = cantidadCompra*producto.Precio;
                Console.WriteLine("El costo total del producto {0} es: {1}", producto.Nombre, CDAO.Costo);
                listaTickets = EOBO.generarTicket(producto.Nombre, ticket,cantidadCompra, CDAO.Costo);
                
            }
        }
    } 

    int compra = 1;
    private void generarCompra()
    {
        char opcionCompra = 'z';
        do
        {
            CDAO.NTicket = compra;
            Console.WriteLine("[1] Comprar");
            Console.WriteLine("[s] salir");
            opcionCompra = char.Parse(Console.ReadLine());
            
            switch(opcionCompra)
            {
                case '1':
                    comprarProducto(CDAO.NTicket);
                break;
            }
        }while(opcionCompra != 's');
        compra++;
    }

    private void mostrarTickets()
    {
        if (listaTickets.Count != 0)
        {
            Console.Clear();
            Console.WriteLine("...................................... Lista de Ventas  ...................................");

            int contadorProductos = 1;
            int contador = 1;
            Console.WriteLine("Inserte el numero de ticket");
            int numeroticket = int.Parse(Console.ReadLine());

            var listaOrdenada = listaTickets.OrderBy(x => x.Nombre).ToList();
            
            foreach(CompraDAO ventas in listaOrdenada)
            {
                if (numeroticket == ventas.NTicket)
                {
                    Console.WriteLine($"{contadorProductos}.-Nombre del Producto: {ventas.Nombre}, Cantidad del Producto: {ventas.Cantidad}, Precio del Producto: {ventas.Precio}");
                }
                
            }
            contadorProductos++;
            Console.ReadKey();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Aun no se agregan ventas");
            Console.ReadKey();
            Console.Clear();
        }
    }

    private void listarTickets()
    {
        Console.WriteLine("Lista de ventas");
        int contador = 1;
        foreach(CompraDAO venta in listaTickets)
        {
            if (venta.NTicket == contador)
            {
                Console.WriteLine("Numero de ticket: {0}", venta.NTicket);
                contador++;
            }
        }
    }
}