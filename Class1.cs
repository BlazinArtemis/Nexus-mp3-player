using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMp3Player
{
    class Class1
    {
        public float slidervalue=0.0f;
        public AudioSource audiocccenter;
        public AudioClip myaudiocc;


        slidervalue = GUI.HorizontalSlider (new Rect (padding +370 * wdpi, 440* hdpi, 90 * wdpi, 44* hdpi), slidervalue,  0.0f, 1.0f);
            
        audiocccenter = (AudioSource)gameObject.AddComponent ("AudioSource");

        myaudiocc = (AudioClip)Resources.Load ("Clip name");
        audiocccenter.clip = myaudiocc;

        audiocccenter.Play();
        AudioListener.volume = slidervalue; 
    }
}
