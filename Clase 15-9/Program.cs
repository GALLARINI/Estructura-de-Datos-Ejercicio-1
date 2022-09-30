
        while (true)
        {
            //Menu Principal
      
            int opcion = MenuPrincipal.Mostrar();//Devuelve de 0-5

            if (opcion == 1)
            {
                RegistrosPersonas.Alta();
            }
            else if (opcion == 2)

            {
                RegistrosPersonas.Baja();
            }
            else if (opcion == 3)
            {
                RegistrosPersonas.MostrarLista();
            }
            else if (opcion == 4)
            {
                RegistrosPersonas.Grabar();
            }
            else if (opcion == 5)
            {
                RegistrosPersonas.Cargar();
            }
            else if (opcion == 0)//Salir del sistema
            {
                return;
            }
            else
            {
                //Esto no deberia pasa nunca => si pasa tiro un error
                throw new ApplicationException("Opcion Invalida");
            }
        Console.WriteLine("---------------------------------------------");
        }
