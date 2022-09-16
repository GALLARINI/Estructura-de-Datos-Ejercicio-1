using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//No tiene NameSpace
    internal class MenuPrincipal
    {
        public static int Mostrar()//
        {
            Console.WriteLine("1-Alta");
            Console.WriteLine("2-Baja");
            Console.WriteLine("3-MostrarLista");
            Console.WriteLine("4-Grabar");
            Console.WriteLine("5-Cargar");
            Console.WriteLine("0- Salir del Sistema");
            Console.Write("Ingrese una opcion y presione [enter]: ");

            return Usuario.PedirEntero(min:0,max:5) ;
        }
    }

