using System.Net.Http.Headers;

internal class Usuario
{
    public static int PedirEntero(int min, int max)
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

    internal static DateTime PedirFecha(DateTime max)
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