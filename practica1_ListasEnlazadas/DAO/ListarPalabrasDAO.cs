public class ListarPalabraDAO
{
    private LinkedList<string> lista;

    private LinkedList<LinkedList<string>> listaPrincipal;

    public LinkedList<string> Lista {get{return lista;} set{Lista = value;}}

    public LinkedList<LinkedList<string>> ListaPrincipal {get; set;}

    public ListarPalabraDAO()
    {
        ListaPrincipal = new LinkedList<LinkedList<string>>();
        Lista = new LinkedList<string>();
    }
}