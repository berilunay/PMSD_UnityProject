using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

/*
 *This script controls the distance calculation and sonification
 * for the closeview scene
 * 
 * 
 */

public class distanceNewSceneScript : MonoBehaviour

{
    // Start is called before the first frame update
    public GameObject scalpel; ///knife
    public GameObject tumor_new;
    public Text change_text_new;
    public float distance_tumor;
    public AudioSource audio_last;
    public AudioSource audio_thunder;
    public AudioSource audio_rain;
    public AudioClip audio_last_clip;
    public AudioClip audio_thunder_clip;
    public AudioLowPassFilter filter_low_pass_last;
    public AudioLowPassFilter filter_low_pass_rain;
    public AudioLowPassFilter filter_low_pass_tumor;
    public float standart_value_lpf = 5007;


    void Start()
    {

        //audio_thunder.PlayOneShot(audio_thunder.clip);
        //audio_last.PlayOneShot(audio_last.clip);
        audio_rain.PlayOneShot(audio_rain.clip);
        audio_thunder.clip = audio_thunder_clip;
        audio_last.clip = audio_last_clip;  
        audio_thunder.Play();
        audio_last.Play();
        audio_thunder.Pause();
        audio_rain.Pause();
        filter_low_pass_last=audio_last.GetComponent<AudioLowPassFilter>();
        filter_low_pass_rain = audio_rain.GetComponent<AudioLowPassFilter>();
        filter_low_pass_last.cutoffFrequency = 5007; //original default value for LPF

    }

    // Update is called once per frame
    void Update()
    {

        distance_tumor = Vector3.Distance(scalpel.transform.position, tumor_new.transform.position);
        change_text_new.text = "Distance to the tumor is: " + distance_tumor;

        //3.16,4 3.16-2.08

        if (distance_tumor > 2.02 && distance_tumor <= 3.16)
        {
            
            audio_last.Pause();
            audio_thunder.Pause();
            audio_rain.Play();

           
            filter_low_pass_rain.cutoffFrequency = 5007- distance_tumor * 750;
           

            if (distance_tumor >2.20 && distance_tumor <= 3.0)
            {
                filter_low_pass_rain.cutoffFrequency =5007- distance_tumor * 400;
            }

            if (distance_tumor >= 2.01 && distance_tumor <= 2.20)
            {   
               filter_low_pass_rain.cutoffFrequency = standart_value_lpf;
            }

            Debug.Log("you are in range 2-3");

        }
        else if (distance_tumor <= 2)
        {
        
            Debug.Log("you are in range <2");
            audio_rain.Pause();
            audio_last.Pause();
            audio_thunder.UnPause();
            
        }

        else
        {
           
            audio_thunder.Pause();
            audio_rain.Pause();
            audio_last.UnPause();
            Debug.Log("you are out");
            

            if(distance_tumor<=6 &&distance_tumor>=4.2)
            {
                filter_low_pass_last.cutoffFrequency =  distance_tumor * 1000;
            }
            else if(distance_tumor <4.2 && distance_tumor >= 3.17)
            {
                filter_low_pass_last.cutoffFrequency = distance_tumor * 1000-1700;
            }
            
            
        }

    }

}
      
        










/* if (distance_tumor <= 2)
 {

     Debug.Log("Distance to the tumor is: " + distance_tumor + " High Risk!!");
     change_text_new.text = "Distance to the tumor is: " + distance_tumor + " High Risk!!";
     audio_last.Pause();
     GetComponent<ChuckSubInstance>().RunCode(@"
     SinOsc foo => dac;
     300 => foo.freq;
     0.5 => foo.gain;
     0.5::second => now;
     ");
 }*/

/*
 * 
 * 
 * if (distance_tumor <= 4 && distance_tumor > 3)
  {
     audio_last.PlayOneShot(clip_last);

   }
 * if (distance_tumor <= 3 && distance_tumor > 2)
    { 
        audio_last.Pause();
        audio_middle.PlayOneShot(clip_last);

    }
     if (distance_tumor <= 2 && distance_tumor > 1)
    { 
        audio_last.Pause();
        audio_middle.Pause();
        audio_tumor.PlayOneShot(clip_last);

    }*/


     /*if (distance_tumor>3 && distance_tumor<=4)
        {
            //audio_last.Play();
            //audio_thunder.Pause();
            Debug.Log("you are in range 3-4");

        }
        if(distance_tumor <= 2)
        {
            audio_last.Pause();
            audio_thunder.Play();
        }
        else
        {
            audio_thunder.Pause();
            audio_last.Play();
            Debug.Log("you are out");

        }*/
      







