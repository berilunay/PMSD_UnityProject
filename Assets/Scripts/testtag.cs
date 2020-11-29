using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testtag : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject test;
    void Start()
    {
        if(test.tag=="objects")
        {
            Debug.Log("no problem on tag");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
