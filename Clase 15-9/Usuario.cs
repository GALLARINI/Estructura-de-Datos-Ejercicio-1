using System.Net.Http.Headers;

internal class Usuario
{
 /*   public static int PedirEntero(int min, int max)
    {
        bool flag = false;
        int salida;
        do
        {
            if (!int.TryParse(Console.ReadLine(), out salida))
            {
                Console.WriteLine("El campo debe ser un valor numerico");
            }
            else if (salida < min || salida > max)
            {
                Console.WriteLine($"El campo esta fuera de los limetes minimo: {min} o maximo:{max}");
                Console.Write("Ingrese nuevamente el valor solicitado: ");
            }
            else
            {
                flag = true;
            }
        }while (flag==false);

        return salida;
    }
 */
    //Version 2
    public static int PedirEntero(string mensaje,int min, int max)
    {
        while (true)
        {
            Console.Write(mensaje);
            string ingreso = Console.ReadLine();
            bool correcto = int.TryParse(ingreso, out int entero);

            if (!correcto)
            {
                Console.WriteLine("No ha ingresado un entero Valido");

                continue;// Devuelve ejecuccion hacia arriba
            }
            if (entero < min)
            {
                Console.WriteLine($"El minimo es {min}");
                continue;
            }

            if (entero > max)
            {
                Console.WriteLine($"El maximo  {max}");
                continue;
            }

            if (entero % 2 != 0)
            {
                Console.WriteLine("Ingrese un numero par.");
                continue;
            }
            // Siempre al final de todos los if se llega si esta todo bien
            return entero;
        }      
            
    }
    internal static string PedirCadena(string mensaje, int max)
    {
        while (true)
        {
            Console.Write(mensaje);
            string ingreso = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(ingreso)) 
            {
                Console.WriteLine("Ingrese algo");
                continue;
            }
            if (ingreso.Length < max)
            {
                Console.WriteLine("Ingrese un numero menor a 30");
            }
            bool estaOK;
            foreach(char caracter in ingreso)
            {
                if (caracter > '0' && caracter < '9')
                {
                    Console.WriteLine("No ingrese numeros.");
                }
                estaOK = false;


            }

        }
    }
    /*
        internal static string PedirCadena(int max)
    {
        string valor;
        bool flag = false;
        do
        {
            if (string.IsNullOrEmpty(valor = Console.ReadLine()))
            {
                Console.WriteLine("El campo debe tener un valor.");
                Console.Write("Ingrese nuevamente el valor solicitado: ");
            }
            else if (float.TryParse(valor, out float salida))
            {
                Console.WriteLine("El campo no debe ser numerico.");
                Console.Write("Ingrese nuevamente el valor solicitado: ");
            }
            else if (valor.Length > max)
            {
                Console.WriteLine($"El campo debe tener un maximo de {max}.");
                Console.Write("Ingrese nuevamente el valor solicitado: ");

            }
            else
            {
                flag = true;
            }
        }while(flag==false);
        return valor;
    }
    */

    internal static DateTime PedirFecha(string mensaje, DateTime max)
    {
        DateTime salida;
        bool flag = false;
        do
        {
            if (!DateTime.TryParse(Console.ReadLine(), out salida))
            {
                Console.WriteLine("El campo debe ser un valor numerico");
                Console.Write("Ingrese nuevamente el valor solicitado: ");
            }
            else if (salida>DateTime.Now)
            {
                Console.WriteLine($"La fecha ingresada debe ser menor a hoy {DateTime.Now}");
                Console.Write("Ingrese nuevamente el valor solicitado: ");

            }
            else
            {
                flag = true;
            }
        } while (flag == false);
        return salida;
    }
   
}