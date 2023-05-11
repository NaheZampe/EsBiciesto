using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EsBiciesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Es Biciesto?";
            string seguir;
            
            do
            {
                Console.Clear();
                Console.Write("Ingrese el año: ");
                var anio = Convert.ToInt32(Console.ReadLine());

                if (EsBiciesto(anio))
                {
                    Console.WriteLine($"El año {anio} es biciesto.");
                }
                else
                {
                    Console.WriteLine($"El año {anio} no es biciesto.");
                }
                Console.Write("¿Desea seguir ingresando años? Y/N: ");
                seguir=Console.ReadLine();
                
            } while (EsValido(seguir));

            Console.ReadKey();
        }

       

        private static bool EsValido(string seguir)
        {
            
            if (seguir.ToUpper() =="Y")
            {
                return true;
            }
            return false;
        }

        private static bool EsBiciesto(int anio)
        {
            if (anio % 4 == 0)
            {
                if (anio % 100 == 0)
                {
                    if (anio % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            
        }
        
    }
}
