class ParesImparesBO
{
    public ParesImparesBO()
    {
    }

    public LinkedList<int> listaNumeros(int cantidad)
    {
        LinkedList<int> Listanumero = new LinkedList<int>();
        var seed = Environment.TickCount;
        var random = new Random(seed);

        for (int i = 0; i < cantidad; i++)
        {
            LinkedListNode<int> nodo = new LinkedListNode<int>(random.Next(1,20));
            Listanumero.AddLast(nodo);
        }

        return Listanumero;
    }

    public LinkedList<int> listaPares(LinkedList<int> listaNumeros)
    {
        LinkedList<int> listaPares = new LinkedList<int>();
        foreach (int numero in listaNumeros)
        {
            if (numero%2 == 0)
            {
                listaPares.AddLast(numero);
            }
        }
        return listaPares;
    }

    public LinkedList<int> listaImpares(LinkedList<int> listaNumeros)
    {
        LinkedList<int> listaImpares = new LinkedList<int>();
        foreach (int numero in listaNumeros)
        {
            if (numero%2 != 0)
            {
                listaImpares.AddLast(numero);
            }
        }
        return listaImpares;
    }
}