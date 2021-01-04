using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTransparency : MonoBehaviour

{

    public GameObject body;
    public GameObject tumor;
    public float alpha = 0.4f;
    public GameObject vessel_big;
    public GameObject vessel_amnesic;
    public GameObject vessel_tree;
    public GameObject vessel_amnesic2;



    public void ChangeBody()
    {
        //resetalpha(body.GetComponent<Renderer>().material);
        ChangeAlpha(body.GetComponent<Renderer>().material, alpha);
        resetalpha(tumor.GetComponent<Renderer>().material);
        resetalpha(vessel_big.GetComponent<Renderer>().material);
        resetalpha(vessel_amnesic.GetComponent<Renderer>().material);
        resetalpha(vessel_amnesic2.GetComponent<Renderer>().material);
        resetalpha(vessel_tree.GetComponent<Renderer>().material);

    }

    public void ChangeTumor()

    {
        resetalpha(tumor.GetComponent<Renderer>().material);
        ChangeAlpha(body.GetComponent<Renderer>().material, alpha);
        ChangeAlpha(vessel_big.GetComponent<Renderer>().material, alpha);
        ChangeAlpha(vessel_amnesic.GetComponent<Renderer>().material, alpha);
        ChangeAlpha(vessel_amnesic2.GetComponent<Renderer>().material, alpha);
        ChangeAlpha(vessel_tree.GetComponent<Renderer>().material, alpha);
    }

    public void ChangeVessel()
    {
        resetalpha(vessel_big.GetComponent<Renderer>().material);
        resetalpha(vessel_amnesic.GetComponent<Renderer>().material);
        resetalpha(vessel_amnesic2.GetComponent<Renderer>().material);
        resetalpha(vessel_tree.GetComponent<Renderer>().material);
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
