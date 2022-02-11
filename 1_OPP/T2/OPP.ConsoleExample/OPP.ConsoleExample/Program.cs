using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;
namespace OPP.ConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {


            while(true){

                Console.WriteLine("TYPE THE ANIMAL");
                string animalType = Console.ReadLine().ToLower();

                Animal animal = null;

                switch (animalType)
                {

                    case "cat":

                        animal = new Cat();
                        break;

                    case "dog":

                        animal = new Dog();
                        break;

                    case "pig":

                        animal = new Pig();
                        break;

                    case "lion":

                        animal = new Lion();
                        break;

                    case "elephant":

                        animal = new Elephant();
                        break;

                    case "cow":

                        animal = new Cow();
                        break;


                    default:

                        Console.WriteLine("Animal not found");
                        System.Threading.Thread.Sleep(150);
                        break;

                }


                if (animal != null)
                {
                    animal.AnimalSound();
                }



            }//LLAVE DEL WHILE 






        }
    }
}


/*Console.WriteLine("TYPE ANIMAL");

            Animal animal = new Animal();
            animal.AnimalSound();

            Dog dog = new Dog();
            dog.AnimalSound();

            Elephant elephant = new Elephant();
            elephant.AnimalSound();

            Cat cat = new Cat();
            cat.AnimalSound();

            Pig pig = new Pig();
            pig.AnimalSound();

            Lion lion = new Lion();
            lion.AnimalSound();

            Cow cow = new Cow();
            cow.AnimalSound();
            Console.ReadKey()*/