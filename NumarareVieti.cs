using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class NumarareVieti : MonoBehaviour
{
    public GameObject AfisajNrVieti;
    public static int NrVieti = 3;
    public int internalNrVieti;

    
    void Update()
    {
        internalNrVieti = NrVieti;
        AfisajNrVieti.GetComponent<Text>().text = " " + NrVieti + "/3";
    }
}
