using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GlobalBaterie : MonoBehaviour
{
    public GameObject batteryDisplay;
    public static int NumarBaterii = 0;
    public int internalBattery;


    void Update()
    {
        internalBattery = NumarBaterii;
        batteryDisplay.GetComponent<Text>().text = " " + NumarBaterii + "/3";
    }
}
