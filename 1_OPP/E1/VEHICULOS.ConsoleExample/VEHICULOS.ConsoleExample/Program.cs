using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;

namespace VEHICULOS.ConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___MENSAJE DE CONSOLA___");
            Console.WriteLine("Vehiculo");

            Vehiculo vehiculo = new Vehiculo();
            vehiculo.VehiculoSound();

            Console.ReadKey();//este metodo deja la consola en espera hasta que el usuario presione cualquier tecla y se cierra la consola 
        }
    }
}
