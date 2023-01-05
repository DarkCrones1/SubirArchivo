class ARBO
{
    public ARBO()
    {
    }

    LinkedList<ARDAO> listaAlumnos = new LinkedList<ARDAO>();

    public LinkedList<ARDAO> crearAlumno(string nombre, string apellido, int calificacion)
    {
        LinkedList<ARDAO> Alumno = new LinkedList<ARDAO>();

        Alumno.AddFirst(new ARDAO(){Nombre = nombre, Apellido = apellido, Calificacion = calificacion});

        return Alumno;
    }

    public LinkedList<ARDAO> agregarLista(LinkedList<ARDAO> Alumno)
    {
        foreach(ARDAO alumno in Alumno)
        {
            listaAlumnos.AddLast(alumno);
        }
        return listaAlumnos;
    }

    public LinkedList<ARDAO> crearLA(LinkedList<ARDAO> listacompleta)
    {
        LinkedList<ARDAO> listaAprobados = new LinkedList<ARDAO>();
        foreach(ARDAO estudiante in listacompleta)
        {
            if(estudiante.Calificacion >= 7)
            {
                listaAprobados.AddLast(estudiante);
            }
        }
        return listaAprobados;
    }

    public LinkedList<ARDAO> crearLR(LinkedList<ARDAO> listacompleta)
    {
        LinkedList<ARDAO> listaReprobados = new LinkedList<ARDAO>();
        foreach(ARDAO estudiante in listacompleta)
        {
            if(estudiante.Calificacion < 7)
            {
                listaReprobados.AddLast(estudiante);
            }
        }
        return listaReprobados;
    }
}