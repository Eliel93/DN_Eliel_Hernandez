using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace AudioManager
{
    public class Lion : Animal
    {
        public override void AnimalSound()//la palabra reservada override es para poder modificar el metodo heredado, "void" por que no devuelve ningun tipo de dato
        {
            //Console.WriteLine("Yo soy la clase perro");

            AudioFileReader audioFile = new AudioFileReader("Resources/lion.wav");
            WaveOutEvent waveOutEvent = new WaveOutEvent();

            waveOutEvent.Init(audioFile);
            waveOutEvent.Play();

            while (waveOutEvent.PlaybackState == PlaybackState.Playing)
            {
                System.Threading.Thread.Sleep(500);


            }
            waveOutEvent.Dispose();
            audioFile.Dispose();
        }
    }
}
