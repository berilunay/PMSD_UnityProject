using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickTrial : MonoBehaviour

{
    // Start is called before the first frame update
    public GameObject sphere;
    public void destroy()
    {
        sphere.SetActive(false);
    }
}
