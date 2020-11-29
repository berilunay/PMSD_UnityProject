using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 initpos1;
    Vector3 initpos2;
    public GameObject obj1;
    public GameObject obj2;

    public void Start()
    {
        initpos1 = this.obj1.transform.position;
        initpos2 = this.obj2.transform.position;

    }

    // Update is called once per frame
    public void Resetpos()
    {
        this.obj1.transform.position = initpos1;
        this.obj2.transform.position = initpos2;
    }
}
