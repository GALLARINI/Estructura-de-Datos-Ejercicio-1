﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class RegistrosPersonas
{
    static List <Persona> personas = new List <Persona> ();
    internal static void Alta()
    {
        //pedirle los datos necesarios para crear un objeto persona 
        //y Grabarlo ese objeto en una lista

        var persona = new Persona();

        Console.Write("Ingrese el numero de Documento a dar de Alta: ");
        persona.Dni = Usuario.PedirEntero(min: 1_000_000, max: 99_999_999);
        Console.Write("Ingrese el NOMBRE a dar de Alta:  ");
        persona.Nombre = Usuario.PedirCadena(max: 30);
        Console.Write("Ingrese el APELLIDO a dar de Alta: ");
        persona.Apellido = Usuario.PedirCadena(max: 30);
        Console.Write("Ingrese la FECHA DE NACIMIENTO a dar de Alta:  ");
        persona.FechadeNacimiento = Usuario.PedirFecha(max: DateTime.Now);

        //Mas validaciones aca
        //Ejercicio que no exista
        personas.Add(persona);
    }

    internal static void Baja()
    {
        Console.Write("Ingrese el numero de Documento a dar de Baja: ");
        int DocumentoBaja= Usuario.PedirEntero(min: 1_000_000, max: 99_999_999);
        foreach (var persona in personas)
        {
            if (persona.Dni == DocumentoBaja)
            {
                personas.Remove(persona);
                return;
            }
        }
        Console.WriteLine($"No se encontro una persona con DNI {DocumentoBaja}");
    }
    internal static void Grabar()
    {
        //Grabar : un archivo de texto en donde cada linea representa una persona
        //Esa linea va a tener los datos de la persona separadas por | ("pipe")
        //La palabra clave usign le dice a .NEt que cierre el archivo tan pronto que termine el metodo
        using var archivoPersonas = new StreamWriter("C:\\Users\\Usuario\\source\\repos\\Clase 15-9\\Clase 15-9\\Personas.txt");
        //Archivo Personas tiene metodos muy parecidos a los de console
        foreach (var persona in personas)
        {
            var linea = $"{persona.Dni}|{persona.Nombre}|{persona.Apellido}|{persona.FechadeNacimiento}";
            archivoPersonas.WriteLine(linea);
        }
        Console.WriteLine("El archivo se Grabo Correctamente.", "\n");
    }
    internal static void Cargar()
    {
        //borrar las personas que ya existen
        personas.Clear();

        using var archivoPersonas = new StreamReader("C:\\Users\\Usuario\\source\\repos\\Clase 15-9\\Clase 15-9\\Personas.txt");

        while (!archivoPersonas.EndOfStream)
        {
            var proximaLinea = archivoPersonas.ReadLine();
            string[] datosSeparados = proximaLinea.Split('|')
                ;
            var persona = new Persona();
            persona.Dni = int.Parse(datosSeparados[0]);
            persona.Nombre = datosSeparados[1];
            persona.Apellido = datosSeparados[2];
            persona.FechadeNacimiento = DateTime.Parse(datosSeparados[3]);

            personas.Add(persona);
        }
        Console.WriteLine("El archivo se Cargo Correctamente.");
    }

    internal static void MostrarLista()
    {
        Console.WriteLine("La lista es:", "\n");
        foreach (var persona in personas)
        {
            Console.WriteLine($"Documento: {persona.Dni}");
            Console.WriteLine($"Apellido: {persona.Apellido}");

            Console.WriteLine($"Nombre: {persona.Nombre}");
            Console.WriteLine($"Fecha de Nacimiento: {persona.FechadeNacimiento}");
            Console.WriteLine("--------------------------------------------");
        }
    }
}

