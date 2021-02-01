using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Script for reseting the positions of the objects and camera after any movement
 */

public class ResetPosition : MonoBehaviour
{
    // This script is used to reset the positions of body and scalpel
    Vector3 initpos1;
    public Quaternion originalRotationValue;
    public GameObject knife;
    public GameObject camera;


    /* Saving the initial positions*/
    public void Start()
    {
        initpos1 = this.knife.transform.position;
        originalRotationValue = this.camera.transform.rotation;

    }

    // Update is called once per frame
    public void Resetpos()
    {
        
        this.knife.transform.position = initpos1;
        //rotate the body back to its initial position
        this.camera.transform.rotation = Quaternion.Slerp(transform.rotation, originalRotationValue, Time.time * 1f); 
       
    }

 
}
