using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioManager
{
    public class Vehiculo
    {

        public virtual void VehiculoSound()//virtual indica el metodo que PUEDE ser sobreescrito
        {
            Console.WriteLine("*****este es un vehiculo****");
           /* Console.WriteLine("This is a Train");
            Console.WriteLine("This is a Car");
            Console.WriteLine("This is a Buss");*/
            
        }
    }
}
