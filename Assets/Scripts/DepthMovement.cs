using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {    //move obj forward
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 objpos = transform.position;
            objpos.z += 0.05f;
            transform.position = objpos;
        }

        //movebackward
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 objpos = transform.position;
            objpos.z -= 0.05f;
            transform.position = objpos;
        }

        //move left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 objpos = transform.position;
            objpos.x -= 0.1f;
            transform.position = objpos;
        }

        //mpve rigth
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 objpos = transform.position;
            objpos.x += 0.1f;
            transform.position = objpos;
        }
    }
}
