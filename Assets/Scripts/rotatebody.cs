using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Script for rotating the body via Joystick
 * 
 */

public class rotatebody : MonoBehaviour
{
    // Start is called before the first frame update
    public Joystick joystick;
    public float rotateHorizontal;
    public float rotateVertical;

    public void Update()
    {
        rotateVertical = joystick.Vertical * -1;
        rotateHorizontal = joystick.Horizontal * 1;
        transform.Rotate(rotateVertical, rotateHorizontal, 0);
    }
}
