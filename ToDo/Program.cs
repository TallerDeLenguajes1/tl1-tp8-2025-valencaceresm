// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Tp8;

internal class Program
{
    private static void Main(string[] args)
    {
        Tarea tarea1 = new Tarea(1, "tarea1", Estado.Iniciada);
        Tarea tarea2 = new Tarea(2, "tarea2", Estado.Iniciada);
        Tarea tarea3 = new Tarea(3, "tarea3", Estado.Iniciada);
        Tarea tarea4 = new Tarea(4, "tarea4", Estado.Iniciada);
        Tarea tarea5 = new Tarea(5, "tarea5", Estado.Iniciada);

        List<Tarea> tareas = new List<Tarea>(); //Crear una lista vacia de tareas.

        tareas.Add(tarea1);
        tareas.Add(tarea2);
        tareas.Add(tarea3);
        tareas.Add(tarea4);
        tareas.Add(tarea5);

        Console.WriteLine("Cantidad de tareas en la lista " + tareas.Count);

        /*Console.WriteLine("Ingrese un codigo");
        string input = Console.ReadLine();
        int codigo = int.Parse(input);

        bool tareaEncontrada = false;
        foreach (Tarea item in tareas)
        {
            if (item.GetCodigo() == codigo)
            {
                tareaEncontrada = true;
                Console.WriteLine("Tarea encontrada!");
                MostrarTarea(item);
                break;
            }
        }

        if (!tareaEncontrada)
        {
            Console.WriteLine("No se encontro la tarea con el codigo:" + codigo);
        }
        /*--------------------------------------------------------------------*/

        /*Console.WriteLine("Ingrese un codigo");
        string input2 = Console.ReadLine();
        int codigo2 = int.Parse(input2);

        var tareaBuscada = tareas.FirstOrDefault(t => t.Codigo == codigo2);

        if (tareaBuscada is not null) // tareaBuscada != null
        {
            MostrarTarea(tareaBuscada);
        }
        else
        {
            Console.WriteLine("No se encontro la tarea con el codigo:" + codigo2);
        }*/

        Console.WriteLine("------ANTES DEL REMOVE------");

        foreach (var item in tareas)
        {
            MostrarTarea(item);
            Console.WriteLine();
        }

        //0-4
        tareas.Remove(tarea3);

        //0-3
        tareas.RemoveAt(3);

        Console.WriteLine("------DESPUES DEL REMOVE------");

        foreach (var item in tareas)
        {
            MostrarTarea(item);
            Console.WriteLine();
        }
    }
    public static void MostrarTarea(Tarea tarea)
    {
        Console.WriteLine("Codigo:" + tarea.GetCodigo());
        Console.WriteLine("Descripcion:" + tarea.Descrip);
        switch (tarea.Estado)
        {
            case Estado.Iniciada:
                Console.WriteLine("Estado : Iniciado");
                break;
            case Estado.EnProceso:
                Console.WriteLine("Estado : Proceso");
                break;
            case Estado.Terminada:
                Console.WriteLine("Estado : Terminado");
                break;
        }
    }
}