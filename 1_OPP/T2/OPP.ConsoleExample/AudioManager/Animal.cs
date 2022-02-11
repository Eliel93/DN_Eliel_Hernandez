using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace AudioManager
{
    public class Animal//esta es la clase padre, que heredara a los hijos y que va a les va a pasar el hello im animal
    {
        public virtual void AnimalSound()//el virtual es para que un metodo de la clase padre pueda ser modificado en las clases hijas
        {
            Console.WriteLine("Hello, I´m an animal!");
        }
    }
}
//el polimorfismo es modificar el comportamiento de un metodo heredado, que haga diferentes cosas