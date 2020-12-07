using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceObj : MonoBehaviour

{
    // Start is called before the first frame update
    public GameObject knife; ///knife
    public GameObject body; //body
    public GameObject tumor;
    

    public float distance_main; // distance to body
    public string distance_string;

    public GameObject[] objects_array;
   // public List<float> distance_list = new List<float>(); //hold the game objects distance to the knife
    public int size;
    public float distance_obj;
    public float distance_to_tumor;



    void Start()
    {
        objects_array = GameObject.FindGameObjectsWithTag("objects"); //put objects inside an array


    }
    

    // Update is called once per frame
    void Update()
    {
        
        size = objects_array.Length;

        //distance_main = Vector3.Distance(knife.transform.position, body.transform.position);
        distance_to_tumor = Vector3.Distance(knife.transform.position, tumor.transform.position);

        /*if (distance_main<2)
        {
            Debug.Log("distance to the body is: " + distance_main + " High Risk!!");
        }*/
        if(distance_to_tumor < 2)
        {
            Debug.Log("distance to the tumor is: " + distance_to_tumor + " High Risk!!");
            GetComponent<ChuckSubInstance>().RunCode(@"
			        SinOsc foo => dac;
                    300 => foo.freq;
                    0.5 => foo.gain;
                    0.5::second => now;
		         ");

        }
        else
        {
            //Debug.Log("distance to the body is: " + distance_main);
            Debug.Log("distance to the tumor is: " + distance_to_tumor);
        }


        for (int i = 0; i < size; i++)
        {
            distance_obj = Vector3.Distance(knife.transform.position, objects_array[i].transform.position); 
            Debug.Log("distance to object "+ objects_array[i].name+ " is: " + distance_obj);

           if (distance_obj < 2)
            {
                Debug.Log("distance to the object " + objects_array[i].name + " is: " + distance_obj + " high risk");

                GetComponent<ChuckSubInstance>().RunCode(@"
			        SinOsc foo => dac;
                    300 => foo.freq;
                    0.5 => foo.gain;
                    0.5::second => now;
		         ");

            }

        }
        
            //distance_arr[0] = Vector3.Distance(knife.transform.position, objects_array[0].transform.position);

            
        /* distance_obj = Vector3.Distance(knife.transform.position, objects_array[2].transform.position);
         distance_obj2 = Vector3.Distance(knife.transform.position, objects_array[1].transform.position);
         distance_obj3 = Vector3.Distance(knife.transform.position, objects_array[0].transform.position);
         Debug.Log("distance to obj 1 is " + distance_obj);
         Debug.Log("distance to obj 2 is " + distance_obj2);
         Debug.Log("distance to obj 3 is " + distance_obj3);*/

            

        //distance print and calculation only between body and knife
       
        //distance_main = Vector3.Distance(knife.transform.position, obj2.transform.position); //distance between knife and body


        
        /*if (distance_main < 2)
        {
            Debug.Log("too close danger");
            Debug.Log("distance to the body is: "+distance_main);  
        }

        /*else if(distance_obj<2)
        {
            Debug.Log("distance to the obj1 is: " + distance_obj+ " high risk");
        }
        else if (distance_obj2 < 2)
        {
            Debug.Log("distance to the obj2 is: " + distance_obj2 + " high risk");
        }
        else if (distance_obj3 < 2)
        {
            Debug.Log("distance to the obj3 is: " + distance_obj3 + " high risk");
        }*/

      /*  else
        {
           
            Debug.Log("distance to the body is: " + distance_main);
            //Debug.Log("distance to the obj1 is: " + distance_obj);
            //Debug.Log("distance to the obj2 is: " + distance_obj2);
            //Debug.Log("distance to the obj3 is: " + distance_obj3);

        }
        */


    }
}
