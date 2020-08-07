using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colour : MonoBehaviour
{
    public Color[]  bodycolors;
    public Material  bodyMat;



    public void ChangeColor(int colorIndex)
    {
        bodyMat.color = bodycolors[colorIndex];
    }

   
}
