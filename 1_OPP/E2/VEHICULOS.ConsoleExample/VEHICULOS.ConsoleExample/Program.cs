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

           

                //while (true)
                //{
                for (int i = 1; i <= 10; i++)
                {
                        Console.WriteLine("TECLEA TU VEHICULO");

                            string vehiculoType = Console.ReadLine().ToLower();//para poder ingresar minusculas
                              Vehiculo vehiculo = null;

                                     switch (vehiculoType)
                                         {

                                            case "camion":
                                                vehiculo = new Camion();
                                                break;

                                            case "auto":
                                                vehiculo = new Auto();
                                                break;

                                            case "tren":
                                                vehiculo = new Tren();
                                                break;


                                            default:
                                                Console.WriteLine("vehiculo no encontrado");
                                                System.Threading.Thread.Sleep(500);
                                                break;
                                     
                                        }//llave del switch


                                          if (vehiculo != null){

                                            vehiculo.VehiculoSound();
                                    
                                           }//llave del if



            }//llave del for

            Console.WriteLine("Termina el ciclo, ya fueron 10 veces");
            System.Threading.Thread.Sleep(800);

            //}//llave del while


        }//llave del void
    }
}
