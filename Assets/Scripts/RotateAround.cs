using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 previous_pos = Vector3.zero; //previous position of the mouse
    public Vector3 position_delta = Vector3.zero; //changing position of the mouse from last frame to current frame 
    public GameObject selected_obj;
    public string object_selected_name;
    public string selected_obj_name;

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;

            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit);
            //ourObject = hit.collider.gameObject ;
            //Debug.Log("hit: " + hit.point);

            object_selected_name = hit.transform.gameObject.name;
            selected_obj_name = selected_obj.name;

            position_delta = Input.mousePosition - previous_pos;


            if (object_selected_name == selected_obj_name)
            {

                //position_delta = Input.mousePosition - previous_pos;

                if (Vector3.Dot(transform.up, Vector3.up) >= 0)
                {
                    transform.Rotate(transform.up, -Vector3.Dot(position_delta, Camera.main.transform.right), Space.World);
                    transform.Rotate(Camera.main.transform.right, Vector3.Dot(position_delta, Camera.main.transform.up), Space.World);
                }

                else
                {
                    transform.Rotate(transform.up, Vector3.Dot(position_delta, Camera.main.transform.right), Space.World);
                    transform.Rotate(Camera.main.transform.right, -Vector3.Dot(position_delta, Camera.main.transform.up), Space.World);
                }
                
            }

            previous_pos = Input.mousePosition;
        }
    }

}
