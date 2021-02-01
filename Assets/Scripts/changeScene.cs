using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 * Script for changing the scenes
 * 
 */
public class changeScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void closeViewScene()
    {
        SceneManager.LoadScene("CloseViewScene");
    }

    public void sampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

  

    public void sonification2()
    {
        SceneManager.LoadScene("sonification2");
    }





}
