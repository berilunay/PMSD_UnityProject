using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTransparency : MonoBehaviour

{

    public GameObject body;
    public GameObject tumor;
    public float alpha = 0.4f;
    public GameObject vessel1;
    public GameObject vessel2;



    public void ChangeBody()
    {
        resetalpha(body.GetComponent<Renderer>().material);
        ChangeAlpha(tumor.GetComponent<Renderer>().material, alpha);
    }

    public void ChangeTumor()

    {
        resetalpha(tumor.GetComponent<Renderer>().material);
        ChangeAlpha(body.GetComponent<Renderer>().material, alpha);
        ChangeAlpha(vessel1.GetComponent<Renderer>().material, alpha);
        ChangeAlpha(vessel2.GetComponent<Renderer>().material, alpha);
    }

    public void ChangeVessel()
    {
        resetalpha(vessel1.GetComponent<Renderer>().material);
        resetalpha(vessel2.GetComponent<Renderer>().material);
        ChangeAlpha(body.GetComponent<Renderer>().material, alpha);
        ChangeAlpha(tumor.GetComponent<Renderer>().material, alpha);

    }


    public void ChangeAlpha(Material mat, float alphaVal)
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaVal);
        mat.SetColor("_Color", newColor);

    }

    public void resetalpha(Material mat2)
    {
        Color oldColor1 = mat2.color;
        Color newColor1 = new Color(oldColor1.r, oldColor1.g, oldColor1.b);
        mat2.SetColor("_Color", newColor1);

    }
}
