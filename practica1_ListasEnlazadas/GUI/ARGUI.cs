class ARGUI
{
    public ARGUI()
    {
    }

    ARDAO ARDAO = new ARDAO();
    ARBO ARBO = new ARBO();

    public void iniciarAR()
    {
        elegirOpcion();
    }

    private void elegirOpcion()
    {
        char opcion = 'z';

        do
        {
            Console.WriteLine("Bienvenido al sistema de Estudiantes Aprobados y Reprobados");
            Console.WriteLine("¿Que desea realizar?");
            Console.WriteLine("[1] Añadir Estudiante");
            Console.WriteLine("[2] Mostrar Lista Estudiantes");
            Console.WriteLine("[3] Mostrar Lista Estudiantes Aprobados");
            Console.WriteLine("[4] Mostrar Lista de Estudiantes Reprobados");
            Console.WriteLine("[s] salir");
            opcion = char.Parse(Console.ReadLine());

            switch(opcion)
            {
                case '1':
                    agregarEstudiante();
                    break;
                case '2':
                    mostrarLista(listaAlumnos);
                    break;
                case '3':
                mostrarLA(listaAprobados);
                    break;
                case '4':
                mostrarLR(listaReprobados);
                    break;
            }

        }while(opcion != 's');

    }

    LinkedList<ARDAO> listaAlumnos = new LinkedList<ARDAO>();
    LinkedList<ARDAO> listaAprobados = new LinkedList<ARDAO>();
    LinkedList<ARDAO> listaReprobados = new LinkedList<ARDAO>();

    private void agregarEstudiante()
    {

        Console.WriteLine("A continuación inserte los datos necesarios");
        Console.WriteLine("Nombre");
        ARDAO.Nombre = Console.ReadLine();
        Console.WriteLine("Apellido");
        ARDAO.Apellido = Console.ReadLine();
        Console.WriteLine("Calificacion");
        ARDAO.Calificacion = int.Parse(Console.ReadLine());

        listaAlumnos = ARBO.crearAlumno(ARDAO.Nombre, ARDAO.Apellido, ARDAO.Calificacion);
        listaAlumnos = ARBO.agregarLista(listaAlumnos);
        listaAprobados = ARBO.crearLA(listaAlumnos);
        listaReprobados = ARBO.crearLR(listaAlumnos);
    }

    private void mostrarLista(LinkedList<ARDAO> listaAlumnos)
    {
        Console.WriteLine("Lista de Estudiantes");
        foreach(ARDAO estudiante in listaAlumnos)
        {
            Console.WriteLine($"Alumno: {estudiante.Nombre} {estudiante.Apellido}, Calificacion: {estudiante.Calificacion}");
        }
    }

    private void mostrarLA(LinkedList<ARDAO> listaAprobado)
    {
        Console.WriteLine("Lista de alumnos Aprobados");
        foreach(ARDAO estudiante in listaAprobado)
        {
            Console.WriteLine($"Alumno: {estudiante.Nombre} {estudiante.Apellido}, Calificacion: {estudiante.Calificacion}");
        }
    }

    private void mostrarLR(LinkedList<ARDAO> listaReprobados)
    {
        Console.WriteLine("Lista de alumnos Aprobados");
        foreach(ARDAO estudiante in listaReprobados)
        {
            Console.WriteLine($"Alumno: {estudiante.Nombre} {estudiante.Apellido}, Calificacion: {estudiante.Calificacion}");
        }
    }

}