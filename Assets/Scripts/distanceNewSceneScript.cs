using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distanceNewSceneScript : MonoBehaviour

{
    // Start is called before the first frame update
    public GameObject scalpel; ///knife
    public GameObject tumor_new;
    public Text change_text_new;
    public float distance_tumor;
    
    


    // Update is called once per frame
    void Update()
    {

        distance_tumor = Vector3.Distance(scalpel.transform.position, tumor_new.transform.position);
        change_text_new.text = "Distance to the tumor is: " + distance_tumor ;

        if (distance_tumor <= 2)
        {
            Debug.Log("Distance to the tumor is: " + distance_tumor + " High Risk!!");
            change_text_new.text = "Distance to the tumor is: " + distance_tumor + " High Risk!!";

            GetComponent<ChuckSubInstance>().RunCode(@"
			SinOsc foo => dac;
            300 => foo.freq;
            0.5 => foo.gain;
            0.5::second => now;
		    ");
        }
     }

            
 }




    





       


    

