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
        Console.WriteLine("MenuPrincipal");
            Console.WriteLine("1-Alta de Persona");
            Console.WriteLine("2-Baja de Persona");
            Console.WriteLine("3-MostrarLista de Persona");
            Console.WriteLine("4-Grabar Personas");
            Console.WriteLine("5-Cargar Personas");
            Console.WriteLine("0- Salir del Sistema");

            return Usuario.PedirEntero("Ingrese una opcion y presione [enter]: ", min:0,max:5) ;
        }
    }

