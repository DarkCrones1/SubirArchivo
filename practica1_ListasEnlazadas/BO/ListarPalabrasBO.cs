class ListarPalabrasBO
{
    public ListarPalabrasBO()
    {
    }

    ListarPalabraDAO LDAO = new ListarPalabraDAO();
    

    // public LinkedList<LinkedList<string>> AgregarPalabra(string palabra)
    // {
    //     if (LDAO.ListaPrincipal.Count == 0)
    //     {
    //         LinkedListNode<string> nuevaPalabra = new LinkedListNode<string>(palabra);
    //         LinkedList<string> nuevaLista = new LinkedList<string>();
    //         nuevaLista.AddFirst(nuevaPalabra);

    //         LinkedListNode<LinkedList<string>> nuevaListaAgregada = new LinkedListNode<LinkedList<string>>(nuevaLista);
    //         LDAO.ListaPrincipal.AddLast(nuevaListaAgregada);

    //         return LDAO.ListaPrincipal;
    //     }

    //     for (LinkedListNode<LinkedList<string>> nodo = LDAO.ListaPrincipal.First; nodo != null; nodo = nodo.Next)
    //     {
    //         LinkedList<string> lista = nodo.Value;

    //         if (lista.First.Value[0] == palabra[0])
    //         {
    //             LinkedListNode<string> pa = new LinkedListNode<string>(palabra);
    //             lista.AddLast(pa);
    //             break;
    //         }

    //         LinkedListNode<string> nuevaPalabra = new LinkedListNode<string>(palabra);
    //         LinkedList<string> nuevaLista = new LinkedList<string>();
    //         nuevaLista.AddFirst(nuevaPalabra);

    //         LinkedListNode<LinkedList<string>> nuevaListaAgregada = new LinkedListNode<LinkedList<string>>(nuevaLista);
    //         LDAO.ListaPrincipal.AddLast(nuevaListaAgregada);
    //     }

    //     return LDAO.ListaPrincipal;
    // }
}