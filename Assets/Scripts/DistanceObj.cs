using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceObj : MonoBehaviour

{
    /* This class is the place where distance between knife and tumor,vessels are calculated. 
     * Sonification were implemented in this script for sample scene.2 audio were used and the
     * sound changes according to distance of each object. As we get close to the tumor and other structures
     * pitch is decreasing so that we can hear kind of and high frequency and faster sound.
     * 
    */
    // Start is called before the first frame update
    public GameObject knife; ///knife
    public GameObject body; //body
    public GameObject tumor;
    public Text change_text;
    public Text change_text2;
    public string distance_string;
    public GameObject[] objects_array; //holds all the game objects tagged with "objects", which includes vessels
    public int size;
    public float distance_obj;
    public float distance_to_tumor;
    public AudioSource audio_alert1;
    public AudioSource audio_alert2;
    public AudioClip clip1;
    public AudioClip clip2;
    float newSpeed = 1.0f;


    void Start()
    {
        objects_array = GameObject.FindGameObjectsWithTag("objects"); //put objects inside an array
                                                                    
        audio_alert1.GetComponent<AudioSource>();                                                             
        audio_alert2.GetComponent<AudioSource>();
        audio_alert1.clip = clip1;
        audio_alert2.clip = clip2;
        audio_alert2.Play();
        audio_alert1.Play();
        audio_alert1.Pause();
        audio_alert2.Pause();


    }


    // Update is called once per frame
    void Update()
    {

        size = objects_array.Length;
        distance_to_tumor = Vector3.Distance(knife.transform.position, tumor.transform.position);
        change_text.text = "Distance to the tumor is: " + distance_to_tumor;


        for (int i = 0; i < size; i++)
        {
            distance_obj = Vector3.Distance(knife.transform.position, objects_array[i].transform.position);
            Debug.Log("distance to " + objects_array[i].name + " is: " + distance_obj);
            
            
            if (distance_to_tumor <= 3.2)
            {
                audio_alert1.UnPause();
                audio_alert2.Pause();

                
                newSpeed = 3.0f - distance_to_tumor* 0.6f;
                audio_alert1.pitch =newSpeed;
              
                if (distance_to_tumor <= 2)
                {
                    Debug.Log("Distance to the tumor is: " + distance_to_tumor + " High Risk!!");
                    change_text.text = "Distance to the tumor is: " + distance_to_tumor + " High Risk!!";

                    audio_alert1.pitch = 1.8f;
                   

                    if(distance_to_tumor<=1)
                    {
                        audio_alert1.pitch = 1.9f;
        
                    }
                }
                

            }

            else if (distance_obj < 2)
            {
                Debug.Log("distance to " + objects_array[i].name + " is: " + distance_obj + " high risk");
                change_text2.text = "Distance to " + objects_array[i].name + " is: " + distance_obj + " high risk!!";
                audio_alert2.pitch = 1.2f;
                audio_alert2.UnPause();
                if(distance_obj<=1)
                {
                    audio_alert2.pitch = 1.6f;
                }

            }

            else
            {

                change_text2.text = "Distance to " + objects_array[i].name + " is: " + distance_obj;
                audio_alert1.Pause();
                audio_alert2.Pause();
            }
            

        }

    }

   
}
            
       
    
