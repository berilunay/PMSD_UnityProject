﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Script for zooming in and out with mouse scrollwheel
 * 
 */

public class zoomCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Mouse ScrollWheel")>0)
        {
            GetComponent<Camera> ().fieldOfView--;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            GetComponent<Camera> ().fieldOfView++;
        }
    }

    public void resetCameraView()
    {
        GetComponent<Camera>().fieldOfView = 60;
    }
}
