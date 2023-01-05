class ParesImparesGUI
{
    public ParesImparesGUI()
    {
    }

    ParesImparesDAO PIDAO = new ParesImparesDAO();
    ParesImparesBO PIBO = new ParesImparesBO();

    public void iniciarParesImpares()
    {
        LinkedList<int> listaNumeros = new LinkedList<int>();
        LinkedList<int> listaPares = new LinkedList<int>();
        LinkedList<int> listaImpares = new LinkedList<int>();

        Console.WriteLine("Inserte la cantidad de numeros en la lista");
        int cantidad = int.Parse(Console.ReadLine());

        
        listaNumeros = PIBO.listaNumeros(cantidad);
        listaPares = PIBO.listaPares(listaNumeros);
        listaImpares = PIBO.listaImpares(listaNumeros);
        IEnumerable<int> numerosOrdenadosP;
        IEnumerable<int> numerosOrdenadosI;

        numerosOrdenadosP = listaPares.Where(x => x>0).OrderBy(x => x);
        numerosOrdenadosI = listaImpares.Where(x => x>0).OrderBy(x => x);

        Console.WriteLine("Lista completa");
        for(LinkedListNode<int> nodo = listaNumeros.First; nodo!=null; nodo = nodo.Next)
        {
            int numero = nodo.Value;

            Console.Write("[{0}]----->", numero);
        }
        Console.WriteLine("");
        Console.WriteLine("Lista Numeros Pares");
        foreach(int numerosP in numerosOrdenadosP)
        {
            
            Console.Write("[{0}]----->", numerosP);
        }
        Console.WriteLine("");
        Console.WriteLine("Lista Numeros Impares");
        foreach(int numerosI in numerosOrdenadosI)
        {
            Console.Write("[{0}]----->", numerosI);
        }

    }
}