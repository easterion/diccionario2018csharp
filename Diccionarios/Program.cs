using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero ="1";

            Dictionary<string, Persona> diccionario = new Dictionary<string, Persona>();
            diccionario.Add("Bart", (new Persona("Bart", "simpson", 10)));
            diccionario.Add("Lisa", (new Persona("Lisa", "simpson", 8)));
            diccionario.Add("March", (new Persona("March", "simpson", 30)));
            diccionario.Add("Homero", (new Persona("Homero", "simpson", 36)));
            diccionario.Add("Maggy", (new Persona("Maggy", "simpson", 1)));

            string linea = "";

            while (numero != "0")
            {
                linea = Console.ReadLine();
                if(diccionario.ContainsKey(linea))
                {
                    Console.WriteLine();
                    Console.WriteLine("el nombre de la persona es :{0} {1}, y tiene {2} anios", (diccionario[linea]).nombre, (diccionario[linea]).apellido, (diccionario[linea]).edad);
                }
                else
                {
                    Console.WriteLine("no coincide, intente nuevamente");
                }

                Console.WriteLine();
                Console.WriteLine("1 -> Intentar nuevamente");
                Console.WriteLine("0 -> Cerrar");
                Console.WriteLine();
                numero = Console.ReadLine();
                if (numero == "0")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                }
            }

                
            //while(numero != "0")
            //{
            //    linea = Console.ReadLine();
            //    try
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("el nombre de la persona es :{0} {1}, y tiene {2} anios",(diccionario[linea]).nombre, (diccionario[linea]).apellido, (diccionario[linea]).edad);
            //    }
            //    catch(KeyNotFoundException )
            //    {
            //        Console.WriteLine("no coincide, intente nuevamente");
            //    }
            //    finally
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("1 -> Intentar nuevamente");
            //        Console.WriteLine("0 -> Cerrar");
            //        Console.WriteLine();
            //        numero = Console.ReadLine();
            //        if(numero == "0")
            //        {
            //            Environment.Exit(0);
            //        }
            //        else
            //        {
            //            Console.Clear();
            //        }
            //    }
            //}
            
            Console.ReadKey();
        }
        
    }
}
