using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TumorAlert : MonoBehaviour
{
    public GameObject scalpel;
    public GameObject tumor;
    public float distanceto_tumor;
    public Text change_text;
    public bool is_inside=false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanceto_tumor = Vector3.Distance(scalpel.transform.position, tumor.transform.position);
        change_text.text = "Distance to the tumor is: " + distanceto_tumor;

        if (distanceto_tumor<=2)
        {
            is_inside = true;
        }
        if(is_inside)
        {
            if(distanceto_tumor>2 && distanceto_tumor<5)
            {
                GetComponent<ChuckSubInstance>().RunCode(@"
			        SinOsc foo => dac;
                    300 => foo.freq;
                    0.5 => foo.gain;
                    0.5::second => now;
		         ");
                Debug.Log("Distance to the tumor is: " + distanceto_tumor);
                change_text.text = "You are outside of the resection path, High Risk!! " + distanceto_tumor;
            }
        }
    }
}
