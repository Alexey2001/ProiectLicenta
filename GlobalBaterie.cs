using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Baterie : MonoBehaviour
{
    public GameObject AfisajBaterii;
    public static int NumarBaterii = 0;
    public int internalBaterii;


    void Update()
    {
        internalBaterii = NumarBaterii;
        AfisajBaterii.GetComponent<Text>().text = " " + NumarBaterii + "/3";
    }
}
