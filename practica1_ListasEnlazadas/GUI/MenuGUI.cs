class MenuGUI
    {
        public MenuGUI()
        {
        }

        ProductosGUI PGUI = new ProductosGUI();
        ParesImparesGUI PIGUI = new ParesImparesGUI();
        ARGUI ARGUI = new ARGUI();
        EOproductosGUI EOGUI = new EOproductosGUI();
        //ListarPalabrasGUI LGUI = new ListarPalabrasGUI();

        public void iniciarMenu()
        {

            char option = 'z';
            Console.Clear();
            Console.WriteLine("Elija una opcion");
            Console.WriteLine("[1] Productos disponibles y retirados");
            Console.WriteLine("[2] Pares e impares");
            Console.WriteLine("[3] Aprobados y Reprobados");
            Console.WriteLine("[4] Eliminar y Ordenar productos");
            Console.WriteLine("[5] Ordenar Palabras");
            Console.WriteLine("[S] Salir");
            try
            {
                option = char.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Elija una opcion dentro de las posibles");
                Console.ReadKey();
                Console.Clear();
            }

            Console.Clear();

            switch(option)
            {
                case '1':
                    PGUI.iniciarPrograma();
                    Console.ReadKey();
                break;
                case '2':
                    PIGUI.iniciarParesImpares();
                    Console.ReadKey();
                break;
                case '3':
                    ARGUI.iniciarAR();
                    Console.ReadKey();
                break;
                case '4':
                    EOGUI.iniciarVenta();
                    Console.ReadKey();
                break;
                case '5':
                    //LGUI.iniciarListarPalabras();
                    Console.ReadKey();
                break;
            }
        }
    }