static void Main(string[] args)
{

    NavesEstelares [] naves = NavesEstelares (5);
    bool salir = false;
    int contadorNaves = 0;
    
    
    
     while (!salir)
    {
        Console.WriteLine("=== SISTEMA DE FABRICACIÓN DE NAVES ESTELARES ===");
        Console.WriteLine("1. Crear una nave");
        Console.WriteLine("2. Cambiar el nombre de la nave");
        Console.WriteLine("3. Listar todas las naves");        
        Console.WriteLine("4. Eliminar todas las naves");
        Console.WriteLine("5. Salir del menú");
        int opcion = Convert.ToInt32(Console.ReadLine());

        while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
        {
            Console.WriteLine("Opción inválida. Intenta de nuevo (1-5):");
        }


        switch (opcion)
        {
            case 1: // CREAR
            Console.WriteLine("Has elegido la opción 1");

            string [] Nombres = {"HALCONMILNEARIO", "CAZAESTELAR", "SUPERDESTRUCTOR", "YWING", "XWING"};
            Random generador = new Random (0,4);
            int indiceAleatorio = generador.Next(nombres.Length);
            string nombreElegido = Nombres[indiceAleatorio];
               
            Random Numero = new Random();
            int NumeroAleatorio = generador.Next(10-99);
            int numeroElegido = Numero[NumeroAleatorio];
            Console.WriteLine("✓ Nave Creada:" + nombreElegido + "-" + numeroElegido);
            break;

            case 2: // CAMBIAR NOMBRE
             Console.WriteLine("Has elegido la opción 2");
             Console.WriteLine($"el nombre de tu nave es {nombreElegido} - {numeroElegido}, quieres cambiar el nombre (s/n)?");
             string respuesta = Console.ReadLine();

            if (respuesta=="s"||respuesta=="S");
            {
               Console.Write("✓ Nave renombrada: ");
             naves = Console.ReadLine();
            }
                break;

            case 3: // LISTAR NAVES
                Console.WriteLine("Has elegido la opción 3");
                Console.WriteLine($"=== NAVES FABRICADAS ===");

                foreach (var naves in navesEstelares) {
                    
                }
                Console.WriteLine();

                break;
            case 4: // BORRAR UNA O TOLAS
Console.WriteLine("Quieres borrar tu nave, (s/n)?");
             string respuesta = Console.ReadLine();
        if (respuesta=="s"||respuesta=="S"); 
        else (respuesta=="n"||respuesta =="N");


                Console.WriteLine("Has elegido salir de la aplicación");
                
                salir = true;
                
                break;
            default: // SALIR
                Console.WriteLine("Elige una opcion entre 1 y 4");
                break;
        }
    }

}



