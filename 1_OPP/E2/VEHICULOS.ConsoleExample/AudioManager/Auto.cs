using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace AudioManager
{
    public class Auto : Vehiculo 
    {
        public override void VehiculoSound()//override es la palabra para sobreescribir el comportamiento del metodo VehiculoSound
        {
            Console.WriteLine("Clase hija Auto");
            AudioFileReader audioFile = new AudioFileReader("resources/auto.mp3");
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
 