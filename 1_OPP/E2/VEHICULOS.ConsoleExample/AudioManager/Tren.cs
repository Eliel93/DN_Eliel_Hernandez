using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace AudioManager
{
    public class Tren : Vehiculo
    {
        public override void VehiculoSound()//para sobreescribir el comportamiento del metodo VehiculoSound
        {
            Console.WriteLine("Clase hija tren");
            AudioFileReader audioFile = new AudioFileReader("resources/tren.mp3");
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
