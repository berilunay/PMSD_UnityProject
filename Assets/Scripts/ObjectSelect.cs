using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelect : MonoBehaviour
{
    public string object_name;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit);
            //ourObject = hit.collider.gameObject ;
            //Debug.Log("hit: " + hit.point);
           
            object_name = hit.transform.gameObject.name;
            Debug.Log("the selected object is: "+object_name);

        }
    }
}
