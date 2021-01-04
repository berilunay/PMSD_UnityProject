using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newdragdrop : MonoBehaviour
{
    private Vector3 mmOffset;
    private float mmZCoord;



    void OnMouseDown()
    {

        mmZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        // Store offset = gameobject world pos - mouse world pos

        mmOffset = gameObject.transform.position - GetMouseAsWorldPoint();

    }


    private Vector3 GetMouseAsWorldPoint()

    {
        // Pixel coordinates of mouse (x,y)

        Vector3 mouse_Point = Input.mousePosition;

        // z coordinate of game object on screen

        mouse_Point.z = mmZCoord;

        // Convert it to world points
        return Camera.main.ScreenToWorldPoint(mouse_Point);

    }

    void OnMouseDrag()

    {
        transform.position = GetMouseAsWorldPoint() + mmOffset;
    }

}
